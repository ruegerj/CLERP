/* tslint:disable */
export interface ProductTypeRemoveChildRequest {

  /**
   * Id of the child product type which should be removed
   */
  childId?: string;

  /**
   * Id of the product type which the child should be removed from
   */
  baseId?: string;
}
