/* tslint:disable */
export interface ProductTypeAddParentsRequest {

  /**
   * Ids of the new parents product types
   */
  parentIds?: Array<string>;

  /**
   * Id of the product type which the parents product types should be added to
   */
  baseId?: string;
}
