import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Employee } from 'src/app/interfaces/Employee';
import { EmployeeService } from 'src/app/services/employee.service';

@Component({
  selector: 'app-employee-detail',
  templateUrl: './employee-detail.component.html',
  styleUrls: ['./employee-detail.component.scss']
})
export class EmployeeDetailComponent implements OnInit{
  employee!: Employee;
  id!: string;

  description: string = '';

  constructor(private readonly employeeService: EmployeeService,
    private route: ActivatedRoute,
    private router: Router){
  }

  ngOnInit(): void {
    this.id = this.route.snapshot.paramMap.get('id') as string;

    this.employeeService.getById(this.id)
    .subscribe({
      next: (data) => {
        console.log(data);
        this.employee = data;
        this.description = data.description as string;
      },
      error: (err) => {
        this.router.navigateByUrl('');
      },
    })
  }

  onUpdate(): void{    
    this.employeeService.update(this.id, this.description)
    .subscribe({
      next: () => this.router.navigateByUrl(''),
      error: (err) => {
        alert('Error');
      },
    });;
  }

  onDelete(): void{
    this.employeeService.delete(this.id)
    .subscribe({
      next: () => this.router.navigateByUrl(''),
      error: (err) => {
        alert('Error');
      },
    });;
  }
}
