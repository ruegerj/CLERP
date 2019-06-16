import { Component, OnInit, ViewChild } from '@angular/core';
import { ZXingScannerComponent } from '@zxing/ngx-scanner';
import { ProductService, ProductTypeService, WarehouseService } from '@_generated/services';
import { ProductCreateRequestModel, WarehouseResponse, WarehouseShelfResponse, ProductCreateRequest } from '@_generated/models';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Product } from '@_models';
import { Subject } from 'rxjs';
import { debounceTime } from 'rxjs/operators';

@Component({
  selector: 'app-scanProducts',
  templateUrl: './scanProducts.component.html',
  styleUrls: ['./scanProducts.component.scss']
})
export class ScanProductsComponent implements OnInit {
  @ViewChild('scanner')
  scanner: ZXingScannerComponent;

  public isScanning: boolean = false;

  public hasCameras: boolean = false;
  public hasPermission: boolean;

  public availableDevices: Array<MediaDeviceInfo>;
  public selectedDevice: MediaDeviceInfo = null;

  public productsCreateForm: FormGroup;
  public submitted: boolean = false;

  public scannedProducts: Array<Product> = new Array<Product>();

  public warehouses: Array<WarehouseResponse>;
  public selectedWarehouse: WarehouseResponse;
  public selectedShelf: WarehouseShelfResponse;

  private _alert = new Subject<{message: string, type: string}>();

  public alert: any;

  constructor(
    private productService: ProductService,
    private productTypeService: ProductTypeService,
    private warehouseService: WarehouseService,
    private formBuilder: FormBuilder
  ) { }


  ngOnInit(): void {
    this.productsCreateForm = this.formBuilder.group({
      warehouse: ['', Validators.required],
      shelf: ['', Validators.required],
      compartment: ['', Validators.required]
    });


    /** get all warehouses and sort warehouses, shelves and compartments */
    this.warehouseService.GetAllWarehouses().subscribe(data => {
      console.log(data);

      this.warehouses = data.warehouses.sort(function (a, b) {
        var x = a.name.toLowerCase();
        var y = b.name.toLowerCase();
        if (x < y) { return -1; }
        if (x > y) { return 1; }
        return 0;
      });

      this.warehouses.forEach(w => {
        w.shelves.sort(function (a, b) {
          var x = a.designation.toLowerCase();
          var y = b.designation.toLowerCase();
          if (x < y) { return -1; }
          if (x > y) { return 1; }
          return 0;
        })

        w.shelves.forEach(s => s.compartments.sort(function (a, b) { return a.row - b.row || a.column - b.column; }));
      });
    });

    this.f.warehouse.valueChanges.subscribe(val => {
      this.selectedWarehouse = val;
    });

    this.f.shelf.valueChanges.subscribe(val => {
      this.selectedShelf = val;
    });



    this.scanner.camerasFound.subscribe((devices: MediaDeviceInfo[]) => {
      this.hasCameras = true;

      console.log('Devices: ', devices);
      this.availableDevices = devices;

      // selects the devices's back camera by default
      // for (const device of devices) {
      //     if (/back|rear|environment/gi.test(device.label)) {
      //         this.scanner.changeDevice(device);
      //         this.selectedDevice = device;
      //         break;
      //     }
      // }
    });

    this.scanner.camerasNotFound.subscribe((devices: MediaDeviceInfo[]) => {
      console.log('An error has occurred when trying to enumerate your video-stream-enabled devices.');
    });

    this.scanner.permissionResponse.subscribe((answer: boolean) => {
      this.hasPermission = answer;
    });


    this._alert.subscribe(({message, type}) => {
      this.alert = {message: message, type: type};
    });
    this._alert.pipe(
      debounceTime(5000)
    ).subscribe(() => this.alert = null);
  }


  // convenience getter for easy access to form fields
  get f() { return this.productsCreateForm.controls; }



  public handleQrCodeResult(resultString: string) {
    console.log('Result: ', resultString);
    let scannedProduct: ProductCreateRequestModel = JSON.parse(resultString);


    if (this.scannedProducts.map(sp => sp.RequestModel.serialNumber).includes(scannedProduct.serialNumber)) {
      this._alert.next({message: "Product has allready been scanned",type: "warning"});
      return;
    }

    this.productTypeService.GetProductTypeById(scannedProduct.productTypeId).subscribe(data => {
      let productToAdd: Product = new Product(data.name, scannedProduct);
      this.scannedProducts.push(productToAdd);
      this._alert.next({ message: "QR code scanned succesfully", type: "success"});
    }, error => {
      console.log(error);
      this._alert.next({message: "Erro while getting Product type",type: "warning"});
    })

  }


  public onDeviceSelectChange(selectedValue: string) {
    console.log('Selection changed: ', selectedValue);
    this.scanner.updateVideoInputDevices().then((infos: MediaDeviceInfo[]) => {
      console.log(infos);
      this.selectedDevice = infos.find(x => x.deviceId == selectedValue);
    });
  }


  public onCompartmentSelectionChanged(product: Product){
    console.log("on change executed");
    product.RequestModel.compartmentId = this.f.compartment.value;
  }


  public startScanningClicked(): void {
    if(this.f.warehouse.invalid){
      this._alert.next({message: "Warehouse must be selected", type: "warning"});
      return;
    }

    if(this.f.shelf.invalid){
      this._alert.next({message: "Shelf must be selected", type: "warning"});
      return;
    }

    this.scanner.device = this.selectedDevice;
    this.scanner.reset;
    this.isScanning = true;
  }


  public stopScanningClicked(): void {
    this.isScanning = false;
  }


  public removeProductClicked(product: Product): void {
    const index: number = this.scannedProducts.indexOf(product);
    if (index !== -1) {
      this.scannedProducts.splice(index, 1);
    }
  }

  public registerProductsClicked(): void{
    console.log(this.scannedProducts.map(sp => sp.RequestModel));
    console.log(this.scannedProducts.map(sp => sp.RequestModel).some(x => !x.hasOwnProperty("compartmentId")));


    if(this.scannedProducts.map(sp => sp.RequestModel).some(x => !x.hasOwnProperty("compartmentId"))){
      alert("Every product must have a compartment selected!");
      return;
    }

    this.productService.CreateProduct({products: this.scannedProducts.map( sp => sp.RequestModel)}).subscribe(data => {
      console.log(data);
      this.scannedProducts.length = 0;
      alert("Products registered succsessfully.");
    }, error => {
      alert(error);
      console.log(error)
    });
  }
}
