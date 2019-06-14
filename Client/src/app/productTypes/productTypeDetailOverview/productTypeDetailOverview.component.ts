import { Component, OnInit } from '@angular/core';
import { ProductTypeResponse } from '@_generated/models';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ProductTypeService } from '@_generated/services';
import { Router, ActivatedRoute } from '@angular/router';
import { ValidationConstants } from '@_models';
import { forkJoin, Observable, of } from 'rxjs';


@Component({
  selector: 'app-productTypeDetailOverview',
  templateUrl: './productTypeDetailOverview.component.html',
  styleUrls: ['./productTypeDetailOverview.component.scss']
})
export class ProductTypeDetailOverviewComponent implements OnInit {
  public productType: ProductTypeResponse;
  public submitted: boolean;
  public isEditing: boolean;
  public productTypeForm: FormGroup;

  public childrenToAdd: Array<ProductTypeResponse> = new Array<ProductTypeResponse>();
  public parentsToAdd: Array<ProductTypeResponse> = new Array<ProductTypeResponse>();
  public parentsToRemove: Array<ProductTypeResponse> = new Array<ProductTypeResponse>();
  public childrenToRemove: Array<ProductTypeResponse> = new Array<ProductTypeResponse>();

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
        this.imgURL = "data:image/png;base64," + data.imageBase64;
        this.productType = data;
        this.setFormValues(data);

        //reset editing state
        this.isEditing = false;
        this.submitted = false;
        this.productTypeForm.disable();
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

  public addChildAdded(pt: ProductTypeResponse): void {
    if (this.productType.id == pt.id) {
      alert("Can't add product type to itself.");
      return;
    }
    if (this.childrenToAdd.map(c => c.id).includes(pt.id) || this.productType.childIds.includes(pt.id)) {
      alert(pt.name + " already added to children.");
      return;
    }

    this.childrenToAdd.push(pt);
  }

  public addParentAdded(pt: ProductTypeResponse): void {
    if (this.productType.id == pt.id) {
      alert("Can't add product type to itself.");
      return;
    }
    if (this.parentsToAdd.map(p => p.id).includes(pt.id) || this.productType.parentIds.includes(pt.id)) {
      alert(pt.name + " already added to parents.");
      return;
    }
    
    this.parentsToAdd.push(pt);
  }

  public childRemoved(pt: ProductTypeResponse): void {
    if (!this.childrenToRemove.map(c => c.id).includes(pt.id)) {
      this.childrenToRemove.push(pt);
    }
    else {
      alert(pt.name + " already removed from children.");
    }
  }

  public parentRemoved(pt: ProductTypeResponse): void {
    if (!this.parentsToRemove.map(c => c.id).includes(pt.id)) {
      this.parentsToRemove.push(pt);
    }
    else {
      alert(pt.name + " already removed from parents.");
    }
  }



  /** click event methods **/
  public removeAddChildClicked(child: ProductTypeResponse): void {
    const index: number = this.childrenToAdd.indexOf(child);
    if (index !== -1) {
      this.childrenToAdd.splice(index, 1);
    }
  }

  public removeAddParentClicked(parent: ProductTypeResponse): void {
    const index: number = this.parentsToAdd.indexOf(parent);
    if (index !== -1) {
      this.parentsToAdd.splice(index, 1);
    }
  }

  public removeRemoveChildClicked(parent: ProductTypeResponse): void {
    const index: number = this.childrenToRemove.indexOf(parent);
    if (index !== -1) {
      this.childrenToRemove.splice(index, 1);
    }
  }

  public removeRemoveParentClicked(parent: ProductTypeResponse): void {
    const index: number = this.parentsToRemove.indexOf(parent);
    if (index !== -1) {
      this.parentsToRemove.splice(index, 1);
    }
  }

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
    this.parentsToAdd.length = 0;
    this.parentsToRemove.length = 0;
    this.childrenToAdd.length = 0;
    this.childrenToRemove.length = 0;
  }

  updateClicked(modalSuccessContent): void {
    this.submitted = true;

    if (this.productTypeForm.invalid) {
      return;
    }

    this.productTypeService.UpdateProductType({
      id: this.currentId, updateData: {
        imageBase64: this.imgURL.replace(/^data:image\/[a-z]+;base64,/, ""),
        name: this.f.productTypeName.value, ean: this.f.ean.value,
        price: this.f.price.value, description: this.f.description.value
      }
    }).subscribe(data => {
      let sources = [
        this.childrenToAdd.length > 0 ? this.productTypeService.AddChildProductType({ baseId: this.currentId, childIds: this.childrenToAdd.map(c => c.id) }) : of(null),
        this.parentsToAdd.length > 0 ? this.productTypeService.AddParentProductType({ baseId: this.currentId, parentIds: this.parentsToAdd.map(p => p.id) }) : of(null),
        this.childrenToRemove.length > 0 ? this.productTypeService.RemoveChildProductType({ baseId: this.currentId, childIds: this.childrenToRemove.map(p => p.id) }) : of(null),
        this.parentsToRemove.length > 0 ? this.productTypeService.RemoveParentProductType({ baseId: this.currentId, parentId: this.parentsToRemove.map(p => p.id) }) : of(null)
      ];

      forkJoin(...sources).subscribe(data => {
        alert("Producttype updated succesfully");
        this.router.navigate(['/productTypes']);
      }, (error) => {
        alert(error);
      });
    }, (error) => {
      alert(error);
    });
  }
}
