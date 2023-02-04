import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TricouComponent } from './tricou.component';

describe('TricouComponent', () => {
  let component: TricouComponent;
  let fixture: ComponentFixture<TricouComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TricouComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TricouComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
