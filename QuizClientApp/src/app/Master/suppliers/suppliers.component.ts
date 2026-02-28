import { Component, OnInit } from '@angular/core';
import { SharedModule } from '../../theme/shared/shared.module';

import { NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';


@Component({
  selector: 'app-suppliers',
  imports: [SharedModule, NgbDropdownModule],
  templateUrl: './suppliers.component.html',
  styleUrl: './suppliers.component.scss',
})
export class SuppliersComponent {
  constructor(private router: Router) { }
  create(): void {
    this.router.navigate(['app/supplier']);
  }
}
