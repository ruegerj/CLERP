import { Component, OnInit, Input, OnChanges, SimpleChanges, ChangeDetectionStrategy } from '@angular/core';
import { ProductTypeResponse } from '@_generated/models';
import { ProductTypeService } from '@_generated/services';
import { Observable, Subject } from 'rxjs';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-productTypeList',
  templateUrl: './productTypeList.component.html',
  styleUrls: ['./productTypeList.component.scss']
})
export class ProductTypeListComponent implements OnInit {


  // @Input() currentId: string;
  private currentId: string;
  public childProductTypes: Array<ProductTypeResponse>;

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
}
