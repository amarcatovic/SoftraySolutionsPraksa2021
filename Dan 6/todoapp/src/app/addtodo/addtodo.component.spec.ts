import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddtodoComponent } from './addtodo.component';

describe('AddtodoComponent', () => {
  let component: AddtodoComponent;
  let fixture: ComponentFixture<AddtodoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddtodoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddtodoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
