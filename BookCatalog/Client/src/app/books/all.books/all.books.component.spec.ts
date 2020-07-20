import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AllBooksComponent } from './all.books.component';

describe('All.BooksComponent', () => {
  let component: AllBooksComponent;
  let fixture: ComponentFixture<AllBooksComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AllBooksComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AllBooksComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
