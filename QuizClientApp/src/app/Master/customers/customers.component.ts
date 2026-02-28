import { Component, OnInit } from '@angular/core';
import { SharedModule } from '../../theme/shared/shared.module';

import { NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';


@Component({
  selector: 'app-customers',
  imports: [SharedModule, NgbDropdownModule],
  templateUrl: './customers.component.html',
  styleUrl: './customers.component.scss',
})
export class CustomersComponent {
  constructor(private router: Router) { }
  create(): void {
    this.router.navigate(['app/customer']);
  }
}
