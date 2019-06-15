import { Component, OnInit, ViewChild } from '@angular/core';
import { ZXingScannerComponent } from '@zxing/ngx-scanner';
import { Result } from '@zxing/library';
import { ProductService } from '@_generated/services';
import { ProductCreateRequestModel, ProductCreateRequest } from '@_generated/models';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

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

  public availableDevices: MediaDeviceInfo[];
  public selectedDevice: MediaDeviceInfo;

  public productsCreateForm: FormGroup;
  public submitted: boolean = false;

  public warehouses: any;
  public shelves: any;
  public scannedProducts: Array<ProductCreateRequestModel> = new Array<ProductCreateRequestModel>();


  constructor(
    private productService: ProductService,
    private formBuilder: FormBuilder
  ) { }


  ngOnInit(): void {
    this.productsCreateForm = this.formBuilder.group({
      warehouse: ['', Validators.required],
      shelve: ['', Validators.required]
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
      console.error('An error has occurred when trying to enumerate your video-stream-enabled devices.');
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
    console.log(scannedProduct);
    this.scannedProducts.push(scannedProduct);

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


  public removeProductClicked(product: ProductCreateRequestModel): void{
    //Todo
  }
}
