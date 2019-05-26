/* tslint:disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpResponse, HttpHeaders } from '@angular/common/http';
import { BaseService as __BaseService } from '../base-service';
import { ApiConfiguration as __Configuration } from '../api-configuration';
import { StrictHttpResponse as __StrictHttpResponse } from '../strict-http-response';
import { Observable as __Observable } from 'rxjs';
import { map as __map, filter as __filter } from 'rxjs/operators';

import { DepartmentGetAllResponse } from '../models/department-get-all-response';
import { DepartmentCreateResponse } from '../models/department-create-response';
import { DepartmentCreateRequest } from '../models/department-create-request';
import { DepartmentResponse } from '../models/department-response';
import { DepartmentUpdateRequest } from '../models/department-update-request';
import { DepartmentAddEmployeeRequest } from '../models/department-add-employee-request';
import { DepartmentRemoveEmployeeRequest } from '../models/department-remove-employee-request';
@Injectable({
  providedIn: 'root',
})
class DepartmentService extends __BaseService {
  static readonly GetAllDepartmentsPath = '/api/v1/Department';
  static readonly CreateDepartmentPath = '/api/v1/Department';
  static readonly GetDepartmentByIdPath = '/api/v1/Department/{id}';
  static readonly UpdateDepartmentPath = '/api/v1/Department/{id}';
  static readonly DeleteDepartmentPath = '/api/v1/Department/{id}';
  static readonly AddEmployeeToDepartmentPath = '/api/v1/Department/add-employee';
  static readonly RemoveEmployeeFromDepartmentPath = '/api/v1/Department/remove-employee';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * @return Success
   */
  GetAllDepartmentsResponse(): __Observable<__StrictHttpResponse<DepartmentGetAllResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/v1/Department`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<DepartmentGetAllResponse>;
      })
    );
  }
  /**
   * @return Success
   */
  GetAllDepartments(): __Observable<DepartmentGetAllResponse> {
    return this.GetAllDepartmentsResponse().pipe(
      __map(_r => _r.body as DepartmentGetAllResponse)
    );
  }

  /**
   * @param createData Data for creating a new departmen
   * @return Department successfuly created
   */
  CreateDepartmentResponse(createData?: DepartmentCreateRequest): __Observable<__StrictHttpResponse<DepartmentCreateResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = createData;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/v1/Department`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<DepartmentCreateResponse>;
      })
    );
  }
  /**
   * @param createData Data for creating a new departmen
   * @return Department successfuly created
   */
  CreateDepartment(createData?: DepartmentCreateRequest): __Observable<DepartmentCreateResponse> {
    return this.CreateDepartmentResponse(createData).pipe(
      __map(_r => _r.body as DepartmentCreateResponse)
    );
  }

  /**
   * @param id Id of the department
   * @return Department found
   */
  GetDepartmentByIdResponse(id: string): __Observable<__StrictHttpResponse<DepartmentResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/v1/Department/${id}`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<DepartmentResponse>;
      })
    );
  }
  /**
   * @param id Id of the department
   * @return Department found
   */
  GetDepartmentById(id: string): __Observable<DepartmentResponse> {
    return this.GetDepartmentByIdResponse(id).pipe(
      __map(_r => _r.body as DepartmentResponse)
    );
  }

  /**
   * @param params The `DepartmentService.UpdateDepartmentParams` containing the following parameters:
   *
   * - `id`: Id of the department to update
   *
   * - `updateData`: Updated department data
   *
   * @return Department successfuly updated
   */
  UpdateDepartmentResponse(params: DepartmentService.UpdateDepartmentParams): __Observable<__StrictHttpResponse<DepartmentResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    __body = params.updateData;
    let req = new HttpRequest<any>(
      'PUT',
      this.rootUrl + `/api/v1/Department/${params.id}`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<DepartmentResponse>;
      })
    );
  }
  /**
   * @param params The `DepartmentService.UpdateDepartmentParams` containing the following parameters:
   *
   * - `id`: Id of the department to update
   *
   * - `updateData`: Updated department data
   *
   * @return Department successfuly updated
   */
  UpdateDepartment(params: DepartmentService.UpdateDepartmentParams): __Observable<DepartmentResponse> {
    return this.UpdateDepartmentResponse(params).pipe(
      __map(_r => _r.body as DepartmentResponse)
    );
  }

  /**
   * @param id Id of the department
   */
  DeleteDepartmentResponse(id: string): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/api/v1/Department/${id}`,
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
   * @param id Id of the department
   */
  DeleteDepartment(id: string): __Observable<null> {
    return this.DeleteDepartmentResponse(id).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param departmentAddEmployeeData Data for adding an employee to a department
   */
  AddEmployeeToDepartmentResponse(departmentAddEmployeeData?: DepartmentAddEmployeeRequest): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = departmentAddEmployeeData;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/v1/Department/add-employee`,
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
   * @param departmentAddEmployeeData Data for adding an employee to a department
   */
  AddEmployeeToDepartment(departmentAddEmployeeData?: DepartmentAddEmployeeRequest): __Observable<null> {
    return this.AddEmployeeToDepartmentResponse(departmentAddEmployeeData).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param departmentRemoveEmployeeData Data for removing an employee from a department
   */
  RemoveEmployeeFromDepartmentResponse(departmentRemoveEmployeeData?: DepartmentRemoveEmployeeRequest): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = departmentRemoveEmployeeData;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/v1/Department/remove-employee`,
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
   * @param departmentRemoveEmployeeData Data for removing an employee from a department
   */
  RemoveEmployeeFromDepartment(departmentRemoveEmployeeData?: DepartmentRemoveEmployeeRequest): __Observable<null> {
    return this.RemoveEmployeeFromDepartmentResponse(departmentRemoveEmployeeData).pipe(
      __map(_r => _r.body as null)
    );
  }
}

module DepartmentService {

  /**
   * Parameters for UpdateDepartment
   */
  export interface UpdateDepartmentParams {

    /**
     * Id of the department to update
     */
    id: string;

    /**
     * Updated department data
     */
    updateData?: DepartmentUpdateRequest;
  }
}

export { DepartmentService }
