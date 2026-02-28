import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PurchaseComponent } from './purchase.component';

describe('PurchaseComponent', () => {
  let component: PurchaseComponent;
  let fixture: ComponentFixture<PurchaseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PurchaseComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PurchaseComponent);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
