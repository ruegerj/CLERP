/* tslint:disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpResponse, HttpHeaders } from '@angular/common/http';
import { BaseService as __BaseService } from '../base-service';
import { ApiConfiguration as __Configuration } from '../api-configuration';
import { StrictHttpResponse as __StrictHttpResponse } from '../strict-http-response';
import { Observable as __Observable } from 'rxjs';
import { map as __map, filter as __filter } from 'rxjs/operators';

import { ProductTypeGetAllResponse } from '../models/product-type-get-all-response';
import { ProductTypeCreateResponse } from '../models/product-type-create-response';
import { ProductTypeCreateRequest } from '../models/product-type-create-request';
import { ProductTypeResponse } from '../models/product-type-response';
import { ProductTypeUpdateRequest } from '../models/product-type-update-request';
import { ProductTypeAddParentRequest } from '../models/product-type-add-parent-request';
import { ProductTypeAddChildRequest } from '../models/product-type-add-child-request';
import { ProductTypeRemoveParentRequest } from '../models/product-type-remove-parent-request';
import { ProductTypeRemoveChildRequest } from '../models/product-type-remove-child-request';
@Injectable({
  providedIn: 'root',
})
class ProductTypeService extends __BaseService {
  static readonly GetAllProductTypesPath = '/api/v1/ProductType';
  static readonly CreateProductTypePath = '/api/v1/ProductType';
  static readonly GetProductTypeByIdPath = '/api/v1/ProductType/{id}';
  static readonly UpdateProductTypePath = '/api/v1/ProductType/{id}';
  static readonly DeleteProductTypePath = '/api/v1/ProductType/{id}';
  static readonly AddParentProductTypePath = '/api/v1/ProductType/add-parent';
  static readonly AddChildProductTypePath = '/api/v1/ProductType/add-child';
  static readonly RemoveParentProductTypePath = '/api/v1/ProductType/remove-parent';
  static readonly RemoveChildProductTypePath = '/api/v1/ProductType/remove-child';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * @return Success
   */
  GetAllProductTypesResponse(): __Observable<__StrictHttpResponse<ProductTypeGetAllResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/v1/ProductType`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<ProductTypeGetAllResponse>;
      })
    );
  }
  /**
   * @return Success
   */
  GetAllProductTypes(): __Observable<ProductTypeGetAllResponse> {
    return this.GetAllProductTypesResponse().pipe(
      __map(_r => _r.body as ProductTypeGetAllResponse)
    );
  }

  /**
   * @param createData Data for creating a new product type
   * @return ProductType successfuly created
   */
  CreateProductTypeResponse(createData?: ProductTypeCreateRequest): __Observable<__StrictHttpResponse<ProductTypeCreateResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = createData;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/v1/ProductType`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<ProductTypeCreateResponse>;
      })
    );
  }
  /**
   * @param createData Data for creating a new product type
   * @return ProductType successfuly created
   */
  CreateProductType(createData?: ProductTypeCreateRequest): __Observable<ProductTypeCreateResponse> {
    return this.CreateProductTypeResponse(createData).pipe(
      __map(_r => _r.body as ProductTypeCreateResponse)
    );
  }

  /**
   * @param id Id of the product type
   * @return ProductType found
   */
  GetProductTypeByIdResponse(id: string): __Observable<__StrictHttpResponse<ProductTypeResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/v1/ProductType/${id}`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<ProductTypeResponse>;
      })
    );
  }
  /**
   * @param id Id of the product type
   * @return ProductType found
   */
  GetProductTypeById(id: string): __Observable<ProductTypeResponse> {
    return this.GetProductTypeByIdResponse(id).pipe(
      __map(_r => _r.body as ProductTypeResponse)
    );
  }

  /**
   * @param params The `ProductTypeService.UpdateProductTypeParams` containing the following parameters:
   *
   * - `id`: Id of the product type
   *
   * - `updateData`: Data for updating a product type
   *
   * @return ProductType successfuly updated
   */
  UpdateProductTypeResponse(params: ProductTypeService.UpdateProductTypeParams): __Observable<__StrictHttpResponse<ProductTypeResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    __body = params.updateData;
    let req = new HttpRequest<any>(
      'PUT',
      this.rootUrl + `/api/v1/ProductType/${params.id}`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<ProductTypeResponse>;
      })
    );
  }
  /**
   * @param params The `ProductTypeService.UpdateProductTypeParams` containing the following parameters:
   *
   * - `id`: Id of the product type
   *
   * - `updateData`: Data for updating a product type
   *
   * @return ProductType successfuly updated
   */
  UpdateProductType(params: ProductTypeService.UpdateProductTypeParams): __Observable<ProductTypeResponse> {
    return this.UpdateProductTypeResponse(params).pipe(
      __map(_r => _r.body as ProductTypeResponse)
    );
  }

  /**
   * @param id Id of the prodcut type
   */
  DeleteProductTypeResponse(id: string): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/api/v1/ProductType/${id}`,
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
   * @param id Id of the prodcut type
   */
  DeleteProductType(id: string): __Observable<null> {
    return this.DeleteProductTypeResponse(id).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param productTypeAddParenData Data for adding a new parent product type
   */
  AddParentProductTypeResponse(productTypeAddParenData?: ProductTypeAddParentRequest): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = productTypeAddParenData;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/v1/ProductType/add-parent`,
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
   * @param productTypeAddParenData Data for adding a new parent product type
   */
  AddParentProductType(productTypeAddParenData?: ProductTypeAddParentRequest): __Observable<null> {
    return this.AddParentProductTypeResponse(productTypeAddParenData).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param productTypeAddChildData Data for adding a new child product type
   */
  AddChildProductTypeResponse(productTypeAddChildData?: ProductTypeAddChildRequest): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = productTypeAddChildData;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/v1/ProductType/add-child`,
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
   * @param productTypeAddChildData Data for adding a new child product type
   */
  AddChildProductType(productTypeAddChildData?: ProductTypeAddChildRequest): __Observable<null> {
    return this.AddChildProductTypeResponse(productTypeAddChildData).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param productTypeRemoveParentData Data for removing the parent from the base product type
   */
  RemoveParentProductTypeResponse(productTypeRemoveParentData?: ProductTypeRemoveParentRequest): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = productTypeRemoveParentData;
    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/api/v1/ProductType/remove-parent`,
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
   * @param productTypeRemoveParentData Data for removing the parent from the base product type
   */
  RemoveParentProductType(productTypeRemoveParentData?: ProductTypeRemoveParentRequest): __Observable<null> {
    return this.RemoveParentProductTypeResponse(productTypeRemoveParentData).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param productTypeRemoveChildData Data for removing the child from the base product type
   */
  RemoveChildProductTypeResponse(productTypeRemoveChildData?: ProductTypeRemoveChildRequest): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = productTypeRemoveChildData;
    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/api/v1/ProductType/remove-child`,
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
   * @param productTypeRemoveChildData Data for removing the child from the base product type
   */
  RemoveChildProductType(productTypeRemoveChildData?: ProductTypeRemoveChildRequest): __Observable<null> {
    return this.RemoveChildProductTypeResponse(productTypeRemoveChildData).pipe(
      __map(_r => _r.body as null)
    );
  }
}

module ProductTypeService {

  /**
   * Parameters for UpdateProductType
   */
  export interface UpdateProductTypeParams {

    /**
     * Id of the product type
     */
    id: string;

    /**
     * Data for updating a product type
     */
    updateData?: ProductTypeUpdateRequest;
  }
}

export { ProductTypeService }
