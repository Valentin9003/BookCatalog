import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AuthorComponent } from './author/author.component';
import { AllAuthorsComponent } from './all.authors/all.authors.component';
import { AddAuthorComponent } from './add.author/add.author.component';
import { EditAuthorComponent } from './edit.author/edit.author.component';



@NgModule({
  declarations: [AuthorComponent, AllAuthorsComponent, AddAuthorComponent, EditAuthorComponent],
  imports: [
    CommonModule
  ]
})
export class AuthorsModule { }
