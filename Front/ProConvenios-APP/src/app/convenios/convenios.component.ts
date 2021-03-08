import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-convenios',
  templateUrl: './convenios.component.html',
  styleUrls: ['./convenios.component.scss']
})
export class ConveniosComponent implements OnInit {

  public convenios: any = [];
  public conveniosFiltrados: any = [];
  private _filtroLista: string = '';

  public get filtroLista (){
    return this._filtroLista;
  }

  public set filtroLista (value: string) {
    this._filtroLista = value;
    this.conveniosFiltrados = this.filtroLista ? this.filtrarConvenios(this.filtroLista) : this.convenios;
  }

  filtrarConvenios(filtrarPor: string): any {
    filtrarPor = filtrarPor;
    return this.convenios.filter(
      convenio => convenio.processoTCE.indexOf(filtrarPor) !== -1
    );
  }

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getConvenios();
  }

  public getConvenios(): void {
    this.http.get('https://localhost:5001/api/Convenios').subscribe(
      response => {
        this.convenios = response;
        this.conveniosFiltrados = this.convenios;
      },
      error => console.log(error)
    );
  }
}
