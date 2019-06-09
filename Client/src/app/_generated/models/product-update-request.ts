/* tslint:disable */
export interface ProductUpdateRequest {
  description?: string;
  state: 'inStock' | 'reserved' | 'sold' | 'defect';
  compartmentId?: string;
}
