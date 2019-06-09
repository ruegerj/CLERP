/* tslint:disable */
export interface ProductTypeUpdateRequest {
  name: string;
  description?: string;

  /**
   * European Article Number
   */
  ean: string;
  price: number;

  /**
   * Image as base64 string
   */
  imageBase64?: string;
}
