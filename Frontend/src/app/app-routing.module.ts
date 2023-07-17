import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmployeeListComponent } from './components/employee-list/employee-list.component';
import { EmployeeCreateComponent } from './components/employee-create/employee-create.component';
import { EmployeeDetailComponent } from './components/employee-detail/employee-detail.component';

const routes: Routes = [{
  path: '',
  component: EmployeeListComponent
},
{
  path: 'create',
  component: EmployeeCreateComponent
},
{ 
  path: 'employee/:id',
  component: EmployeeDetailComponent
}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
