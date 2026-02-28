import { Component, OnInit } from '@angular/core';
import { SharedModule } from '../../theme/shared/shared.module';

import { NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';

@Component({
  selector: 'app-items',
  imports: [SharedModule, NgbDropdownModule],
  templateUrl: './items.component.html',
  styleUrl: './items.component.scss',
})
export class ItemsComponent {
  constructor(private router: Router) { }
  create(): void {
    this.router.navigate(['app/item']);
  }
}
