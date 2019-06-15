/* tslint:disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpResponse, HttpHeaders } from '@angular/common/http';
import { BaseService as __BaseService } from '../base-service';
import { ApiConfiguration as __Configuration } from '../api-configuration';
import { StrictHttpResponse as __StrictHttpResponse } from '../strict-http-response';
import { Observable as __Observable } from 'rxjs';
import { map as __map, filter as __filter } from 'rxjs/operators';

import { WarehouseGetAllResponse } from '../models/warehouse-get-all-response';
@Injectable({
  providedIn: 'root',
})
class WarehouseService extends __BaseService {
  static readonly GetAllWarehousesPath = '/api/v1/Warehouse';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * @return Success
   */
  GetAllWarehousesResponse(): __Observable<__StrictHttpResponse<WarehouseGetAllResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/v1/Warehouse`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<WarehouseGetAllResponse>;
      })
    );
  }
  /**
   * @return Success
   */
  GetAllWarehouses(): __Observable<WarehouseGetAllResponse> {
    return this.GetAllWarehousesResponse().pipe(
      __map(_r => _r.body as WarehouseGetAllResponse)
    );
  }
}

module WarehouseService {
}

export { WarehouseService }
