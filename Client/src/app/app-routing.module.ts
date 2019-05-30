import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from '@home';
import { EmployeesComponent } from '@employees';
import { ProductsComponent } from '@products';
import { AuthGuard } from '@_guards';
import { Roles } from '@_models';

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
    path: 'products', 
    component: ProductsComponent,
    canActivate: [AuthGuard],
    data: {roles: [Roles.Management, Roles.Logistic, Roles.Production]}
  },

  //all else, redirect to home
  //TODO redirect to error page
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
