import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthorService } from '../services/author.service';

@Component({
  selector: 'app-add-author',
  templateUrl: './add.author.component.html',
  styleUrls: ['./add.author.component.css']
})
export class AddAuthorComponent implements OnInit {

public authorForm: FormGroup;

  constructor(private fb: FormBuilder, private authorService: AuthorService) {
    this.authorForm = this.fb.group({
      'FirstName': ["", Validators.required],
      'LastName': ["", Validators.required],
      'Biography': ["", Validators.required],
    })
   }
   
  ngOnInit(): void {
  }

  addAuthor(){
    this.authorService.addAuthor()
  }
  get username() {
    return this.authorForm.get('FirstName')
  }
  
  get email() {
    return this.authorForm.get('LastName')
  }
  get password() {
    return this.authorForm.get('Biography')
  }
}
