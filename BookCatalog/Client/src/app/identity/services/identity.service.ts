import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class IdentityService {

  loginUrl: string = "";
  registerUrl: string = "";
  constructor(private http: HttpClient, private router: Router) { }

  login(payload: any): Observable<any> {
    return this.http.post(this.loginUrl, payload);
  }

  logout() {
    this.removeToken();
    this.router.navigate(["login"]);
  }

  register(payload: any) {
    return this.http.post(this.registerUrl, payload);
  }

  removeToken() {
    localStorage.removeItem('token');
  }

  setToken(token: string) {
    localStorage.setItem('token', token);
  }

  getToken(): string {
    return localStorage.getItem("token")
  }


  isAuthenticated(): boolean {
    if (this.getToken()) {
      return true;
    }
    else {
      return false;
    }
  }
}
