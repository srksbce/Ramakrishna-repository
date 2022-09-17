import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-employee-details',
  templateUrl: './employee-details.component.html',
  styleUrls: ['./employee-details.component.css']
})
export class EmployeeDetailsComponent implements OnInit {

  empNumber: any;

  constructor(private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    //this.empNumber = this.activatedRoute.snapshot.queryParamMap.get("empNumber");
    this.empNumber = this.activatedRoute.snapshot.paramMap.get("empNumber");
  }

}
