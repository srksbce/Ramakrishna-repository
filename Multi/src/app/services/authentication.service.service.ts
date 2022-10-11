import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { from } from 'rxjs';
import { environment } from 'src/environments/environment';



@Injectable({
  providedIn: 'root'
})
export class AuthenticationServiceService {

  ApiUrl = environment.ApiUrl;


  constructor(private _http: HttpClient) { }

  public postData(url: string, object: any) {

    return this._http.post(`${this.ApiUrl}${url}`, object)

  }
}
