import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { FormControl } from '@angular/forms';
import { ProductTypeResponse } from '@_generated/models';
import { ProductTypeService } from '@_generated/services';

@Component({
  selector: 'app-addToProductType',
  templateUrl: './addToProductType.component.html',
  styleUrls: ['./addToProductType.component.css']
})
export class AddToProductTypeComponent implements OnInit {
  public searchControl: FormControl = new FormControl('');
  public productTypes: Array<ProductTypeResponse>;
  public filteredProductTypes: Array<ProductTypeResponse>;

  @Output() ptAdded = new EventEmitter<ProductTypeResponse>();


  constructor(private productTypeService: ProductTypeService) { }


  ngOnInit() {
    this.productTypeService.GetAllProductTypes().subscribe(data => {
      this.productTypes = data.productTypes;
      this.filteredProductTypes = this.productTypes;
    })
  }

  public addClicked(pt: ProductTypeResponse): void{
    this.ptAdded.emit(pt);
  }

  public searchClicked(): void {
    var searchText = this.searchControl.value.toLowerCase();
    this.filteredProductTypes = this.productTypes.filter(pt => {
      return (
        pt.Description.toLowerCase().includes(searchText)
        || pt.ean.toLowerCase().includes(searchText)
        || pt.name.toLowerCase().includes(searchText)
      );
    })
  }
}
