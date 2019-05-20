/* tslint:disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpResponse, HttpHeaders } from '@angular/common/http';
import { BaseService as __BaseService } from '../base-service';
import { ApiConfiguration as __Configuration } from '../api-configuration';
import { StrictHttpResponse as __StrictHttpResponse } from '../strict-http-response';
import { Observable as __Observable } from 'rxjs';
import { map as __map, filter as __filter } from 'rxjs/operators';

import { RoleGetAllResponse } from '../models/role-get-all-response';
import { RoleCreateResponse } from '../models/role-create-response';
import { RoleCreateRequest } from '../models/role-create-request';
import { RoleResponse } from '../models/role-response';
import { RoleUpdateRequest } from '../models/role-update-request';
import { RoleAddToEmployeeRequest } from '../models/role-add-to-employee-request';
import { RoleAddToDepartmentRequest } from '../models/role-add-to-department-request';
import { RoleRemoveFromEmployeeRequest } from '../models/role-remove-from-employee-request';
import { RoleRemoveFromDepartmentRequest } from '../models/role-remove-from-department-request';
@Injectable({
  providedIn: 'root',
})
class RoleService extends __BaseService {
  static readonly RoleGetAllPath = '/api/v{version}/Role';
  static readonly RoleCreateRolePath = '/api/v{version}/Role';
  static readonly RoleGetRoleByIdPath = '/api/v{version}/Role/{id}';
  static readonly RoleUpdateRolePath = '/api/v{version}/Role/{id}';
  static readonly RoleDeleteRolePath = '/api/v{version}/Role/{id}';
  static readonly RoleAddRoleToEmployeePath = '/api/v{version}/Role/add-to-employee';
  static readonly RoleAddRoleToDepartmentPath = '/api/v{version}/Role/add-to-department';
  static readonly RoleRemoveRoleFromEmployeePath = '/api/v{version}/Role/remove-from-employee';
  static readonly RoleRemoveRoleFromDepartmentPath = '/api/v{version}/Role/remove-from-department';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * @param version undefined
   */
  RoleGetAllResponse(version: string): __Observable<__StrictHttpResponse<RoleGetAllResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/v${version}/Role`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<RoleGetAllResponse>;
      })
    );
  }
  /**
   * @param version undefined
   */
  RoleGetAll(version: string): __Observable<RoleGetAllResponse> {
    return this.RoleGetAllResponse(version).pipe(
      __map(_r => _r.body as RoleGetAllResponse)
    );
  }

  /**
   * @param params The `RoleService.RoleCreateRoleParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `createData`: Data for creating a new role
   *
   * @return Role successfuly created
   */
  RoleCreateRoleResponse(params: RoleService.RoleCreateRoleParams): __Observable<__StrictHttpResponse<RoleCreateResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    __body = params.createData;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/v${params.version}/Role`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<RoleCreateResponse>;
      })
    );
  }
  /**
   * @param params The `RoleService.RoleCreateRoleParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `createData`: Data for creating a new role
   *
   * @return Role successfuly created
   */
  RoleCreateRole(params: RoleService.RoleCreateRoleParams): __Observable<RoleCreateResponse> {
    return this.RoleCreateRoleResponse(params).pipe(
      __map(_r => _r.body as RoleCreateResponse)
    );
  }

  /**
   * @param params The `RoleService.RoleGetRoleByIdParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `id`: Id of the role
   *
   * @return Role found
   */
  RoleGetRoleByIdResponse(params: RoleService.RoleGetRoleByIdParams): __Observable<__StrictHttpResponse<RoleResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/v${params.version}/Role/${params.id}`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<RoleResponse>;
      })
    );
  }
  /**
   * @param params The `RoleService.RoleGetRoleByIdParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `id`: Id of the role
   *
   * @return Role found
   */
  RoleGetRoleById(params: RoleService.RoleGetRoleByIdParams): __Observable<RoleResponse> {
    return this.RoleGetRoleByIdResponse(params).pipe(
      __map(_r => _r.body as RoleResponse)
    );
  }

  /**
   * @param params The `RoleService.RoleUpdateRoleParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `updateData`: Updated role data
   *
   * - `id`: Id of the role
   *
   * @return Role successfuly updated
   */
  RoleUpdateRoleResponse(params: RoleService.RoleUpdateRoleParams): __Observable<__StrictHttpResponse<RoleResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    __body = params.updateData;

    let req = new HttpRequest<any>(
      'PUT',
      this.rootUrl + `/api/v${params.version}/Role/${params.id}`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<RoleResponse>;
      })
    );
  }
  /**
   * @param params The `RoleService.RoleUpdateRoleParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `updateData`: Updated role data
   *
   * - `id`: Id of the role
   *
   * @return Role successfuly updated
   */
  RoleUpdateRole(params: RoleService.RoleUpdateRoleParams): __Observable<RoleResponse> {
    return this.RoleUpdateRoleResponse(params).pipe(
      __map(_r => _r.body as RoleResponse)
    );
  }

  /**
   * @param params The `RoleService.RoleDeleteRoleParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `id`: Id of the role
   */
  RoleDeleteRoleResponse(params: RoleService.RoleDeleteRoleParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/api/v${params.version}/Role/${params.id}`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<null>;
      })
    );
  }
  /**
   * @param params The `RoleService.RoleDeleteRoleParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `id`: Id of the role
   */
  RoleDeleteRole(params: RoleService.RoleDeleteRoleParams): __Observable<null> {
    return this.RoleDeleteRoleResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param params The `RoleService.RoleAddRoleToEmployeeParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `roleAddEmployeeData`: Data for adding a role to an employee
   */
  RoleAddRoleToEmployeeResponse(params: RoleService.RoleAddRoleToEmployeeParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    __body = params.roleAddEmployeeData;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/v${params.version}/Role/add-to-employee`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<null>;
      })
    );
  }
  /**
   * @param params The `RoleService.RoleAddRoleToEmployeeParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `roleAddEmployeeData`: Data for adding a role to an employee
   */
  RoleAddRoleToEmployee(params: RoleService.RoleAddRoleToEmployeeParams): __Observable<null> {
    return this.RoleAddRoleToEmployeeResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param params The `RoleService.RoleAddRoleToDepartmentParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `roleAddDepartmentData`: Data for adding a role to a department
   */
  RoleAddRoleToDepartmentResponse(params: RoleService.RoleAddRoleToDepartmentParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    __body = params.roleAddDepartmentData;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/v${params.version}/Role/add-to-department`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<null>;
      })
    );
  }
  /**
   * @param params The `RoleService.RoleAddRoleToDepartmentParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `roleAddDepartmentData`: Data for adding a role to a department
   */
  RoleAddRoleToDepartment(params: RoleService.RoleAddRoleToDepartmentParams): __Observable<null> {
    return this.RoleAddRoleToDepartmentResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param params The `RoleService.RoleRemoveRoleFromEmployeeParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `removeRoleFromEmployeeData`: Data for removing a role from an employee
   */
  RoleRemoveRoleFromEmployeeResponse(params: RoleService.RoleRemoveRoleFromEmployeeParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    __body = params.removeRoleFromEmployeeData;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/v${params.version}/Role/remove-from-employee`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<null>;
      })
    );
  }
  /**
   * @param params The `RoleService.RoleRemoveRoleFromEmployeeParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `removeRoleFromEmployeeData`: Data for removing a role from an employee
   */
  RoleRemoveRoleFromEmployee(params: RoleService.RoleRemoveRoleFromEmployeeParams): __Observable<null> {
    return this.RoleRemoveRoleFromEmployeeResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param params The `RoleService.RoleRemoveRoleFromDepartmentParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `roleRemoveFromDepartmentData`: Data for removing the role from the department
   */
  RoleRemoveRoleFromDepartmentResponse(params: RoleService.RoleRemoveRoleFromDepartmentParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    __body = params.roleRemoveFromDepartmentData;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/v${params.version}/Role/remove-from-department`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<null>;
      })
    );
  }
  /**
   * @param params The `RoleService.RoleRemoveRoleFromDepartmentParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `roleRemoveFromDepartmentData`: Data for removing the role from the department
   */
  RoleRemoveRoleFromDepartment(params: RoleService.RoleRemoveRoleFromDepartmentParams): __Observable<null> {
    return this.RoleRemoveRoleFromDepartmentResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }
}

module RoleService {

  /**
   * Parameters for RoleCreateRole
   */
  export interface RoleCreateRoleParams {
    version: string;

    /**
     * Data for creating a new role
     */
    createData: RoleCreateRequest;
  }

  /**
   * Parameters for RoleGetRoleById
   */
  export interface RoleGetRoleByIdParams {
    version: string;

    /**
     * Id of the role
     */
    id: string;
  }

  /**
   * Parameters for RoleUpdateRole
   */
  export interface RoleUpdateRoleParams {
    version: string;

    /**
     * Updated role data
     */
    updateData: RoleUpdateRequest;

    /**
     * Id of the role
     */
    id: string;
  }

  /**
   * Parameters for RoleDeleteRole
   */
  export interface RoleDeleteRoleParams {
    version: string;

    /**
     * Id of the role
     */
    id: string;
  }

  /**
   * Parameters for RoleAddRoleToEmployee
   */
  export interface RoleAddRoleToEmployeeParams {
    version: string;

    /**
     * Data for adding a role to an employee
     */
    roleAddEmployeeData: RoleAddToEmployeeRequest;
  }

  /**
   * Parameters for RoleAddRoleToDepartment
   */
  export interface RoleAddRoleToDepartmentParams {
    version: string;

    /**
     * Data for adding a role to a department
     */
    roleAddDepartmentData: RoleAddToDepartmentRequest;
  }

  /**
   * Parameters for RoleRemoveRoleFromEmployee
   */
  export interface RoleRemoveRoleFromEmployeeParams {
    version: string;

    /**
     * Data for removing a role from an employee
     */
    removeRoleFromEmployeeData: RoleRemoveFromEmployeeRequest;
  }

  /**
   * Parameters for RoleRemoveRoleFromDepartment
   */
  export interface RoleRemoveRoleFromDepartmentParams {
    version: string;

    /**
     * Data for removing the role from the department
     */
    roleRemoveFromDepartmentData: RoleRemoveFromDepartmentRequest;
  }
}

export { RoleService }
