import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { UniversityService } from './services/university.service';
import { UniversityResponse } from './models/university-response.model';
import { Observable } from 'rxjs';
import { MatDialog } from '@angular/material/dialog';
import { UniversityCardDetalhesComponent } from './components/university-card-detalhes/university-card-detalhes.component';

@Component({
  selector: 'app-university',
  templateUrl: './university.page.html',
  styleUrls: ['./university.page.scss']
})
export class UniversityPage implements OnInit {

  universidadesBrasileiras$: Observable<UniversityResponse[]>
  @ViewChild('buscaUniversidade') buscaUniversidade: ElementRef;

  constructor(
    private universityService: UniversityService,
    private dialog: MatDialog
  ){}

  ngOnInit(): void {
      this.universidadesBrasileiras$ = this.universityService.getUniversidadesBrasileiras()
  }

  abrirCardDetalhes(universidade: UniversityResponse){
    this.dialog.open(UniversityCardDetalhesComponent, {
      data: universidade
    })
  }

  aplicarFocoInput(){
    this.buscaUniversidade.nativeElement.focus()
  }

  buscarUniversidades(){
    const filtro = this.buscaUniversidade.nativeElement.value
    this.universidadesBrasileiras$ = this.universityService.getUniversidadesBrasileiras(filtro)
  }

}
