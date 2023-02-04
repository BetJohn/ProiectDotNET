import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PantaloniComponent } from './pantaloni.component';

describe('PantaloniComponent', () => {
  let component: PantaloniComponent;
  let fixture: ComponentFixture<PantaloniComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PantaloniComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PantaloniComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
