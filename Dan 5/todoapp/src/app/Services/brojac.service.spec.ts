import { TestBed } from '@angular/core/testing';

import { BrojacService } from './brojac.service';

describe('BrojacService', () => {
  let service: BrojacService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(BrojacService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
