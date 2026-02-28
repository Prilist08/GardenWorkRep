import { Component } from '@angular/core';


import { SharedModule } from '../../../theme/shared/shared.module';

import { NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';
@Component({
  selector: 'app-supplier',
  imports: [SharedModule, NgbDropdownModule],
  templateUrl: './supplier.component.html',
  styleUrl: './supplier.component.scss',
})
export class SupplierComponent {

}
