import { Component, OnInit } from '@angular/core';
import { NgbDateAdapter, NgbDateNativeAdapter } from '@ng-bootstrap/ng-bootstrap';
import { EmployeeService, DepartmentService, RoleService } from '@_generated/services';
import { FormGroup, FormBuilder, Validators, FormArray, FormControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeResponse, DepartmentResponse, RoleResponse } from '@_generated/models';
import { ValidationConstants } from '@_models';
import { forkJoin } from 'rxjs';

@Component({
  selector: 'app-employeeEdit',
  templateUrl: './employeeEdit.component.html',
  styleUrls: ['./employeeEdit.component.scss'],
  providers: [{ provide: NgbDateAdapter, useClass: NgbDateNativeAdapter }]
})
export class EmployeeEditComponent implements OnInit {
  /** properties **/
  public employee: EmployeeResponse;
  public isEditing: boolean;
  public submitted: boolean = false;
  public employeeForm: FormGroup;
  public id: string;
  public departments: Array<DepartmentResponse>;
  public roles: Array<RoleResponse>;


  constructor(
    private employeeService: EmployeeService,
    private formBuilder: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private departmentService: DepartmentService,
    private roleService: RoleService
  ) {
    this.isEditing = false;
  }


  ngOnInit() {
    this.employeeForm = this.formBuilder.group({
      username: [{ value: '', disabled: !this.isEditing }, [Validators.required, Validators.minLength(ValidationConstants.MinUsernameLength), Validators.maxLength(ValidationConstants.MaxUsernameLength)]],
      firstName: [{ value: '', disabled: !this.isEditing }, [Validators.required, Validators.minLength(ValidationConstants.MinNameLength), Validators.maxLength(ValidationConstants.MaxNameLength)]],
      lastName: [{ value: '', disabled: !this.isEditing }, [Validators.required, Validators.minLength(ValidationConstants.MinNameLength), Validators.maxLength(ValidationConstants.MaxNameLength)]],
      email: [{ value: '', disabled: !this.isEditing }, [Validators.required, Validators.email]],
      phoneNumber: [{ value: '', disabled: !this.isEditing }, [Validators.required, Validators.pattern(ValidationConstants.PhoneNumberRegex)]],
      birthday: [{ value: '', disabled: !this.isEditing }, Validators.required],
      department: [{ value: '', disabled: !this.isEditing }, Validators.required],
      roles: new FormArray([])
    });


    let getAllDepartements = this.departmentService.GetAllDepartments();
    let getAllRoles = this.roleService.GetAllRoles();
    let getEmployee = this.employeeService.GetEmployeeById(this.id);

    this.route.params.subscribe(params => {
      this.id = params.id;
      forkJoin([getAllDepartements, getAllRoles]).subscribe(results => {
        this.departments = results[0].departments;

        this.employeeService.GetEmployeeById(params.id).subscribe(data => {
          this.employee = data;
          this.setFormValues(data);
        })

        this.roles = results[1].roles;
        this.addRoleCheckboxes();
      })
    });
  }


  // convenience getter for easy access to form fields
  get f() { return this.employeeForm.controls; }


  private addRoleCheckboxes() {
    this.roles.map(() => {
      const control = new FormControl({ value: false, disabled: !this.isEditing });
      (this.employeeForm.controls.roles as FormArray).push(control);
    });
  }


  private setFormValues(e: EmployeeResponse) {
    this.employeeForm.setValue({
      username: e.username,
      firstName: e.firstname,
      lastName: e.lastname,
      email: e.email,
      phoneNumber: e.phoneNumber,
      birthday: new Date(e.birthday),
      department: this.departments.find(d => { return d.id === e.department.id }),
      roles: this.roles.map(r => e.roles.map(r => r.id).includes(r.id))
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

  updateClicked(modalSuccessContent): void {
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

    this.employeeService.UpdateEmployee({
      id: this.id, updateData: {
        username: formValue.username, firstname: formValue.firstName, lastname: formValue.lastName, email: formValue.email, phoneNumber: formValue.phoneNumber,
        birthday: formValue.birthday
      }
    }).subscribe(data => {
      if (formValue.department.id === this.employee.department.id) {
          this.roleService.AddRoleToEmployee({ employeeId: this.id, roleIds: formValue.roles.filter(function (role) { return role.selected === true }).map(roles => roles.id) }).subscribe(
            data => {
              alert("succescfully updated employee");
              this.router.navigate(['/employees']);
            },
            error => {
              alert(error);
              return;
            }
          )
      }
      else{
        forkJoin(
          this.departmentService.AddEmployeeToDepartment({ departmentId: formValue.department.id, employeeId: formValue.employeeId }),
          this.roleService.AddRoleToEmployee({ employeeId: this.id, roleIds: formValue.roles.filter(function (role) { return role.selected === true }).map(roles => roles.id) })).subscribe(
            data => {
              alert("succescfully updated employee");
              this.router.navigate(['/employees']);
            },
            error => {
              alert(error);
              return;
            }
          )
      }
    },
      error => {
        alert(error);
        return;
      }
    )
  }
}
