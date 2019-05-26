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
   * Collection with all ids of all parent product types
   */
  "parent-ids"?: Array<string>;

  /**
   * Collection with all ids of all the child product types
   */
  "child-ids"?: Array<string>;
}
