import { Component, OnInit, Input, ViewChild, TemplateRef } from '@angular/core';
import { Product } from '@_models/product';
import { ProductTypeService } from '@_generated/services';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ProductTypeResponse } from '@_generated/models';
import { ValidationConstans } from '@_models';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';

@Component({
  selector: 'app-productDetail',
  templateUrl: './productDetail.component.html',
  styleUrls: ['./productDetail.component.scss']
})
export class ProductDetailComponent implements OnInit {
  public product: ProductTypeResponse;
  public submitted: boolean;
  public isEditing: boolean;
  public productForm: FormGroup;

  @Input() id: string;

  @ViewChild('modalSuccessContent') private modalSuccessContent: TemplateRef<any>;
  @ViewChild('modalErrorContent') private modalErrorContent: TemplateRef<any>;

  constructor(
    private productTypeService: ProductTypeService,
    private formBuilder: FormBuilder,
    private modalService: NgbModal,
    private router: Router
  ) {
    this.isEditing = false;
  }

  ngOnInit() {
    this.productForm = this.formBuilder.group({
      productName: [{ value: '', disabled: !this.isEditing }, [Validators.required, Validators.minLength(ValidationConstans.MinNameLength), Validators.maxLength(ValidationConstans.MaxNameLength)]],
      ean: [{ value: '', disabled: !this.isEditing }, Validators.required],
      price: [{ value: '', disabled: !this.isEditing }, [Validators.required, Validators.min(0.01)]],
      description: [{ value: '', disabled: !this.isEditing }]
    });


    if (this.id) {
      this.productTypeService.GetProductTypeById(this.id).subscribe(data => {
        console.log(data);
        this.product = data;
        this.setFormValues(data);
      })
    }
  }


  // convenience getter for easy access to form fields
  get f() { return this.productForm.controls; }


  private setFormValues(e: ProductTypeResponse) {
    this.productForm.setValue({
      productName: this.product.name,
      ean: this.product.ean,
      price: this.product.price,
      description: this.product.Description
    });
  }


  /** click event methods **/
  editClicked(): void {
    this.isEditing = true;
    this.submitted = false;
    this.productForm.enable();
  }

  cancelClicked(): void {
    this.isEditing = false;
    this.submitted = false;
    this.productForm.disable();
    this.setFormValues(this.product);
  }

  updateClicked(modalSuccessContent): void {
    this.submitted = true;

    if (this.productForm.invalid) {
      return;
    }

    console.log(this.f);

    this.productTypeService.UpdateProductType({
      id: this.id, updateData: {
        name: this.f.productName.value, ean: this.f.ean.value,
        price: this.f.price.value, description: this.f.description.value
      }
    }).subscribe(data => {
      this.modalService.open(this.modalSuccessContent);
      this.router.navigate(['/products']);
    }, (error) => {
      this.modalService.open(this.modalErrorContent);
    }
    );
  }
}
