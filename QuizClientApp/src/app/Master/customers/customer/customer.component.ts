import { Component } from '@angular/core';


import { SharedModule } from '../../../theme/shared/shared.module';

import { NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';

@Component({
  selector: 'app-customer',
  imports: [SharedModule, NgbDropdownModule],
  templateUrl: './customer.component.html',
  styleUrl: './customer.component.scss',
})
export class CustomerComponent {

}
