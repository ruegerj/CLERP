/* tslint:disable */
export interface ProductTypeAddParentRequest {

  /**
   * Id of the new parent product type
   */
  parentId?: string;

  /**
   * Id of the product type which the parent product type should be added to
   */
  baseId?: string;
}
