import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { NavComponent } from './core/nav/nav.component';
import { FooterComponent } from './core/footer/footer.component';
import { ProductDetailComponent } from './products/productDetailOverview/productDetail/productDetail.component';
import { ProductListComponent } from './products/productDetailOverview/productList/productList.component';
import { ProductDetailOverviewComponent } from '@products';
import { ProductsComponent } from './products/products.component';
import { EmployeeEditComponent } from './employees/employeeEdit/employeeEdit.component';
import { HomeComponent } from './home/home.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { JwtInterceptor, ErrorInterceptor } from '@_helpers';
import { EmployeesComponent } from './employees/employees.component';
import { EmployeeCreateComponent } from '@employees/employeeCreate/employeeCreate.component';

@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      FooterComponent,
      ProductDetailComponent,
      ProductListComponent,
      ProductDetailOverviewComponent,
      ProductsComponent,
      EmployeeEditComponent,
      EmployeeCreateComponent,
      HomeComponent,
      EmployeesComponent
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
