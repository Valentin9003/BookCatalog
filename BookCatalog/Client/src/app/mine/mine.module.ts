import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BookComponent } from './books/book/book.component';
import { AuthorComponent } from '../authors/author/author.component';
import { AuthorInfoComponent } from './author/author.info/author.info.component';
import { BooksListComponent } from './books/books.list/books.list.component';
import { EditBookComponent } from './books/edit.book/edit.book.component';
import { AddBookComponent } from './books/add.book/add.book.component';



@NgModule({
  declarations: [BookComponent, AuthorComponent, BooksListComponent, BookComponent, AuthorInfoComponent, BooksListComponent, EditBookComponent, AddBookComponent],
  imports: [
    CommonModule
  ]
})
export class UserModule { }
