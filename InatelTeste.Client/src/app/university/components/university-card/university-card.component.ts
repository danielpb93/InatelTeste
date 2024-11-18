import { Component, Input } from '@angular/core';
import { UniversityResponse } from '../../models/university-response.model';

@Component({
  selector: 'app-university-card',
  templateUrl: './university-card.component.html',
  styleUrls: ['./university-card.component.scss']
})
export class UniversityCardComponent {
  @Input() universidade: UniversityResponse

}
