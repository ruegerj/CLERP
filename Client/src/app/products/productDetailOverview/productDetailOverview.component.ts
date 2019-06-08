import { Component, OnInit } from '@angular/core';
import { ProductTypeService } from '@_generated/services';
import { ActivatedRoute } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ValidationConstans } from '@_models';
import { ProductTypeResponse } from '@_generated/models';

@Component({
  selector: 'app-productDetailOverview',
  templateUrl: './productDetailOverview.component.html',
  styleUrls: ['./productDetailOverview.component.scss']
})
export class ProductDetailOverviewComponent implements OnInit {
  public id: string;

  constructor(
    private route: ActivatedRoute,
  ) { }

  ngOnInit() {
    this.route.params.subscribe(params => this.id = params.id);
  }
}
