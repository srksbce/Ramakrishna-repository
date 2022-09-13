import { Component, OnInit } from '@angular/core';
import { IEmployee } from './services-model';

@Component({
  selector: 'app-services',
  templateUrl: './services.component.html',
  styleUrls: ['./services.component.css']
})
export class ServicesComponent implements OnInit {

  employees = [] as IEmployee[];




  constructor() { }

  ngOnInit(): void {

    this.employees = [
      { enumber: 101, ename: 'Ramakrishna', esalary: 50000, eaddress: 'Khammam' },
      { enumber: 102, ename: 'Rama', esalary: 50000, eaddress: 'Delhi' },
      { enumber: 103, ename: 'krishna', esalary: 50000, eaddress: 'Vza' },
      { enumber: 104, ename: 'kiran', esalary: 50000, eaddress: 'Hyd' },


    ];



  }
  selectTab(val: Number) {

  }

}



