import { Component, OnInit, ViewChild } from '@angular/core';
import { ZXingScannerComponent } from '@zxing/ngx-scanner';
import { Result } from '@zxing/library';
import { ProductService, ProductTypeService, WarehouseService } from '@_generated/services';
import { ProductCreateRequestModel, ProductCreateRequest, WarehouseResponse } from '@_generated/models';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Product } from '@_models';

@Component({
  selector: 'app-scanProducts',
  templateUrl: './scanProducts.component.html',
  styleUrls: ['./scanProducts.component.scss']
})
export class ScanProductsComponent implements OnInit {
  @ViewChild('scanner')
  scanner: ZXingScannerComponent;

  public hasCameras: boolean = false;
  public hasPermission: boolean;

  public availableDevices: Array<MediaDeviceInfo>;
  public selectedDevice: MediaDeviceInfo = null;

  public productsCreateForm: FormGroup;
  public submitted: boolean = false;

  public scannedProducts: Array<Product> = new Array<Product>();

  public warehouses: Array<WarehouseResponse>;
  public selectedWarehouse: WarehouseResponse;

  constructor(
    private productService: ProductService,
    private productTypeService: ProductTypeService,
    private warehouseService: WarehouseService,
    private formBuilder: FormBuilder
  ) { }


  ngOnInit(): void {


    this.productsCreateForm = this.formBuilder.group({
      warehouse: ['', Validators.required],
      shelve: ['', Validators.required]
    });

    this.warehouseService.GetAllWarehouses().subscribe(data => {
      console.log(data);

      this.warehouses = data.warehouses.sort(function (a, b) {
        var x = a.name.toLowerCase();
        var y = b.name.toLowerCase();
        if (x < y) { return -1; }
        if (x > y) { return 1; }
        return 0;
      });

      this.warehouses.forEach(w => w.shelves.sort(function (a, b) {
        var x = a.designation.toLowerCase();
        var y = b.designation.toLowerCase();
        if (x < y) { return -1; }
        if (x > y) { return 1; }
        return 0;
      }));
    })

    this.f.warehouse.valueChanges.subscribe(val => {
      console.log(val);
      this.selectedWarehouse = val;
    })

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

  }


  // convenience getter for easy access to form fields
  get f() { return this.productsCreateForm.controls; }


  handleQrCodeResult(resultString: string) {
    console.log('Result: ', resultString);
    let scannedProduct: ProductCreateRequestModel = JSON.parse(resultString);
    scannedProduct.compartmentId = "7CE87D94-C875-4CCD-845B-578C393BD351";

    this.productTypeService.GetProductTypeById(scannedProduct.productTypeId).subscribe(data => {
      let productToAdd: Product = new Product(data.name, scannedProduct);
      this.scannedProducts.push(productToAdd);
    }, error => {
      console.log(error);
    })


    // let createRequest: ProductCreateRequest = {products: new Array<ProductCreateRequestModel>()};
    // createRequest.products.push(scannedProduct);

    // this.productService.CreateProduct(createRequest).subscribe(data =>{
    //   console.log(data);
    // }, error => {
    //   console.log(error);
    // });
  }


  public onDeviceSelectChange(selectedValue: string) {
    console.log('Selection changed: ', selectedValue);
    this.scanner.updateVideoInputDevices().then((infos: MediaDeviceInfo[]) => {
      console.log(infos);
      this.selectedDevice = infos.find(x => x.deviceId == selectedValue);
    }
    );
  }


  public removeProductClicked(product: ProductCreateRequestModel): void {
    //Todo
  }
}
