/* tslint:disable */
import { NgModule, ModuleWithProviders } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { ApiConfiguration, ApiConfigurationInterface } from './api-configuration';

import { DepartmentService } from './services/department.service';
import { EmployeeService } from './services/employee.service';
import { ProductService } from './services/product.service';
import { ProductTypeService } from './services/product-type.service';
import { RoleService } from './services/role.service';
import { WarehouseService } from './services/warehouse.service';

/**
 * Provider for all Api services, plus ApiConfiguration
 */
@NgModule({
  imports: [
    HttpClientModule
  ],
  exports: [
    HttpClientModule
  ],
  declarations: [],
  providers: [
    ApiConfiguration,
    DepartmentService,
    EmployeeService,
    ProductService,
    ProductTypeService,
    RoleService,
    WarehouseService
  ],
})
export class ApiModule {
  static forRoot(customParams: ApiConfigurationInterface): ModuleWithProviders {
    return {
      ngModule: ApiModule,
      providers: [
        {
          provide: ApiConfiguration,
          useValue: {rootUrl: customParams.rootUrl}
        }
      ]
    }
  }
}
