/* tslint:disable */
export interface ProductTypeRemoveChildRequest {

  /**
   * Id of the child product type which should be removed
   */
  "child-id"?: string;

  /**
   * Id of the product type which the child should be removed from
   */
  "base-id"?: string;
}
