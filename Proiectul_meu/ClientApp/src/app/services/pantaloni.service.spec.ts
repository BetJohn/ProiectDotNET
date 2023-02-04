import { TestBed } from '@angular/core/testing';

import { PantaloniService } from './pantaloni.service';

describe('PantaloniService', () => {
  let service: PantaloniService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PantaloniService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
