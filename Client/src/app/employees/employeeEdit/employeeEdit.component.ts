import { Component, OnInit, ViewChild, TemplateRef } from '@angular/core';
import { NgbDateAdapter, NgbDateNativeAdapter, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { EmployeeService } from '@_generated/services';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeResponse } from '@_generated/models';

@Component({
  selector: 'app-employeeEdit',
  templateUrl: './employeeEdit.component.html',
  styleUrls: ['./employeeEdit.component.scss'],
  providers: [{ provide: NgbDateAdapter, useClass: NgbDateNativeAdapter }]
})
export class EmployeeEditComponent implements OnInit {
  /** properties **/
  employee: EmployeeResponse;
  isEditing: boolean;
  submitted: boolean = false;
  employeeForm: FormGroup;
  id: string;

  @ViewChild('modalSuccessContent') private modalSuccessContent: TemplateRef<any>;
  @ViewChild('modalErrorContent') private modalErrorContent: TemplateRef<any>;

  /** validation vars **/
  private minNameLength: number = 2;
  private maxNameLength: number = 100;
  private minUsernameLength: number = 5;
  private maxUsernameLength: number = 15;


  constructor(
    private employeeService: EmployeeService,
    private formBuilder: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private modalService: NgbModal
  ) {
    this.isEditing = false;
    // this.backupEmployee = Object.assign({}, this.employee);
  }


  ngOnInit() {
    this.employeeForm = this.formBuilder.group({
      username: [{ value: '', disabled: !this.isEditing }, [Validators.required, Validators.minLength(this.minUsernameLength), Validators.maxLength(this.maxUsernameLength)]],
      firstName: [{ value: '', disabled: !this.isEditing }, [Validators.required, Validators.minLength(this.minNameLength), Validators.maxLength(this.maxNameLength)]],
      lastName: [{ value: '', disabled: !this.isEditing }, [Validators.required, Validators.minLength(this.minNameLength), Validators.maxLength(this.maxNameLength)]],
      email: [{ value: '', disabled: !this.isEditing }, [Validators.required, Validators.email]],
      phoneNumber: [{ value: '', disabled: !this.isEditing }, [Validators.required, Validators.pattern('^([\+][0-9]{1,3}([ \.\-])?)?([\(]{1}[0-9]{3}[\)])?([0-9A-Z \.\-]{1,32})((x|ext|extension)?[0-9]{1,4}?)$')]],
      birthday: [{ value: '', disabled: !this.isEditing }, Validators.required],
    })

    this.route.params.subscribe(params => this.id = params.id);

    if (this.id) {
      this.employeeService.GetEmployeeById(this.id).subscribe(data => {
        this.employee = data;
        console.log(data);
        this.setFormValues(data);
      })
    }
  }


  // convenience getter for easy access to form fields
  get f() { return this.employeeForm.controls; }

  private setFormValues(e: EmployeeResponse) {
    this.employeeForm.setValue({
      username: e.username,
      firstName: e.firstname,
      lastName: e.lastname,
      email: e.email,
      phoneNumber: e.phoneNumber,
      birthday: new Date(e.birthday),
    })
  }

  /** click event methods **/
  editClicked(): void {
    this.isEditing = true;
    this.submitted = false;
    this.employeeForm.enable();
  }

  cancelClicked(): void {
    this.isEditing = false;
    this.submitted = false;
    this.employeeForm.disable();
    this.setFormValues(this.employee);
  }

  createClicked(modalSuccessContent): void {
    this.submitted = true;

    if (this.employeeForm.invalid) {
      return;
    }

    this.employeeService.UpdateEmployee({
      id: this.id, updateData: {
        username: this.f.username.value, firstname: this.f.firstName.value, lastname: this.f.lastName.value, email: this.f.email.value, phoneNumber: this.f.phoneNumber.value,
        birthday: this.f.birthday.value
      }
    }).subscribe(data => {
      this.modalService.open(this.modalSuccessContent);
      this.router.navigate(['/employees']);
    }, (error) => {
      this.modalService.open(this.modalErrorContent);
    }
    );
  }
}
