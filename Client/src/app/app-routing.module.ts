import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from '@home';
import { EmployeesComponent, EmployeeEditComponent } from '@employees';
import { ProductTypesComponent, ProductTypeDetailOverviewComponent } from '@productTypes';
import { AuthGuard } from '@_guards';
import { Roles } from '@_models';
import { EmployeeCreateComponent } from '@employees/employeeCreate/employeeCreate.component';
import { ProductTypeCreateComponent } from '@productTypes/productTypeCreate/productTypeCreate.component';
import { AddToProductTypeComponent } from '@productTypes/addToProductType/addToProductType.component';

const routes: Routes = [
  {
    path: '',
    component: HomeComponent
  },
  {
    path: 'employees',
    component: EmployeesComponent,
    canActivate: [AuthGuard],
    data: {roles: [Roles.SysAdmin, Roles.Management, Roles.HR]}
  },
  {
    path: 'employeeEdit/:id',
    component: EmployeeEditComponent,
    canActivate: [AuthGuard],
    data: {roles: [Roles.SysAdmin, Roles.Management, Roles.HR]}
  },
  {
    path: 'employeeCreate',
    component: EmployeeCreateComponent,
    canActivate: [AuthGuard],
    data: {roles: [Roles.SysAdmin, Roles.Management, Roles.HR]}
  },
  {
    path: 'productTypes',
    component: ProductTypesComponent,
    canActivate: [AuthGuard],
    data: {roles: [Roles.SysAdmin, Roles.Management, Roles.Logistic, Roles.Production]}
  },
  {
    path: 'productTypeCreate',
    component: ProductTypeCreateComponent,
    canActivate: [AuthGuard],
    data: {roles: [Roles.SysAdmin, Roles.Management, Roles.Logistic, Roles.Production]}
  },
  {
    path: 'productTypeDetailOverview/:id',
    component: ProductTypeDetailOverviewComponent,
    canActivate: [AuthGuard],
    data: {roles: [Roles.SysAdmin, Roles.Management, Roles.Logistic, Roles.Production]}
  },
  {
    path: 'addToProductType/:origin',
    component: AddToProductTypeComponent,
    canActivate: [AuthGuard],
    data: {roles: [Roles.SysAdmin, Roles.Management, Roles.Logistic, Roles.Production]}
  },  
  // all else, redirect to home
  // TODO redirect to error page
  {
    path: '**',
    redirectTo: ''
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
