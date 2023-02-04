import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SoseteComponent } from './sosete.component';

describe('SoseteComponent', () => {
  let component: SoseteComponent;
  let fixture: ComponentFixture<SoseteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SoseteComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SoseteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
