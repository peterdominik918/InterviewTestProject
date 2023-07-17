import { Pipe, PipeTransform } from '@angular/core';

@Pipe({name: 'Sex'})
export class SexPipe implements PipeTransform {
  transform(value?: boolean): string {
    return value ? 'Male' : 'Female';
  }
}