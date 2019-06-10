/* tslint:disable */
export interface ProductTypeAddChildrenRequest {

  /**
   * Ids from the new children for the product type
   */
  childIds?: Array<string>;

  /**
   * Id of the product type which the child product type should be added to
   */
  baseId?: string;
}
