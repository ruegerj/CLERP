export class Product{
    public Name: string;
    public Description: string;
    public EAN: number;
    public Price: number;
    public Image?: string; 

    constructor(name: string, desc: string, ean: number, price: number, img: string = null){
        this.Name = name;
        this.Description = desc;
        this.EAN = ean;
        this.Price = price;
        this.Image = img;
    }
}