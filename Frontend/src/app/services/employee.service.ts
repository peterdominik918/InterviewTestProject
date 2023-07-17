import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from "@angular/common/http";
import { Observable } from "rxjs";
import { Employee } from '../interfaces/Employee';
import { map } from "rxjs/operators";

const url = 'http://127.0.0.1:5000/api/employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor(private readonly http: HttpClient) { }

  getAll(): Observable<Employee[]> {
    return this.http
      .get<Employee[]>(`${url}`);
  }

  getById(id: string): Observable<Employee> {
    return this.http
      .get<Employee>(`${url}/${id}`);
  }

  create(employee: Employee): Observable<Employee> {
    return this.http
      .post<Employee>(`${url}`, employee);
  }

  update(id: string, description: string): Observable<Employee> {
    return this.http
      .put<Employee>(`${url}/${id}`, {description});
  }

  delete(id: string): Observable<Employee> {
    return this.http
      .delete<Employee>(`${url}/${id}`);
  }
}
