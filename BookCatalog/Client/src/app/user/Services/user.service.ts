import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { BookModel } from '../books/models/book.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  userApiPath: string = environment.userApiPath;

  getCurrentAuthorPath: string = environment.userApiPath + 'Author/GetCurrentAuthorId'
  getBookPath: string = environment.userApiPath + 'Book/GetBook/';
  getBooksPath: string = environment.userApiPath + 'Book/GetBooks/';
  createBookPath: string = environment.userApiPath + 'Book/CreateBook/';
  editBookPath: string = environment.userApiPath + 'Book/CreateBook/'
  deleteBookPath: string = environment.userApiPath + 'Book/CreateBook/';
  searchBookPath: string = environment.userApiPath + 'Book/SearchByName'

  constructor(private http: HttpClient) { }

  getBook(bookId: string): Observable<BookModel> {
    return this.http.get<BookModel>(this.getBookPath + `/${bookId}`)
  }

  getBooks(paging: number): Observable<BookModel[]> {
    return this.http.get<BookModel[]>(this.getBooksPath + `/${paging}`)
  }

  createBook(authorId: string, book: BookModel): Observable<boolean> {
    return this.http.post<boolean>(this.createBookPath, book)
  }

  editBook(bookId: string, book: BookModel): Observable<boolean> {
    return this.http.put<boolean>(this.editBookPath + `/${bookId}`, book)
  }

  deleteBook(bookId: string): Observable<boolean> {
    return this.http.delete<boolean>(this.deleteBookPath + `$/{bookId}`)

  }

  getcurrentAuthorId(): Observable<string> {
    return this.http.get<string>(this.getCurrentAuthorPath)
  }

  searchBookByName(queryString): Observable<Array<BookModel>> {
    return this.http.get<Array<BookModel>>(this.searchBookPath + queryString)
  }
}
