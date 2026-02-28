import { Component, OnInit } from '@angular/core';
import { SharedModule } from '../../theme/shared/shared.module';

import { NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';


@Component({
  selector: 'app-categorys',
  imports: [SharedModule, NgbDropdownModule],
  templateUrl: './categorys.component.html',
  styleUrl: './categorys.component.scss',
})
export class CategorysComponent {
 constructor(private router: Router) { }
  create(): void {
    this.router.navigate(['app/category']);
  }
}
