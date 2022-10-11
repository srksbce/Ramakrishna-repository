import { Component, OnDestroy, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs';

import { AuthenticationServiceService } from 'src/app/services/authentication.service.service';

import { IRegister } from '../register-model';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit, OnDestroy {

  registeruser = {} as IRegister;
  confirmPassword!: string;
  subscription!: Subscription;

  constructor(private _authenticationservice: AuthenticationServiceService, private router: Router) { }

  ngOnInit(): void {
  }

  register(f: NgForm) {
    this.subscription = this._authenticationservice.postData("Accounts", this.registeruser).subscribe({

      next: (data: any) => {
        console.log(data);
        if (data.statusCode == 200) {
          alert(data.message);
          this.registeruser = {} as IRegister;
          f.resetForm();

          //this.router.navigate(["/"]);
        }
        else {
          alert(data.message);
        }
      },
      error: reason => {
        console.log(reason);
      }
    });
  }

  ngOnDestroy(): void {
    if (this.subscription)
      this.subscription.unsubscribe();
  }

}
