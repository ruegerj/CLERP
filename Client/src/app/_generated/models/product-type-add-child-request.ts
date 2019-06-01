/* tslint:disable */
export interface ProductTypeAddChildRequest {

  /**
   * Id of the new child product type
   */
  childId?: string;

  /**
   * Id of the product type which the child product type should be added to
   */
  baseId?: string;
}
