import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { ProductTypeResponse } from '@_generated/models';
import { ProductTypeService } from '@_generated/services';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-productTypeParentList',
  templateUrl: './productTypeParentList.component.html',
  styleUrls: ['./productTypeParentList.component.scss']
})
export class ProductTypeParentListComponent implements OnInit {
  private currentId: string;
  public parentProductTypes: Array<ProductTypeResponse>;

  @Output() parentRemoved = new EventEmitter<ProductTypeResponse>();


  constructor(
    private productTypeService: ProductTypeService,
    private route: ActivatedRoute) {

  }

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.currentId = params.id;
      if (this.currentId) {
        this.productTypeService.GetAllParentsFromProductType(this.currentId).subscribe(data => {
          console.log(data);
          this.parentProductTypes = data.parents;
        }, error => {
          alert(error);
        });
      }
    });
  }

  
  public removeClicked(pt: ProductTypeResponse): void {
    const index: number = this.parentProductTypes.indexOf(pt);
    if (index !== -1) {
      this.parentProductTypes.splice(index, 1);
      this.parentRemoved.emit(pt);
    }    
  }
}
