import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { LoginModel } from './Models/models';

@Injectable({
  providedIn: 'root'
})
export class AuthServiceService {

  constructor(private http: HttpClient) {
  }

  login(userName: string, password: string) {
    return this.http.post<LoginModel>('/api/login', { userName, password })
      // this is just the HTTP call, 
      // we still need to handle the reception of the token
  }
}
