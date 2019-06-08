/* tslint:disable */
export interface ProductCreateRequestModel {
  description?: string;
  serialNumber: string;
  parentId?: string;
  childrenIds?: Array<string>;
  productTypeId?: string;
  compartmentId?: string;
}
