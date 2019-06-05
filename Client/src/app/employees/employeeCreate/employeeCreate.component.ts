import { Component, OnInit, ViewChild, TemplateRef } from '@angular/core';
import { EmployeeResponse, DepartmentResponse, RoleResponse } from '@_generated/models';
import { FormGroup, FormBuilder, Validators, FormArray, FormControl } from '@angular/forms';
import { EmployeeService, DepartmentService, RoleService } from '@_generated/services';
import { NgbDateAdapter, NgbDateNativeAdapter, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';
import { ValidationConstans } from '@_models';

@Component({
  selector: 'app-employeeCreate',
  templateUrl: './employeeCreate.component.html',
  styleUrls: ['./employeeCreate.component.css'],
  providers: [{ provide: NgbDateAdapter, useClass: NgbDateNativeAdapter }]
})
export class EmployeeCreateComponent implements OnInit {
  /** properties **/
  employee: EmployeeResponse;
  submitted: boolean = false;
  employeeForm: FormGroup;
  departments: Array<DepartmentResponse>;
  roles: Array<RoleResponse>;

  @ViewChild('modalSuccessContent') private modalSuccessContent: TemplateRef<any>;
  @ViewChild('modalErrorContent') private modalErrorContent: TemplateRef<any>;


  constructor(
    private employeeService: EmployeeService,
    private departmentService: DepartmentService,
    private roleService: RoleService,
    private formBuilder: FormBuilder,
    private modalService: NgbModal,
    private router: Router,
  ) { }


  ngOnInit() {

    this.employeeForm = this.formBuilder.group({
      firstName: ['', [Validators.required, Validators.minLength(ValidationConstans.MinNameLength), Validators.maxLength(ValidationConstans.MaxNameLength)]],
      lastName: ['', [Validators.required, Validators.minLength(ValidationConstans.MinNameLength), Validators.maxLength(ValidationConstans.MaxNameLength)]],
      email: ['', [Validators.required, Validators.email]],
      phoneNumber: ['', [Validators.required, Validators.pattern(ValidationConstans.PhoneNumberRegex)]],
      birthday: ['', Validators.required],
      username: ['', [Validators.required, Validators.minLength(ValidationConstans.MinUsernameLength), Validators.maxLength(ValidationConstans.MaxUsernameLength)]],
      password: ['', [Validators.required, Validators.minLength(ValidationConstans.MinPasswordLength), Validators.maxLength(ValidationConstans.MaxPasswordLength)]],
      department: [''],
      roles: new FormArray([])
    });


    this.departmentService.GetAllDepartments().subscribe(data => {
      this.departments = data.departments;
    });

    //Roles needed to build form
    this.roleService.GetAllRoles().subscribe(data => {
      this.roles = data.roles;
      this.addRoleCheckboxes();
    });
  }


  // convenience getter for easy access to form fields
  get f() { return this.employeeForm.controls; }


  private addRoleCheckboxes() {
    this.roles.map(() => {
      const control = new FormControl(false);
      (this.employeeForm.controls.roles as FormArray).push(control);
    });
  }


  /** click event methods for **/
  createClicked(): void {
    this.submitted = true;



    if (this.employeeForm.invalid) {
      return;
    }

    const formValue = Object.assign({}, this.employeeForm.value, {
      roles: this.employeeForm.value.roles.map((selected, i) => {
        return {
          id: this.roles[i].id,
          selected
        }
      })
    });

    var createdEmployeeId: string = null;

    this.employeeService.CreateEmployee({
      firstname: formValue.firstName, lastname: formValue.lastName, email: formValue.email, phoneNumber: formValue.phoneNumber,
      birthday: formValue.birthday, username: formValue.username, password: formValue.password
    }).subscribe(data => {
      createdEmployeeId = data.employeeId;
    }, (error) => {
      this.modalService.open(this.modalErrorContent);
      return;
    });

    console.log(createdEmployeeId);

    if (createdEmployeeId) {
      this.departmentService.AddEmployeeToDepartment({
        departmentId: formValue.department, employeeId: createdEmployeeId
      }).subscribe(data => {
      }, (error) => {
        this.modalService.open(this.modalErrorContent);
        return;
      });

      formValue.roles.forEach(element => {
        if (element.selected) {
          this.roleService.AddRoleToEmployee({
            employeeId: createdEmployeeId, roleId: element.id
          }).subscribe(data => {
            this.modalService.open(this.modalSuccessContent);
            this.router.navigate(['/employees']);
          }, (error) => {
            this.modalService.open(this.modalErrorContent);
            return;
          });
        }
      });
    }
  }
}
