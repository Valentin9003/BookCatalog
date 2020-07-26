import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { BookService } from '../../books/services/book.service'
import { Book } from '../../books/BookModel';

@Component({
  selector: 'app-pagination',
  templateUrl: './pagination.component.html',
  styleUrls: ['./pagination.component.css']
})
export class PaginationComponent implements OnInit {
  @Input('queryString') queryString;
  @Output('emitter') emitter = new EventEmitter<Array<Book>>();
  constructor(private bookService: BookService) { }

  ngOnInit(): void {
  }

  // changePage() {
  //   this.bookService.search(this.queryString).subscribe(res => {
  //     this.emitter.emit(res);
  //   })
  // }

}
