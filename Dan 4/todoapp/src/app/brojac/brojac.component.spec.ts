import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BrojacComponent } from './brojac.component';

describe('BrojacComponent', () => {
  let component: BrojacComponent;
  let fixture: ComponentFixture<BrojacComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BrojacComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BrojacComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
