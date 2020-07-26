import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {
  registerPath: string = environment.identityApiUrl + "identity/register"
  loginPath: string = environment.identityApiUrl + "identity/login";
  createAuthorPath: string = environment.authorsApiUrl + "authors"
  authorIdPath: string = environment.authorsApiUrl + "authors/id";

  constructor(private http: HttpClient) { }

  register(payload): Observable<any> {
      return this.http.post(this.registerPath, payload);
  }

  createDealer(payload) : Observable<any> {
      return this.http.post(this.createAuthorPath, payload);
  }

  login(payload) : Observable<any> {
      return this.http.post(this.loginPath, payload);
  }

  getAuthorId() : Observable<any> {
      return this.http.get(this.authorIdPath);
  }

  setToken(token) {
    localStorage.setItem('token', token);
  }

  setId(authorId) {
    localStorage.setItem('authorId', authorId);
  }
}
