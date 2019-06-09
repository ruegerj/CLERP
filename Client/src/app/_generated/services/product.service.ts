/* tslint:disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpResponse, HttpHeaders } from '@angular/common/http';
import { BaseService as __BaseService } from '../base-service';
import { ApiConfiguration as __Configuration } from '../api-configuration';
import { StrictHttpResponse as __StrictHttpResponse } from '../strict-http-response';
import { Observable as __Observable } from 'rxjs';
import { map as __map, filter as __filter } from 'rxjs/operators';

import { ProductGetAllResponse } from '../models/product-get-all-response';
import { ProductCreateResponse } from '../models/product-create-response';
import { ProductCreateRequest } from '../models/product-create-request';
import { ProductResponse } from '../models/product-response';
import { ProductUpdateRequest } from '../models/product-update-request';
@Injectable({
  providedIn: 'root',
})
class ProductService extends __BaseService {
  static readonly GetAllProductsPath = '/api/v1/Product';
  static readonly CreateProductPath = '/api/v1/Product';
  static readonly GetProductByIdPath = '/api/v1/Product/{id}';
  static readonly DeleteProductPath = '/api/v1/Product/{id}';
  static readonly UpdateProductPath = '/api/v1/Product/{id}';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * @return Success
   */
  GetAllProductsResponse(): __Observable<__StrictHttpResponse<ProductGetAllResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/v1/Product`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<ProductGetAllResponse>;
      })
    );
  }
  /**
   * @return Success
   */
  GetAllProducts(): __Observable<ProductGetAllResponse> {
    return this.GetAllProductsResponse().pipe(
      __map(_r => _r.body as ProductGetAllResponse)
    );
  }

  /**
   * @param createData Data for creating new products
   * @return Products successfuly created
   */
  CreateProductResponse(createData?: ProductCreateRequest): __Observable<__StrictHttpResponse<ProductCreateResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = createData;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/v1/Product`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<ProductCreateResponse>;
      })
    );
  }
  /**
   * @param createData Data for creating new products
   * @return Products successfuly created
   */
  CreateProduct(createData?: ProductCreateRequest): __Observable<ProductCreateResponse> {
    return this.CreateProductResponse(createData).pipe(
      __map(_r => _r.body as ProductCreateResponse)
    );
  }

  /**
   * @param id Id of the requested product
   * @return Product found
   */
  GetProductByIdResponse(id: string): __Observable<__StrictHttpResponse<ProductResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/v1/Product/${id}`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<ProductResponse>;
      })
    );
  }
  /**
   * @param id Id of the requested product
   * @return Product found
   */
  GetProductById(id: string): __Observable<ProductResponse> {
    return this.GetProductByIdResponse(id).pipe(
      __map(_r => _r.body as ProductResponse)
    );
  }

  /**
   * @param id Id of the product
   */
  DeleteProductResponse(id: string): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/api/v1/Product/${id}`,
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
   * @param id Id of the product
   */
  DeleteProduct(id: string): __Observable<null> {
    return this.DeleteProductResponse(id).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param params The `ProductService.UpdateProductParams` containing the following parameters:
   *
   * - `id`: Id of the product which should be updated
   *
   * - `updateData`: Data for updating a product
   *
   * @return Product successfuly updated
   */
  UpdateProductResponse(params: ProductService.UpdateProductParams): __Observable<__StrictHttpResponse<ProductResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    __body = params.updateData;
    let req = new HttpRequest<any>(
      'PATCH',
      this.rootUrl + `/api/v1/Product/${params.id}`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<ProductResponse>;
      })
    );
  }
  /**
   * @param params The `ProductService.UpdateProductParams` containing the following parameters:
   *
   * - `id`: Id of the product which should be updated
   *
   * - `updateData`: Data for updating a product
   *
   * @return Product successfuly updated
   */
  UpdateProduct(params: ProductService.UpdateProductParams): __Observable<ProductResponse> {
    return this.UpdateProductResponse(params).pipe(
      __map(_r => _r.body as ProductResponse)
    );
  }
}

module ProductService {

  /**
   * Parameters for UpdateProduct
   */
  export interface UpdateProductParams {

    /**
     * Id of the product which should be updated
     */
    id: string;

    /**
     * Data for updating a product
     */
    updateData?: ProductUpdateRequest;
  }
}

export { ProductService }
