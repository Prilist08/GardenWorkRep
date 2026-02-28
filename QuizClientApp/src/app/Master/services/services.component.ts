import { Component, OnInit } from '@angular/core';
import { SharedModule } from '../../theme/shared/shared.module';

import { NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';

@Component({
  selector: 'app-services',
  imports: [SharedModule, NgbDropdownModule],
  templateUrl: './services.component.html',
  styleUrl: './services.component.scss',
})
export class ServicesComponent {
  constructor(private router: Router) { }
  create(): void {
    this.router.navigate(['app/customer']);
  }
}

