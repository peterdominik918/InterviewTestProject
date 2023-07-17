import { Component, OnInit} from '@angular/core';
import { catchError, takeUntil } from "rxjs/operators";
import { Subject, combineLatest, throwError } from "rxjs";

import { EmployeeService } from '../../services/employee.service';
import { Employee } from 'src/app/interfaces/Employee';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.scss'],
})
export class EmployeeListComponent implements OnInit{
  employees!: Employee[];

  constructor(
    private readonly employeeService: EmployeeService,
  ) {}
  
  ngOnInit(): void {
    this.employeeService.getAll()
    .subscribe(data => {
      this.employees = data;
    })
  }
}
