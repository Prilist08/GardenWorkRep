import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StockTransactionsComponent } from './stock-transactions.component';

describe('StockTransactionsComponent', () => {
  let component: StockTransactionsComponent;
  let fixture: ComponentFixture<StockTransactionsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [StockTransactionsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StockTransactionsComponent);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
