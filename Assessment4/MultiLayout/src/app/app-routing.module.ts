import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
//import { AuthGuard } from './Guards/auth.guard';
import { AuthGuard } from './guards/auth.guard';
import { AdminLayoutComponent } from './layouts/admin-layout/admin-layout.component';
import { AuthenticationLayoutComponent } from './layouts/authentication-layout/authentication-layout.component';
import { ADMIN_ROUTES } from './routes/admin-routing';
import { AUTHENTICATION_ROUTES } from './routes/authentication-routing';

const routes: Routes = [
  { path: '', component: AuthenticationLayoutComponent, children: AUTHENTICATION_ROUTES },
  { path: '', component: AdminLayoutComponent, children: ADMIN_ROUTES, canActivate: [AuthGuard] },

  // { path: 'contactus', loadChildren: () => import("./contactus/contactus.module").then(x => x.ContactusModule) }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
