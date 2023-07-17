import { Component } from '@angular/core';
import { FormBuilder, FormControl } from '@angular/forms';
import { Router } from '@angular/router';
import { Employee } from 'src/app/interfaces/Employee';
import { EmployeeService } from 'src/app/services/employee.service';
import { EmployeeValidator } from 'src/app/utils/EmployeeValidator';

@Component({
  selector: 'app-employee-create',
  templateUrl: './employee-create.component.html',
  styleUrls: ['./employee-create.component.scss']
})
export class EmployeeCreateComponent {
  employeeForm = this.formBuilder.group({
    name: new FormControl("", { nonNullable: true }),
    birthday: new FormControl(new Date(), { nonNullable: true }),
    sex: new FormControl("male", { nonNullable: true }),
    description: new FormControl("", { nonNullable: true })
  });

  constructor(private formBuilder: FormBuilder
            ,private employeeService: EmployeeService
            ,private router: Router){
  }

  onSubmit(): void {
    const validator = new EmployeeValidator();

    const newEmployee:Employee = {...this.employeeForm.value, sex: this.employeeForm.value.sex === "male" ? true : false};
    
    const errors = validator.validate(newEmployee);

    if (Object.keys(errors).length === 0){
      this.employeeService.create(newEmployee)
      .subscribe({
        next: () => this.router.navigateByUrl(''),
        error: (err) => {
          alert('Error');
        },
      });;
    }
    else{
      alert('Input Correctly!');
    }
  }

}
