import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AppRoutingModule } from './app-routing.module';
import { ZXingScannerModule } from '@zxing/ngx-scanner';

import { AppComponent } from '@app.component';
import { NavComponent } from '@core/nav/nav.component';
import { FooterComponent } from '@core/footer/footer.component';
import { ProductTypeChildListComponent } from '@productTypes/productTypeDetailOverview/productTypeChildList/productTypeChildList.component';
import { ProductTypeDetailOverviewComponent } from '@productTypes';
import { ProductTypesComponent } from '@productTypes/productTypes.component';
import { EmployeeEditComponent } from '@employees/employeeEdit/employeeEdit.component';
import { HomeComponent } from '@home/home.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { JwtInterceptor, ErrorInterceptor } from '@_helpers';
import { EmployeesComponent } from '@employees/employees.component';
import { EmployeeCreateComponent } from '@employees/employeeCreate/employeeCreate.component';
import { ProductTypeCreateComponent } from '@productTypes/productTypeCreate/productTypeCreate.component';
import { AddToProductTypeComponent } from '@productTypes/addToProductType/addToProductType.component';
import { ProductTypeParentListComponent } from '@productTypes/productTypeDetailOverview/productTypeParentList/productTypeParentList.component';
import { ProductsComponent } from '@products/products.component';
import { ScanProductsComponent } from '@products/scanProducts/scanProducts.component';

@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      FooterComponent,
      ProductTypeChildListComponent,
      ProductTypeParentListComponent,
      ProductTypeDetailOverviewComponent,
      ProductTypeCreateComponent,
      ProductTypesComponent,
      EmployeeEditComponent,
      EmployeeCreateComponent,
      HomeComponent,
      EmployeesComponent,
      AddToProductTypeComponent,
      ProductsComponent,
      ScanProductsComponent
   ],
   imports: [
      BrowserModule,
      FormsModule,
      NgbModule,
      AppRoutingModule,
      HttpClientModule,
      ReactiveFormsModule,
      ZXingScannerModule
   ],
   providers: [
      { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
      { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true }
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
