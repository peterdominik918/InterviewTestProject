import { Validator } from 'fluentvalidation-ts';
import { Employee } from '../interfaces/Employee';

export class EmployeeValidator extends Validator<Employee> {
    constructor() {
      super();
  
      this.ruleFor('name').notEmpty()
  
        this.ruleFor('sex').notNull()

        this.ruleFor('birthday').notNull();

        this.ruleFor('description').notEmpty()
    }
  }