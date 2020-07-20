import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AuthorComponent } from './author/author.component';
import { Author } from './author.info/author.info.component';
import { All } from './all.authors/all.authors.component';
import { Add } from './add.author/add.author.component';
import { Edit } from './edit.author/edit.author.component';



@NgModule({
  declarations: [AuthorComponent, Author.InfoComponent, All.AuthorsComponent, Add.AuthorComponent, Edit.AuthorComponent],
  imports: [
    CommonModule
  ]
})
export class AuthorsModule { }
