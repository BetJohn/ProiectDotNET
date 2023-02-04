import { TestBed } from '@angular/core/testing';

import { BluzaService } from './bluza.service';

describe('BluzaService', () => {
  let service: BluzaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(BluzaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
