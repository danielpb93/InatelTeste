import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { UniversityResponse } from '../../models/university-response.model';

@Component({
  selector: 'app-university-card-detalhes',
  templateUrl: './university-card-detalhes.component.html',
  styleUrls: ['./university-card-detalhes.component.scss']
})
export class UniversityCardDetalhesComponent {
  constructor(
    private dialogRef: MatDialogRef<UniversityCardDetalhesComponent>,
    @Inject(MAT_DIALOG_DATA) public data: UniversityResponse
  ){}

  fechar(){
    this.dialogRef.close()
  }
}
