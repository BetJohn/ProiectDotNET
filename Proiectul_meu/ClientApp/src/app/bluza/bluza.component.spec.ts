import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BluzaComponent } from './bluza.component';

describe('BluzaComponent', () => {
  let component: BluzaComponent;
  let fixture: ComponentFixture<BluzaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BluzaComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BluzaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
