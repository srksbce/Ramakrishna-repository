import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { LayoutComponent } from './layout/layout.component';

import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
  { path: '', component: LayoutComponent },
  { path: 'home', loadChildren: () => import("./home/home/home.module").then(x => x.HomeModule) },
  { path: 'employee', loadChildren: () => import("./employee/employee/employee.module").then(x => x.EmployeeModule) },




]

@NgModule({
  declarations: [

    LayoutComponent,

  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [LayoutComponent]
})
export class AppModule { }
