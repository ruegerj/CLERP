/* tslint:disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpResponse, HttpHeaders } from '@angular/common/http';
import { BaseService as __BaseService } from '../base-service';
import { ApiConfiguration as __Configuration } from '../api-configuration';
import { StrictHttpResponse as __StrictHttpResponse } from '../strict-http-response';
import { Observable as __Observable } from 'rxjs';
import { map as __map, filter as __filter } from 'rxjs/operators';

import { EmployeeGetAllResponse } from '../models/employee-get-all-response';
import { EmployeeResponse } from '../models/employee-response';
import { EmployeeUpdateRequest } from '../models/employee-update-request';
import { EmployeeCreateResponse } from '../models/employee-create-response';
import { EmployeeCreateRequest } from '../models/employee-create-request';
import { TokenResponse } from '../models/token-response';
import { EmployeeLoginRequest } from '../models/employee-login-request';
@Injectable({
  providedIn: 'root',
})
class EmployeeService extends __BaseService {
  static readonly GetAllPath = '/api/v1/Employee';
  static readonly GetEmployeeByIdPath = '/api/v1/Employee/{id}';
  static readonly UpdateEmployeePath = '/api/v1/Employee/{id}';
  static readonly DeleteEmployeePath = '/api/v1/Employee/{id}';
  static readonly CreateEmployeePath = '/api/v1/Employee/create';
  static readonly LoginPath = '/api/v1/Employee/login';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * @return Success
   */
  GetAllResponse(): __Observable<__StrictHttpResponse<EmployeeGetAllResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/v1/Employee`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<EmployeeGetAllResponse>;
      })
    );
  }
  /**
   * @return Success
   */
  GetAll(): __Observable<EmployeeGetAllResponse> {
    return this.GetAllResponse().pipe(
      __map(_r => _r.body as EmployeeGetAllResponse)
    );
  }

  /**
   * @param id id of the requested employee
   * @return Employee found
   */
  GetEmployeeByIdResponse(id: string): __Observable<__StrictHttpResponse<EmployeeResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/v1/Employee/${id}`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<EmployeeResponse>;
      })
    );
  }
  /**
   * @param id id of the requested employee
   * @return Employee found
   */
  GetEmployeeById(id: string): __Observable<EmployeeResponse> {
    return this.GetEmployeeByIdResponse(id).pipe(
      __map(_r => _r.body as EmployeeResponse)
    );
  }

  /**
   * @param params The `EmployeeService.UpdateEmployeeParams` containing the following parameters:
   *
   * - `id`: Id of the employee
   *
   * - `updateData`: Data to update
   *
   * @return Employee successfuly updated
   */
  UpdateEmployeeResponse(params: EmployeeService.UpdateEmployeeParams): __Observable<__StrictHttpResponse<EmployeeResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    __body = params.updateData;
    let req = new HttpRequest<any>(
      'PUT',
      this.rootUrl + `/api/v1/Employee/${params.id}`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<EmployeeResponse>;
      })
    );
  }
  /**
   * @param params The `EmployeeService.UpdateEmployeeParams` containing the following parameters:
   *
   * - `id`: Id of the employee
   *
   * - `updateData`: Data to update
   *
   * @return Employee successfuly updated
   */
  UpdateEmployee(params: EmployeeService.UpdateEmployeeParams): __Observable<EmployeeResponse> {
    return this.UpdateEmployeeResponse(params).pipe(
      __map(_r => _r.body as EmployeeResponse)
    );
  }

  /**
   * @param id Guid/Id from the employee
   */
  DeleteEmployeeResponse(id: string): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/api/v1/Employee/${id}`,
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
   * @param id Guid/Id from the employee
   */
  DeleteEmployee(id: string): __Observable<null> {
    return this.DeleteEmployeeResponse(id).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param createData Required data for creating an employee
   * @return Employee successfuly created
   */
  CreateEmployeeResponse(createData?: EmployeeCreateRequest): __Observable<__StrictHttpResponse<EmployeeCreateResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = createData;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/v1/Employee/create`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<EmployeeCreateResponse>;
      })
    );
  }
  /**
   * @param createData Required data for creating an employee
   * @return Employee successfuly created
   */
  CreateEmployee(createData?: EmployeeCreateRequest): __Observable<EmployeeCreateResponse> {
    return this.CreateEmployeeResponse(createData).pipe(
      __map(_r => _r.body as EmployeeCreateResponse)
    );
  }

  /**
   * @param loginData Username and password from the employee
   * @return Login successsful
   */
  LoginResponse(loginData?: EmployeeLoginRequest): __Observable<__StrictHttpResponse<TokenResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = loginData;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/v1/Employee/login`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<TokenResponse>;
      })
    );
  }
  /**
   * @param loginData Username and password from the employee
   * @return Login successsful
   */
  Login(loginData?: EmployeeLoginRequest): __Observable<TokenResponse> {
    return this.LoginResponse(loginData).pipe(
      __map(_r => _r.body as TokenResponse)
    );
  }
}

module EmployeeService {

  /**
   * Parameters for UpdateEmployee
   */
  export interface UpdateEmployeeParams {

    /**
     * Id of the employee
     */
    id: string;

    /**
     * Data to update
     */
    updateData?: EmployeeUpdateRequest;
  }
}

export { EmployeeService }
