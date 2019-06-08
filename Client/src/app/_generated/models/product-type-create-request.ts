/* tslint:disable */
export interface ProductTypeCreateRequest {
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

  /**
   * Collection with all ids of all parent product types
   */
  parentIds?: Array<string>;

  /**
   * Collection with all ids of all the child product types
   */
  childIds?: Array<string>;
}
