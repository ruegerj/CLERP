/* tslint:disable */
export interface ProductTypeRemoveParentRequest {

  /**
   * Id of the parent product type which should be removed
   */
  parentId?: string;

  /**
   * Id of the product type which the parent should be removed from
   */
  baseId?: string;
}
