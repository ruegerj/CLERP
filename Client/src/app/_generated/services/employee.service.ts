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
import { EmployeeCreateRequest } from '../models/employee-create-request';
import { TokenResponse } from '../models/token-response';
import { EmployeeLoginRequest } from '../models/employee-login-request';
@Injectable({
  providedIn: 'root',
})
class EmployeeService extends __BaseService {
  static readonly EmployeeGetAllPath = '/api/v{version}/Employee';
  static readonly EmployeeGetEmployeeByIdPath = '/api/v{version}/Employee/{id}';
  static readonly EmployeeUpdateEmployeePath = '/api/v{version}/Employee/{id}';
  static readonly EmployeeDeleteEmployeePath = '/api/v{version}/Employee/{id}';
  static readonly EmployeeCreateEmployeePath = '/api/v{version}/Employee/create';
  static readonly EmployeeLoginPath = '/api/v{version}/Employee/login';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * @param version undefined
   */
  EmployeeGetAllResponse(version: string): __Observable<__StrictHttpResponse<EmployeeGetAllResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/v${version}/Employee`,
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
   * @param version undefined
   */
  EmployeeGetAll(version: string): __Observable<EmployeeGetAllResponse> {
    return this.EmployeeGetAllResponse(version).pipe(
      __map(_r => _r.body as EmployeeGetAllResponse)
    );
  }

  /**
   * @param params The `EmployeeService.EmployeeGetEmployeeByIdParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `id`: id of the requested employee
   *
   * @return Employee found
   */
  EmployeeGetEmployeeByIdResponse(params: EmployeeService.EmployeeGetEmployeeByIdParams): __Observable<__StrictHttpResponse<EmployeeResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/v${params.version}/Employee/${params.id}`,
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
   * @param params The `EmployeeService.EmployeeGetEmployeeByIdParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `id`: id of the requested employee
   *
   * @return Employee found
   */
  EmployeeGetEmployeeById(params: EmployeeService.EmployeeGetEmployeeByIdParams): __Observable<EmployeeResponse> {
    return this.EmployeeGetEmployeeByIdResponse(params).pipe(
      __map(_r => _r.body as EmployeeResponse)
    );
  }

  /**
   * @param params The `EmployeeService.EmployeeUpdateEmployeeParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `updateData`: Data to update
   *
   * - `id`: Id of the employee
   *
   * @return Employee successfuly updated
   */
  EmployeeUpdateEmployeeResponse(params: EmployeeService.EmployeeUpdateEmployeeParams): __Observable<__StrictHttpResponse<EmployeeResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    __body = params.updateData;

    let req = new HttpRequest<any>(
      'PUT',
      this.rootUrl + `/api/v${params.version}/Employee/${params.id}`,
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
   * @param params The `EmployeeService.EmployeeUpdateEmployeeParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `updateData`: Data to update
   *
   * - `id`: Id of the employee
   *
   * @return Employee successfuly updated
   */
  EmployeeUpdateEmployee(params: EmployeeService.EmployeeUpdateEmployeeParams): __Observable<EmployeeResponse> {
    return this.EmployeeUpdateEmployeeResponse(params).pipe(
      __map(_r => _r.body as EmployeeResponse)
    );
  }

  /**
   * @param params The `EmployeeService.EmployeeDeleteEmployeeParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `id`: Guid/Id from the employee
   */
  EmployeeDeleteEmployeeResponse(params: EmployeeService.EmployeeDeleteEmployeeParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/api/v${params.version}/Employee/${params.id}`,
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
   * @param params The `EmployeeService.EmployeeDeleteEmployeeParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `id`: Guid/Id from the employee
   */
  EmployeeDeleteEmployee(params: EmployeeService.EmployeeDeleteEmployeeParams): __Observable<null> {
    return this.EmployeeDeleteEmployeeResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param params The `EmployeeService.EmployeeCreateEmployeeParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `createData`: Required data for creating an employee
   */
  EmployeeCreateEmployeeResponse(params: EmployeeService.EmployeeCreateEmployeeParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    __body = params.createData;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/v${params.version}/Employee/create`,
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
   * @param params The `EmployeeService.EmployeeCreateEmployeeParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `createData`: Required data for creating an employee
   */
  EmployeeCreateEmployee(params: EmployeeService.EmployeeCreateEmployeeParams): __Observable<null> {
    return this.EmployeeCreateEmployeeResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param params The `EmployeeService.EmployeeLoginParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `loginData`: Username and password from the employee
   *
   * @return Login successsful
   */
  EmployeeLoginResponse(params: EmployeeService.EmployeeLoginParams): __Observable<__StrictHttpResponse<TokenResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    __body = params.loginData;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/v${params.version}/Employee/login`,
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
   * @param params The `EmployeeService.EmployeeLoginParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `loginData`: Username and password from the employee
   *
   * @return Login successsful
   */
  EmployeeLogin(params: EmployeeService.EmployeeLoginParams): __Observable<TokenResponse> {
    return this.EmployeeLoginResponse(params).pipe(
      __map(_r => _r.body as TokenResponse)
    );
  }
}

module EmployeeService {

  /**
   * Parameters for EmployeeGetEmployeeById
   */
  export interface EmployeeGetEmployeeByIdParams {
    version: string;

    /**
     * id of the requested employee
     */
    id: string;
  }

  /**
   * Parameters for EmployeeUpdateEmployee
   */
  export interface EmployeeUpdateEmployeeParams {
    version: string;

    /**
     * Data to update
     */
    updateData: EmployeeUpdateRequest;

    /**
     * Id of the employee
     */
    id: string;
  }

  /**
   * Parameters for EmployeeDeleteEmployee
   */
  export interface EmployeeDeleteEmployeeParams {
    version: string;

    /**
     * Guid/Id from the employee
     */
    id: string;
  }

  /**
   * Parameters for EmployeeCreateEmployee
   */
  export interface EmployeeCreateEmployeeParams {
    version: string;

    /**
     * Required data for creating an employee
     */
    createData: EmployeeCreateRequest;
  }

  /**
   * Parameters for EmployeeLogin
   */
  export interface EmployeeLoginParams {
    version: string;

    /**
     * Username and password from the employee
     */
    loginData: EmployeeLoginRequest;
  }
}

export { EmployeeService }
