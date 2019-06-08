import { Component, OnInit } from '@angular/core';
import { ProductTypeResponse } from '@_generated/models';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ProductTypeService } from '@_generated/services';
import { Router } from '@angular/router';
import { ValidationConstans } from '@_models';

@Component({
  selector: 'app-productCreate',
  templateUrl: './productCreate.component.html',
  styleUrls: ['./productCreate.component.scss']
})
export class ProductCreateComponent implements OnInit {
  public product: ProductTypeResponse = {};
  public submitted: boolean;
  public productTypeForm: FormGroup;
  public imagePath: string = './assets/images/noImageFound.gif';

  constructor(
    private productTypeService: ProductTypeService,
    private formBuilder: FormBuilder,
    private router: Router
  ) { }

  ngOnInit() {
    this.productTypeForm = this.formBuilder.group({
      image: [''],
      productName: ['', [Validators.required, Validators.minLength(ValidationConstans.MinNameLength), Validators.maxLength(ValidationConstans.MaxNameLength)]],
      ean: ['', Validators.required],
      price: ['', [Validators.required, Validators.min(0.01)]],
      description: ['']
    });
  }


  // convenience getter for easy access to form fields
  get f() { return this.productTypeForm.controls; }

  onFileChanged(event) {
    var file = event.target.files[0];

    this.imagePath = file;

    if (file) {
      var reader = new FileReader();

      reader.onload = this.handleReaderLoaded.bind(this);

      reader.readAsBinaryString(file);
    }
  }

  handleReaderLoaded(readerEvt) {
    var binaryString = readerEvt.target.result;
    this.f.image.setValue(btoa(binaryString));
    console.log(btoa(binaryString));
  }

  /** click event methods for **/
  createClicked(): void {
    this.submitted = true;

    console.log(this.f);

    if (this.productTypeForm.invalid) {
      return;
    }

    this.productTypeService.CreateProductType({
      imageBase64: this.f.image.value,
      name: this.f.productName.value, ean: this.f.ean.value, price: this.f.price.value, description: this.f.description.value
    }).subscribe(data => {
      alert("Product created succesfully");
      this.router.navigate(['/products']);
    }, (error) => {
      alert(error);
    })
  }
}
