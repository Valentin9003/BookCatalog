import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { AuthorModel } from '../models/authorModel';

@Injectable({
  providedIn: 'root'
})
export class AuthorService {
authorBaseUrl = environment.authorsApiUrl;
  constructor(private http: HttpClient) { }

  becomeAuthor(author: AuthorModel): Observable<boolean>{
    return this.http.post<boolean>(this.authorBaseUrl + '/Author/BecomeAuthor', author);
  }
}
