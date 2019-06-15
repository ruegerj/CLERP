import { Component, OnInit, ViewChild } from '@angular/core';
import { ZXingScannerComponent } from '@zxing/ngx-scanner';
import { Result } from '@zxing/library';
import { QrScannerComponent } from 'angular2-qrscanner';
import { ProductService } from '@_generated/services';
import { ProductCreateRequestModel, ProductCreateRequest } from '@_generated/models';

@Component({
  selector: 'app-scanProducts',
  templateUrl: './scanProducts.component.html',
  styleUrls: ['./scanProducts.component.scss']
})
export class ScanProductsComponent implements OnInit {
  @ViewChild('scanner')
  scanner: ZXingScannerComponent;

  hasCameras = false;
  hasPermission: boolean;

  availableDevices: MediaDeviceInfo[];
  selectedDevice: MediaDeviceInfo;

  constructor(
    private productService: ProductService
  ) { }


  ngOnInit(): void {

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

  handleQrCodeResult(resultString: string) {
    console.log('Result: ', resultString);
    let scannedProduct: ProductCreateRequestModel = JSON.parse(resultString);
    scannedProduct.compartmentId = "7CE87D94-C875-4CCD-845B-578C393BD351";
    console.log(scannedProduct);

    let createRequest: ProductCreateRequest = {products: new Array<ProductCreateRequestModel>()};
    createRequest.products.push(scannedProduct);

    this.productService.CreateProduct(createRequest).subscribe(data =>{
      console.log(data);
    }, error => {
      console.log(error);
    });
  }


  onDeviceSelectChange(selectedValue: string) {
    console.log('Selection changed: ', selectedValue);
    this.scanner.updateVideoInputDevices().then((infos: MediaDeviceInfo[]) => {
      console.log(infos);
      this.selectedDevice = infos.find(x => x.deviceId == selectedValue);
    }
    );
  }
}
