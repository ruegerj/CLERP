import { Component, OnInit, Output, EventEmitter, Input } from '@angular/core';
import { ProductTypeResponse } from '@_generated/models';
import { ProductTypeService } from '@_generated/services';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-productTypeChildList',
  templateUrl: './productTypeChildList.component.html',
  styleUrls: ['./productTypeChildList.component.scss']
})
export class ProductTypeChildListComponent implements OnInit {
  private currentId: string;
  private _isEditing: boolean;

  public childProductTypes: Array<ProductTypeResponse>;

  @Input() set isEditing(isEditing: boolean) { this._isEditing = isEditing; }
  get isEditing(): boolean { return this._isEditing; }

  @Output() childRemoved = new EventEmitter<ProductTypeResponse>();

  constructor(
    private productTypeService: ProductTypeService,
    private route: ActivatedRoute) {

  }

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.currentId = params.id;
      if (this.currentId) {
        this.productTypeService.GetAllChildrenFromProductType(this.currentId).subscribe(data => {
          this.childProductTypes = data.children;
        }, error => {
          alert(error);
        });
      }
    });
  }


  public removeClicked(pt: ProductTypeResponse): void {
    // const index: number = this.childProductTypes.indexOf(pt);
    // if (index !== -1) {
    //   this.childProductTypes.splice(index, 1);
    // }    
    this.childRemoved.emit(pt);
  }
}
