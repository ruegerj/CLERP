import { ProductCreateRequestModel } from '@_generated/models';

export class Product{
    public ProductTypeName: string;
    public RequestModel: ProductCreateRequestModel;

    constructor(productTypeName: string, requestModel: ProductCreateRequestModel){
        this.ProductTypeName = productTypeName;
        this.RequestModel = requestModel;
    }
}