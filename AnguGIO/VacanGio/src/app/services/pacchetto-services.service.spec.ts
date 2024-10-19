import { TestBed } from '@angular/core/testing';

import { PacchettoServicesService } from './pacchetto-services.service';

describe('PacchettoServicesService', () => {
  let service: PacchettoServicesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PacchettoServicesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
