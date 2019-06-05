/* tslint:disable */
export interface ProductCreateRequest {
  description?: string;
  serialNumber: string;
  parentId?: string;
  childrenIds?: Array<string>;
  productTypeId?: string;
  compartmentId?: string;
}
