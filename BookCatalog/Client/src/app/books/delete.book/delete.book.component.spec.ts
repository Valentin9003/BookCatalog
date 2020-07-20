import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteBookComponent } from './delete.book.component';

describe('Delete.BookComponent', () => {
  let component: DeleteBookComponent;
  let fixture: ComponentFixture<DeleteBookComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DeleteBookComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DeleteBookComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
