import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Edit.BookComponent } from './edit.book.component';

describe('Edit.BookComponent', () => {
  let component: Edit.BookComponent;
  let fixture: ComponentFixture<Edit.BookComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Edit.BookComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Edit.BookComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
