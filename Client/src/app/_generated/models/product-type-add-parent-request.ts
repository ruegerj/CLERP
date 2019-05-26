/* tslint:disable */
export interface ProductTypeAddParentRequest {

  /**
   * Id of the new parent product type
   */
  "parent-id"?: string;

  /**
   * Id of the product type which the parent product type should be added to
   */
  "base-id"?: string;
}
