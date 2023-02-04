import { TestBed } from '@angular/core/testing';

import { TricouService } from './tricou.service';

describe('TricouService', () => {
  let service: TricouService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TricouService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
