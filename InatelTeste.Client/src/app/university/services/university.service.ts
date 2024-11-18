import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { UniversityResponse } from '../models/university-response.model';
import { Observable } from 'rxjs';
import { environment } from 'src/app/environments/environment';

@Injectable()
export class UniversityService {

  constructor(private http: HttpClient) { }

  getUniversidadesBrasileiras(nomeUniversidade?: string): Observable<UniversityResponse[]>{
    let params = new HttpParams()

    if(nomeUniversidade)
      params = params.set('name', nomeUniversidade)
    

    return this.http.get<UniversityResponse[]>(environment.apiUrl + '/university/brazil', {params});
  }
}
