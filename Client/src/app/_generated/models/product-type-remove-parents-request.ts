/* tslint:disable */
export interface ProductTypeRemoveParentsRequest {

  /**
   * Id of the parent product type which should be removed
   */
  parentId?: Array<string>;

  /**
   * Id of the product type which the parent should be removed from
   */
  baseId?: string;
}
