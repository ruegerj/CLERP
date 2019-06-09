import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from '@home';
import { EmployeesComponent, EmployeeEditComponent } from '@employees';
import { ProductsComponent, ProductDetailOverviewComponent } from '@products';
import { AuthGuard } from '@_guards';
import { Roles } from '@_models';
import { EmployeeCreateComponent } from '@employees/employeeCreate/employeeCreate.component';
import { ProductCreateComponent } from '@products/productCreate/productCreate.component';

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
    path: 'products',
    component: ProductsComponent,
    canActivate: [AuthGuard],
    data: {roles: [Roles.SysAdmin, Roles.Management, Roles.Logistic, Roles.Production]}
  },
  {
    path: 'productCreate',
    component: ProductCreateComponent,
    canActivate: [AuthGuard],
    data: {roles: [Roles.SysAdmin, Roles.Management, Roles.Logistic, Roles.Production]}
  },
  {
    path: 'productDetailOverview/:id',
    component: ProductDetailOverviewComponent,
    canActivate: [AuthGuard],
    runGuardsAndResolvers: 'always',
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
  imports: [RouterModule.forRoot(routes, {onSameUrlNavigation: 'reload'})],
  exports: [RouterModule]
})
export class AppRoutingModule { }
