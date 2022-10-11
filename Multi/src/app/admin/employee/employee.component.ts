import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';

import { IEmployee } from './employee-model';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

  employee = [] as IEmployee[];
  subscription!: Subscription
  deptId!: string | null;

  constructor(private http: HttpClient, private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.deptId = this.activatedRoute.snapshot.queryParamMap.get("deptId");
    this.loadEmployees();
  }
  loadEmployees() {
    let url = "";
    if (this.deptId)
      url = "Employee/EmpDetailsByDept?Id=" + this.deptId;
    else
      url = "Employee";
    //this.subscription = this.http.getDataWithParam("Employee/EmpDetailsByDept", this.deptId).subscribe({
    this.subscription = this.http.get(url).subscribe({
      next: (data: any) => {
        this.employee = data.data as IEmployee[];
        console.log(this.employee);
      },
      error: reason => console.log(reason)
    });

  }
  ngOnDestroy(): void {
    if (this.subscription)
      this.subscription.unsubscribe();
  }

}
