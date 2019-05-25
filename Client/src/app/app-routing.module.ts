import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from '@home';
import { EmployeesComponent } from '@employees';
import { ProductsComponent } from '@products';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'employees', component: EmployeesComponent },
  { path: 'products', component: ProductsComponent },

  //all else, redirect to home
  //TODO redirect to error page
  { path: '**', redirectTo: '' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
