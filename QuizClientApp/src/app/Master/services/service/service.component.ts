import { Component } from '@angular/core';


import { SharedModule } from '../../../theme/shared/shared.module';

import { NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';

@Component({
  selector: 'app-service',
  imports: [SharedModule, NgbDropdownModule],
  templateUrl: './service.component.html',
  styleUrl: './service.component.scss',
})
export class ServiceComponent {

}
