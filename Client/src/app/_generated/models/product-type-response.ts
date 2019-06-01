/* tslint:disable */

/**
 * Default response dto for a product type
 */
export interface ProductTypeResponse {
  id?: string;
  name?: string;
  Description?: string;

  /**
   * European articel number
   */
  ean?: string;
  price?: number;

  /**
   * All ids from the entities related as children to this product type
   */
  childIds?: Array<string>;

  /**
   * All ids from the entities related as paretns to this product type
   */
  parentIds?: Array<string>;
}
