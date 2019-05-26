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
  static readonly GetAllDepartmentsPath = '/api/v1/Role';
  static readonly CreateRolePath = '/api/v1/Role';
  static readonly GetRoleByIdPath = '/api/v1/Role/{id}';
  static readonly UpdateRolePath = '/api/v1/Role/{id}';
  static readonly DeleteRolePath = '/api/v1/Role/{id}';
  static readonly AddRoleToEmployeePath = '/api/v1/Role/add-to-employee';
  static readonly AddRoleToDepartmentPath = '/api/v1/Role/add-to-department';
  static readonly RemoveRoleFromEmployeePath = '/api/v1/Role/remove-from-employee';
  static readonly RemoveRoleFromDepartmentPath = '/api/v1/Role/remove-from-department';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * @return Success
   */
  GetAllDepartmentsResponse(): __Observable<__StrictHttpResponse<RoleGetAllResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/v1/Role`,
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
   * @return Success
   */
  GetAllDepartments(): __Observable<RoleGetAllResponse> {
    return this.GetAllDepartmentsResponse().pipe(
      __map(_r => _r.body as RoleGetAllResponse)
    );
  }

  /**
   * @param createData Data for creating a new role
   * @return Role successfuly created
   */
  CreateRoleResponse(createData?: RoleCreateRequest): __Observable<__StrictHttpResponse<RoleCreateResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = createData;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/v1/Role`,
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
   * @param createData Data for creating a new role
   * @return Role successfuly created
   */
  CreateRole(createData?: RoleCreateRequest): __Observable<RoleCreateResponse> {
    return this.CreateRoleResponse(createData).pipe(
      __map(_r => _r.body as RoleCreateResponse)
    );
  }

  /**
   * @param id Id of the role
   * @return Role found
   */
  GetRoleByIdResponse(id: string): __Observable<__StrictHttpResponse<RoleResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/v1/Role/${id}`,
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
   * @param id Id of the role
   * @return Role found
   */
  GetRoleById(id: string): __Observable<RoleResponse> {
    return this.GetRoleByIdResponse(id).pipe(
      __map(_r => _r.body as RoleResponse)
    );
  }

  /**
   * @param params The `RoleService.UpdateRoleParams` containing the following parameters:
   *
   * - `id`: Id of the role
   *
   * - `updateData`: Updated role data
   *
   * @return Role successfuly updated
   */
  UpdateRoleResponse(params: RoleService.UpdateRoleParams): __Observable<__StrictHttpResponse<RoleResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    __body = params.updateData;
    let req = new HttpRequest<any>(
      'PUT',
      this.rootUrl + `/api/v1/Role/${params.id}`,
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
   * @param params The `RoleService.UpdateRoleParams` containing the following parameters:
   *
   * - `id`: Id of the role
   *
   * - `updateData`: Updated role data
   *
   * @return Role successfuly updated
   */
  UpdateRole(params: RoleService.UpdateRoleParams): __Observable<RoleResponse> {
    return this.UpdateRoleResponse(params).pipe(
      __map(_r => _r.body as RoleResponse)
    );
  }

  /**
   * @param id Id of the role
   */
  DeleteRoleResponse(id: string): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/api/v1/Role/${id}`,
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
   * @param id Id of the role
   */
  DeleteRole(id: string): __Observable<null> {
    return this.DeleteRoleResponse(id).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param roleAddEmployeeData Data for adding a role to an employee
   */
  AddRoleToEmployeeResponse(roleAddEmployeeData?: RoleAddToEmployeeRequest): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = roleAddEmployeeData;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/v1/Role/add-to-employee`,
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
   * @param roleAddEmployeeData Data for adding a role to an employee
   */
  AddRoleToEmployee(roleAddEmployeeData?: RoleAddToEmployeeRequest): __Observable<null> {
    return this.AddRoleToEmployeeResponse(roleAddEmployeeData).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param roleAddDepartmentData Data for adding a role to a department
   */
  AddRoleToDepartmentResponse(roleAddDepartmentData?: RoleAddToDepartmentRequest): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = roleAddDepartmentData;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/v1/Role/add-to-department`,
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
   * @param roleAddDepartmentData Data for adding a role to a department
   */
  AddRoleToDepartment(roleAddDepartmentData?: RoleAddToDepartmentRequest): __Observable<null> {
    return this.AddRoleToDepartmentResponse(roleAddDepartmentData).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param removeRoleFromEmployeeData Data for removing a role from an employee
   */
  RemoveRoleFromEmployeeResponse(removeRoleFromEmployeeData?: RoleRemoveFromEmployeeRequest): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = removeRoleFromEmployeeData;
    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/api/v1/Role/remove-from-employee`,
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
   * @param removeRoleFromEmployeeData Data for removing a role from an employee
   */
  RemoveRoleFromEmployee(removeRoleFromEmployeeData?: RoleRemoveFromEmployeeRequest): __Observable<null> {
    return this.RemoveRoleFromEmployeeResponse(removeRoleFromEmployeeData).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param removeRoleFromDepartmentData Data for removing the role from the department
   */
  RemoveRoleFromDepartmentResponse(removeRoleFromDepartmentData?: RoleRemoveFromDepartmentRequest): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = removeRoleFromDepartmentData;
    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/api/v1/Role/remove-from-department`,
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
   * @param removeRoleFromDepartmentData Data for removing the role from the department
   */
  RemoveRoleFromDepartment(removeRoleFromDepartmentData?: RoleRemoveFromDepartmentRequest): __Observable<null> {
    return this.RemoveRoleFromDepartmentResponse(removeRoleFromDepartmentData).pipe(
      __map(_r => _r.body as null)
    );
  }
}

module RoleService {

  /**
   * Parameters for UpdateRole
   */
  export interface UpdateRoleParams {

    /**
     * Id of the role
     */
    id: string;

    /**
     * Updated role data
     */
    updateData?: RoleUpdateRequest;
  }
}

export { RoleService }
