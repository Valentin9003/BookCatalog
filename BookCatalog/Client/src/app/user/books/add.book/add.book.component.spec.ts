import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Add.BookComponent } from './add.book.component';

describe('Add.BookComponent', () => {
  let component: Add.BookComponent;
  let fixture: ComponentFixture<Add.BookComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Add.BookComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Add.BookComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
