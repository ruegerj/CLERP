/* tslint:disable */
export interface ProductTypeRemoveChildrenRequest {

  /**
   * Ids of the children product types which should be removed
   */
  childIds?: Array<string>;

  /**
   * Id of the product type which the child should be removed from
   */
  baseId?: string;
}
