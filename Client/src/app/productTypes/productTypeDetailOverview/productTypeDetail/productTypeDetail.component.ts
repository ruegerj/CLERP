import { Component, OnInit } from '@angular/core';
import { ProductTypeService } from '@_generated/services';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ProductTypeResponse } from '@_generated/models';
import { ValidationConstants } from '@_models';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-productTypeDetail',
  templateUrl: './productTypeDetail.component.html',
  styleUrls: ['./productTypeDetail.component.scss']
})
export class ProductTypeDetailComponent implements OnInit {
  public productType: ProductTypeResponse;
  public submitted: boolean;
  public isEditing: boolean;
  public productTypeForm: FormGroup;

  public imagePath;
  imgURL: any;
  public message: string;

  private currentId: string;


  constructor(
    private productTypeService: ProductTypeService,
    private formBuilder: FormBuilder,
    private router: Router,
    private route: ActivatedRoute
  ) {
    this.isEditing = false;
  }

  ngOnInit() {
    this.productTypeForm = this.formBuilder.group({
      productTypeName: [{ value: '', disabled: !this.isEditing }, [Validators.required, Validators.minLength(ValidationConstants.MinNameLength), Validators.maxLength(ValidationConstants.MaxNameLength)]],
      ean: [{ value: '', disabled: !this.isEditing }, Validators.required],
      price: [{ value: '', disabled: !this.isEditing }, [Validators.required, Validators.min(0.01)]],
      description: [{ value: '', disabled: !this.isEditing }]
    });

    this.route.params.subscribe(params => {
      this.currentId = params.id;
      this.productTypeService.GetProductTypeById(this.currentId).subscribe(data => {
        console.log(data);
        this.imgURL = "data:image/png;base64," + data.imageBase64;
        this.productType = data;
        this.setFormValues(data);
      });
    });
  }


  // convenience getter for easy access to form fields
  get f() { return this.productTypeForm.controls; }

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
    this.productTypeForm.setValue({
      productTypeName: this.productType.name,
      ean: this.productType.ean,
      price: this.productType.price,
      description: this.productType.Description
    });
  }


  /** click event methods **/
  editClicked(): void {
    this.isEditing = true;
    this.submitted = false;
    this.productTypeForm.enable();
  }

  cancelClicked(): void {
    this.isEditing = false;
    this.submitted = false;
    this.productTypeForm.disable();
    this.setFormValues(this.productType);
  }

  updateClicked(modalSuccessContent): void {
    this.submitted = true;

    if (this.productTypeForm.invalid) {
      return;
    }

    console.log(this.f);

    this.productTypeService.UpdateProductType({
      id: this.currentId, updateData: {
        name: this.f.productName.value, ean: this.f.ean.value,
        price: this.f.price.value, description: this.f.description.value
      }
    }).subscribe(data => {
      alert("Producttype updated succesfully");
      this.router.navigate(['/productTypes']);
    }, (error) => {
      alert(error);
    }
    );
  }
}
