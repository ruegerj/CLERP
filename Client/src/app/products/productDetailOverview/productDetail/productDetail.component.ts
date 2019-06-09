import { Component, OnInit, Input, ViewChild, TemplateRef } from '@angular/core';
import { Product } from '@_models/product';
import { ProductTypeService } from '@_generated/services';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ProductTypeResponse } from '@_generated/models';
import { ValidationConstants } from '@_models';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { Router, ActivatedRoute } from '@angular/router';
import { Observable, Subject } from 'rxjs';

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

  public imagePath;
  imgURL: any;
  public message: string;

  //@Input() currentId: string;
  private currentId: string;

  @ViewChild('modalSuccessContent') private modalSuccessContent: TemplateRef<any>;
  @ViewChild('modalErrorContent') private modalErrorContent: TemplateRef<any>;

  constructor(
    private productTypeService: ProductTypeService,
    private formBuilder: FormBuilder,
    private modalService: NgbModal,
    private router: Router,
    private route: ActivatedRoute
  ) {
    this.isEditing = false;
  }

  ngOnInit() {
    this.productForm = this.formBuilder.group({
      productName: [{ value: '', disabled: !this.isEditing }, [Validators.required, Validators.minLength(ValidationConstants.MinNameLength), Validators.maxLength(ValidationConstants.MaxNameLength)]],
      ean: [{ value: '', disabled: !this.isEditing }, Validators.required],
      price: [{ value: '', disabled: !this.isEditing }, [Validators.required, Validators.min(0.01)]],
      description: [{ value: '', disabled: !this.isEditing }]
    });

    this.route.params.subscribe(params => {
      this.currentId = params.id;
      this.productTypeService.GetProductTypeById(this.currentId).subscribe(data => {
        console.log(data);
        this.imgURL = "data:image/png;base64," + data.imageBase64;
        this.product = data;
        this.setFormValues(data);
      });
    });
  }


  // convenience getter for easy access to form fields
  get f() { return this.productForm.controls; }

  // gett for ValidationConstants
  get valditationConstants() { return ValidationConstants; }

  preview(files) {
    if (files.length === 0)
      return;

    var mimeType = files[0].type;
    if (mimeType.match(/image\/*/) == null) {
      this.message = "Only images are supported.";
      return;
    }

    var reader = new FileReader();
    this.imagePath = files;

    reader.readAsDataURL(files[0]);
    reader.onload = (_event) => {
      this.imgURL = reader.result;
      this.imgURL.replace(/^data:image\/[a-z]+;base64,/, "");
    }
  }


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
      id: this.currentId, updateData: {
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
