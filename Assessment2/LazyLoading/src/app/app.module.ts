import { NgModule, ɵclearResolutionOfComponentResourcesQueue } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';


import { LayoutComponent } from './layout/layout.component';

import { RouterModule, Routes } from '@angular/router';


const routes: Routes = [

  { path: '', component: LayoutComponent },
  { path: 'home', loadChildren: () => import("./home/home.module").then(x => x.HomeModule) },
  { path: 'about', loadChildren: () => import("./about/about.module").then(x => x.AboutModule) },
  { path: 'services', loadChildren: () => import("./services/services.module").then(x => x.ServicesModule) },
  { path: 'contactus', loadChildren: () => import("./contactus/contactus.module").then(x => x.ContactusModule) }
];


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
