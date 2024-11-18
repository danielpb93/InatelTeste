import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UniversityRoutingModule } from './university.routing.module';
import { UniversityService } from './services/university.service';
import { UniversityCardComponent } from './components/university-card/university-card.component';
import { UniversityPage } from './university.page';
import { UniversityCardDetalhesComponent } from './components/university-card-detalhes/university-card-detalhes.component';
import { MatDialogModule } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { MatIconModule } from '@angular/material/icon';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';



@NgModule({
  declarations: [
    UniversityPage,
    UniversityCardComponent,
    UniversityCardDetalhesComponent
  ],
  imports: [
    CommonModule,
    UniversityRoutingModule,
    MatDialogModule,
    MatButtonModule,
    MatInputModule,
    MatIconModule,
    MatProgressSpinnerModule
  ],
  providers: [
    UniversityService
  ]
})
export class UniversityModule { }
