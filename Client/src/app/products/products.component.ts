import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { ProductTypeResponse } from '@_generated/models';
import { ProductTypeService } from '@_generated/services';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent implements OnInit {

  public searchControl: FormControl = new FormControl('');
  public products: Array<ProductTypeResponse>;
  public filteredProducts: Array<ProductTypeResponse>;


  constructor(private productTypeService: ProductTypeService) { }


  ngOnInit() {
    this.productTypeService.GetAllProductTypes().subscribe(data => {
      this.products = data.productTypes;
      this.filteredProducts = this.products;
    })
  }


  searchClicked(): void {
    var searchText = this.searchControl.value.toLowerCase();
    this.filteredProducts = this.products.filter(product => {
      return (
        product.Description.toLowerCase().includes(searchText)
        || product.ean.toLowerCase().includes(searchText)
        || product.name.toLowerCase().includes(searchText)
      );
    })
  }
}
