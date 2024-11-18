import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UniversityRoutingModule } from './university.routing.module';
import { UniversityService } from './services/university.service';
import { UniversityCardComponent } from './components/university-card/university-card.component';
import { UniversityPage } from './university.page';
import { UniversityCardDetalhesComponent } from './components/university-card-detalhes/university-card-detalhes.component';
import { MatDialogModule } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';



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
    MatButtonModule
  ],
  providers: [
    UniversityService
  ]
})
export class UniversityModule { }
