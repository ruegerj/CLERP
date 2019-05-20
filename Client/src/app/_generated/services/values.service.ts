/* tslint:disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpResponse, HttpHeaders } from '@angular/common/http';
import { BaseService as __BaseService } from '../base-service';
import { ApiConfiguration as __Configuration } from '../api-configuration';
import { StrictHttpResponse as __StrictHttpResponse } from '../strict-http-response';
import { Observable as __Observable } from 'rxjs';
import { map as __map, filter as __filter } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
class ValuesService extends __BaseService {
  static readonly ValuesGetAllPath = '/api/v{version}/Values';
  static readonly ValuesPostPath = '/api/v{version}/Values';
  static readonly ValuesGetPath = '/api/v{version}/Values/{id}';
  static readonly ValuesPutPath = '/api/v{version}/Values/{id}';
  static readonly ValuesDeletePath = '/api/v{version}/Values/{id}';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * @param version undefined
   */
  ValuesGetAllResponse(version: string): __Observable<__StrictHttpResponse<Array<string>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/v${version}/Values`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<string>>;
      })
    );
  }
  /**
   * @param version undefined
   */
  ValuesGetAll(version: string): __Observable<Array<string>> {
    return this.ValuesGetAllResponse(version).pipe(
      __map(_r => _r.body as Array<string>)
    );
  }

  /**
   * @param params The `ValuesService.ValuesPostParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `data`:
   */
  ValuesPostResponse(params: ValuesService.ValuesPostParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    __body = params.data;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/v${params.version}/Values`,
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
   * @param params The `ValuesService.ValuesPostParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `data`:
   */
  ValuesPost(params: ValuesService.ValuesPostParams): __Observable<null> {
    return this.ValuesPostResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param params The `ValuesService.ValuesGetParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `id`:
   */
  ValuesGetResponse(params: ValuesService.ValuesGetParams): __Observable<__StrictHttpResponse<string>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/v${params.version}/Values/${params.id}`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'text'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<string>;
      })
    );
  }
  /**
   * @param params The `ValuesService.ValuesGetParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `id`:
   */
  ValuesGet(params: ValuesService.ValuesGetParams): __Observable<string> {
    return this.ValuesGetResponse(params).pipe(
      __map(_r => _r.body as string)
    );
  }

  /**
   * @param params The `ValuesService.ValuesPutParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `value`:
   *
   * - `id`:
   */
  ValuesPutResponse(params: ValuesService.ValuesPutParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    __body = params.value;

    let req = new HttpRequest<any>(
      'PUT',
      this.rootUrl + `/api/v${params.version}/Values/${params.id}`,
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
   * @param params The `ValuesService.ValuesPutParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `value`:
   *
   * - `id`:
   */
  ValuesPut(params: ValuesService.ValuesPutParams): __Observable<null> {
    return this.ValuesPutResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param params The `ValuesService.ValuesDeleteParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `id`:
   */
  ValuesDeleteResponse(params: ValuesService.ValuesDeleteParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/api/v${params.version}/Values/${params.id}`,
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
   * @param params The `ValuesService.ValuesDeleteParams` containing the following parameters:
   *
   * - `version`:
   *
   * - `id`:
   */
  ValuesDelete(params: ValuesService.ValuesDeleteParams): __Observable<null> {
    return this.ValuesDeleteResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }
}

module ValuesService {

  /**
   * Parameters for ValuesPost
   */
  export interface ValuesPostParams {
    version: string;
    data: string;
  }

  /**
   * Parameters for ValuesGet
   */
  export interface ValuesGetParams {
    version: string;
    id: number;
  }

  /**
   * Parameters for ValuesPut
   */
  export interface ValuesPutParams {
    version: string;
    value: string;
    id: number;
  }

  /**
   * Parameters for ValuesDelete
   */
  export interface ValuesDeleteParams {
    version: string;
    id: number;
  }
}

export { ValuesService }
