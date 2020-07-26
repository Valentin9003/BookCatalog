import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Book } from '../BookModel';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  booksPath: string = environment.booksApiUrl + 'books/';
  booksPathWithoutSlash  = this.booksPath.slice(0, -1);

  constructor(private http: HttpClient) { }

  getBooks(payload: any): Observable<Array<Book>> {
    return this.http.get<Array<Book>>(this.booksPath + payload); //TODO: Pagination
  }

  getBooksByAuthor(authorId: string, payload: any): Observable<Array<Book>> {
    return this.http.get<Array<Book>>(this.booksPath + `GetBooksByAuthor/${authorId}` + payload);
  }

  getBook(id: string): Observable<Book> {
    return this.http.get<Book>(this.booksPath + "/GetBook/" +  id);
  }

  search(queryString): Observable<Array<Book>> {
    return this.http.get<Array<Book>>(this.booksPath + queryString)
  }

  sort(queryString): Observable<Array<Book>> {
    return this.http.get<Array<Book>>(this.booksPath + queryString)
  }

}
