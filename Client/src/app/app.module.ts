import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { NgForm, FormsModule } from '@angular/forms';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './core/nav/nav.component';
import { FooterComponent } from './core/footer/footer.component';
import { ProductDetailComponent } from './products/productDetail/productDetail.component';
import { ProductListComponent } from './products/productList/productList.component';
import { ProductsComponent } from './products/products.component';
import { EmployeesComponent } from './employees/employees.component';
import { CrudbarComponent } from './crudbar/crudbar.component';

@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      FooterComponent,
      ProductDetailComponent,
      ProductListComponent,
      ProductsComponent,
      EmployeesComponent,
      CrudbarComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      FormsModule,
      NgbModule    
   ],
   providers: [],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
