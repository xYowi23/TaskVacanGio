import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DestinazoneListaComponent } from './destinazone-lista.component';

describe('DestinazoneListaComponent', () => {
  let component: DestinazoneListaComponent;
  let fixture: ComponentFixture<DestinazoneListaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DestinazoneListaComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DestinazoneListaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
