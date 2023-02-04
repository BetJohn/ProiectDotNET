import { TestBed } from '@angular/core/testing';

import { SoseteService } from './sosete.service';

describe('SoseteService', () => {
  let service: SoseteService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SoseteService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
