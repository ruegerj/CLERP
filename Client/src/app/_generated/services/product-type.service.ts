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
import { ProductTypeGetAllChildrenResponse } from '../models/product-type-get-all-children-response';
import { ProductTypeAddParentsRequest } from '../models/product-type-add-parents-request';
import { ProductTypeAddChildrenRequest } from '../models/product-type-add-children-request';
import { ProductTypeRemoveParentsRequest } from '../models/product-type-remove-parents-request';
import { ProductTypeRemoveChildrenRequest } from '../models/product-type-remove-children-request';
@Injectable({
  providedIn: 'root',
})
class ProductTypeService extends __BaseService {
  static readonly GetAllProductTypesPath = '/api/v1/ProductType';
  static readonly CreateProductTypePath = '/api/v1/ProductType';
  static readonly GetProductTypeByIdPath = '/api/v1/ProductType/{id}';
  static readonly UpdateProductTypePath = '/api/v1/ProductType/{id}';
  static readonly DeleteProductTypePath = '/api/v1/ProductType/{id}';
  static readonly GetAllChildrenFromProductTypePath = '/api/v1/ProductType/children/{id}';
  static readonly GetAllParentsFromProductTypePath = '/api/v1/ProductType/parents/{id}';
  static readonly AddParentProductTypePath = '/api/v1/ProductType/add-parents';
  static readonly AddChildProductTypePath = '/api/v1/ProductType/add-children';
  static readonly RemoveParentProductTypePath = '/api/v1/ProductType/remove-parents';
  static readonly RemoveChildProductTypePath = '/api/v1/ProductType/remove-children';

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
   * @param id Id of the parent product type which the children should be loaded for
   * @return Success
   */
  GetAllChildrenFromProductTypeResponse(id: string): __Observable<__StrictHttpResponse<ProductTypeGetAllChildrenResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/v1/ProductType/children/${id}`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<ProductTypeGetAllChildrenResponse>;
      })
    );
  }
  /**
   * @param id Id of the parent product type which the children should be loaded for
   * @return Success
   */
  GetAllChildrenFromProductType(id: string): __Observable<ProductTypeGetAllChildrenResponse> {
    return this.GetAllChildrenFromProductTypeResponse(id).pipe(
      __map(_r => _r.body as ProductTypeGetAllChildrenResponse)
    );
  }

  /**
   * @param id Id of the child product type which the parents should be loaded for
   * @return Success
   */
  GetAllParentsFromProductTypeResponse(id: string): __Observable<__StrictHttpResponse<ProductTypeGetAllChildrenResponse>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/v1/ProductType/parents/${id}`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<ProductTypeGetAllChildrenResponse>;
      })
    );
  }
  /**
   * @param id Id of the child product type which the parents should be loaded for
   * @return Success
   */
  GetAllParentsFromProductType(id: string): __Observable<ProductTypeGetAllChildrenResponse> {
    return this.GetAllParentsFromProductTypeResponse(id).pipe(
      __map(_r => _r.body as ProductTypeGetAllChildrenResponse)
    );
  }

  /**
   * @param productTypeAddParenData Data for adding one or more new parents product types
   */
  AddParentProductTypeResponse(productTypeAddParenData?: ProductTypeAddParentsRequest): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = productTypeAddParenData;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/v1/ProductType/add-parents`,
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
   * @param productTypeAddParenData Data for adding one or more new parents product types
   */
  AddParentProductType(productTypeAddParenData?: ProductTypeAddParentsRequest): __Observable<null> {
    return this.AddParentProductTypeResponse(productTypeAddParenData).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param productTypeAddChildData Data for adding new children for a product type
   */
  AddChildProductTypeResponse(productTypeAddChildData?: ProductTypeAddChildrenRequest): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = productTypeAddChildData;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/v1/ProductType/add-children`,
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
   * @param productTypeAddChildData Data for adding new children for a product type
   */
  AddChildProductType(productTypeAddChildData?: ProductTypeAddChildrenRequest): __Observable<null> {
    return this.AddChildProductTypeResponse(productTypeAddChildData).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param productTypeRemoveParentData Data for removing one or more parents from the base product type
   */
  RemoveParentProductTypeResponse(productTypeRemoveParentData?: ProductTypeRemoveParentsRequest): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = productTypeRemoveParentData;
    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/api/v1/ProductType/remove-parents`,
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
   * @param productTypeRemoveParentData Data for removing one or more parents from the base product type
   */
  RemoveParentProductType(productTypeRemoveParentData?: ProductTypeRemoveParentsRequest): __Observable<null> {
    return this.RemoveParentProductTypeResponse(productTypeRemoveParentData).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param productTypeRemoveChildData Data for removing one or more children from the base product type
   */
  RemoveChildProductTypeResponse(productTypeRemoveChildData?: ProductTypeRemoveChildrenRequest): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = productTypeRemoveChildData;
    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/api/v1/ProductType/remove-children`,
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
   * @param productTypeRemoveChildData Data for removing one or more children from the base product type
   */
  RemoveChildProductType(productTypeRemoveChildData?: ProductTypeRemoveChildrenRequest): __Observable<null> {
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
