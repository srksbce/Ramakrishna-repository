import { Component, OnInit } from '@angular/core';
import { IEmployee } from '../employee-model';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

  employees = [] as IEmployee[];

  constructor() { }

  ngOnInit(): void {
    this.employees = [
      { empNumber: 101, empName: 'Sathesh', empSalary: 25000 },
      { empNumber: 102, empName: 'Krishna', empSalary: 35000 },
      { empNumber: 103, empName: 'Rama', empSalary: 45000 },
      { empNumber: 104, empName: 'Sita', empSalary: 55000 }
    ];
  }

}
