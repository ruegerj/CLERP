import { Component, OnInit, Input, ViewChild, TemplateRef } from '@angular/core';
import { ProductTypeResponse } from '@_generated/models';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ProductTypeService } from '@_generated/services';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';
import { ValidationConstans } from '@_models';

@Component({
  selector: 'app-productCreate',
  templateUrl: './productCreate.component.html',
  styleUrls: ['./productCreate.component.css']
})
export class ProductCreateComponent implements OnInit {
  public product: ProductTypeResponse;
  public submitted: boolean;
  public productTypeForm: FormGroup;

  @ViewChild('modalSuccessContent') private modalSuccessContent: TemplateRef<any>;
  @ViewChild('modalErrorContent') private modalErrorContent: TemplateRef<any>;

  constructor(
    private productTypeService: ProductTypeService,
    private formBuilder: FormBuilder,
    private modalService: NgbModal,
    private router: Router
  ) { }

  ngOnInit() {
    this.productTypeForm = this.formBuilder.group({
      productName: ['', [Validators.required, Validators.minLength(ValidationConstans.MinNameLength), Validators.maxLength(ValidationConstans.MaxNameLength)]],
      ean: ['', Validators.required],
      price: ['', [Validators.required, Validators.min(0.01)]],
      description: ['']
    });
  }


  // convenience getter for easy access to form fields
  get f() { return this.productTypeForm.controls; }


  private setFormValues(e: ProductTypeResponse) {
    this.productTypeForm.setValue({
      productName: this.product.name,
      ean: this.product.ean,
      price: this.product.price,
      description: this.product.Description
    });
  }


  /** click event methods for **/
  createClicked(): void {
    this.submitted = true;
  
    console.log(this.f);

    if (this.productTypeForm.invalid) {
      return;
    }

    this.productTypeService.CreateProductType({
      name: this.f.productName.value, ean: this.f.ean.value, price: this.f.price.value, description: this.f.description.value
    }).subscribe(data => {
      this.modalService.open(this.modalSuccessContent);
      this.router.navigate(['/products']);
    }, (error) => {
      this.modalService.open(this.modalErrorContent);
    })
  }
}
