import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from '@app.component';
import { NavComponent } from '@core/nav/nav.component';
import { FooterComponent } from '@core/footer/footer.component';
import { ProductTypeDetailComponent } from '@productTypes/productTypeDetailOverview/productTypeDetail/productTypeDetail.component';
import { ProductTypeListComponent } from '@productTypes/productTypeDetailOverview/productTypeList/productTypeList.component';
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

@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      FooterComponent,
      ProductTypeDetailComponent,
      ProductTypeListComponent,
      ProductTypeDetailOverviewComponent,
      ProductTypeCreateComponent,
      ProductTypesComponent,
      EmployeeEditComponent,
      EmployeeCreateComponent,
      HomeComponent,
      EmployeesComponent,
      AddToProductTypeComponent
   ],
   imports: [
      BrowserModule,
      FormsModule,
      NgbModule,
      AppRoutingModule,
      HttpClientModule,
      ReactiveFormsModule
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
