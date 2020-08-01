import { Component, OnInit } from '@angular/core';
import { BookModel } from '../models/book.model';
import { Observable, Observer } from 'rxjs';
import { UserService } from '../../Services/user.service';

@Component({
  selector: 'app-books-list',
  templateUrl: './books.list.component.html',
  styleUrls: ['./books.list.component.css']
})
export class BooksListComponent implements OnInit {

  public books: BookModel[];
  constructor(private userService: UserService) { }

  ngOnInit(): void {
    this.userService.getBooks(10).subscribe((data: BookModel[]) => { // TODO: PAGINATION
      this.books = data;
    }
    )
  }
 
}
