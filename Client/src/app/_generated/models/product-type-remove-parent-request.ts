/* tslint:disable */
export interface ProductTypeRemoveParentRequest {

  /**
   * Id of the parent product type which should be removed
   */
  "parent-id"?: string;

  /**
   * Id of the product type which the parent should be removed from
   */
  "base-id"?: string;
}
