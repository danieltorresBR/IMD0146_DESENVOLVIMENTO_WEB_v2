import { Convenio } from './../models/Convenio';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable(
// { providedIn: 'root'}
)
export class ConvenioService {
  baseURL = 'https://localhost:5001/api/convenios';

  constructor(private http: HttpClient) { }

  public getEventos(): Observable<Convenio[]> {
    return this.http.get<Convenio[]>(this.baseURL);
  }

  public getEventoById(id: number): Observable<Convenio> {
    return this.http.get<Convenio>(`${this.baseURL}/${id}`);
  }
}
