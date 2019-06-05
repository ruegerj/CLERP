/* tslint:disable */

/**
 * Default response dto for a product
 */
export interface ProductResponse {
  id?: string;
  name?: string;
  serialNumber?: string;
  state?: 'inStock' | 'reserved' | 'sold' | 'defect';
  parentId?: string;
  childIds?: Array<string>;
  productTypeId?: string;
  compartmentId?: string;
  billId?: string;
}
