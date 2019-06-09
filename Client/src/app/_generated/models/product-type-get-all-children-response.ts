/* tslint:disable */
import { ProductTypeResponse } from './product-type-response';
export interface ProductTypeGetAllChildrenResponse {

  /**
   * All first level children of the product type
   */
  children?: Array<ProductTypeResponse>;
}
