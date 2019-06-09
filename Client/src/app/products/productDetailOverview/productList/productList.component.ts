import { Component, OnInit, Input, OnChanges, SimpleChanges, ChangeDetectionStrategy } from '@angular/core';
import { ProductTypeResponse } from '@_generated/models';
import { ProductTypeService } from '@_generated/services';
import { Observable, Subject } from 'rxjs';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-productList',
  templateUrl: './productList.component.html',
  styleUrls: ['./productList.component.scss']
})
export class ProductListComponent implements OnInit {


  // @Input() currentId: string;
  private currentId: string;
  public childProducts: Array<ProductTypeResponse>;

  constructor(
    private productTypeService: ProductTypeService,
    private route: ActivatedRoute) {

  }

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.currentId = params.id;
      if (this.currentId) {
        this.productTypeService.GetAllChildrenFromProductType(this.currentId).subscribe(data => {
          this.childProducts = data.children;
        }, error => {
          alert(error);
        });
      }
    });
  }
}
