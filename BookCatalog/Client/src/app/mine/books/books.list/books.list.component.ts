import { Component, OnInit } from '@angular/core';
import { BookModel } from '../models/book.model';
import { Observable, Observer } from 'rxjs';
import { MineService } from '../../Services/mine.service';

@Component({
  selector: 'app-books-list',
  templateUrl: './books.list.component.html',
  styleUrls: ['./books.list.component.css']
})
export class BooksListComponent implements OnInit {

  public books: BookModel[];
  constructor(private userService: MineService) { }

  ngOnInit(): void {
    this.userService.getBooks(10).subscribe((data: BookModel[]) => { // TODO: PAGINATION
      this.books = data;
    }
    )
  }
 
}
