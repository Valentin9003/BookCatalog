import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { StatisticsService } from '../statistics/statistics.service';
import { Statistics } from '../statistics/statistics.model';
import { BookService } from 'src/app/books/book.service';
import { Book } from 'src/app/books/models/BookModel';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  books: Array<Book>;
  statistics: Statistics;

  constructor(
    private bookService: BookService, 
    private statisticsService: StatisticsService, 
    private router: Router) { }

  ngOnInit(): void {
    this.bookService.getBooks(10).subscribe(res => {
      this.books = res;
    });

    this.statisticsService.getStatistics().subscribe(res => {
      this.statistics = res;
    });
  }

  goToBooks(id) {
    this.router.navigate(['books'], { queryParams: { id: id } });
  }
}
