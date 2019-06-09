import { Component, OnInit, OnDestroy } from '@angular/core';
import { ProductTypeService } from '@_generated/services';
import { ActivatedRoute, Route, Router, NavigationEnd, NavigationStart } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ValidationConstans } from '@_models';
import { ProductTypeResponse } from '@_generated/models';
import { Observable, of, Subject } from 'rxjs';

@Component({
  selector: 'app-productDetailOverview',
  templateUrl: './productDetailOverview.component.html',
  styleUrls: ['./productDetailOverview.component.scss']
})
export class ProductDetailOverviewComponent implements OnInit {

  constructor() {}

  ngOnInit() {
  }
}
