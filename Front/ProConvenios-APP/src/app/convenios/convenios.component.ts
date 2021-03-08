import { Component, OnInit } from '@angular/core';
import { Convenio } from '../models/Convenio';
import { ConvenioService } from '../services/convenio.service';

@Component({
  selector: 'app-convenios',
  templateUrl: './convenios.component.html',
  styleUrls: ['./convenios.component.scss'],
  //providers: [ConvenioService]
})
export class ConveniosComponent implements OnInit {

  public convenios: Convenio[] = [];
  public conveniosFiltrados: Convenio[] = [];
  private filtroListagem = '';

  public get filtroLista(): string {
    return this.filtroListagem;
  }

  public set filtroLista(value: string) {
    this.filtroListagem = value;
    this.conveniosFiltrados = this.filtroLista ? this.filtrarConvenios(this.filtroLista) : this.convenios;
  }

  public filtrarConvenios(filtrarPor: string): Convenio[] {
    filtrarPor = filtrarPor;
    return this.convenios.filter(
      convenio => convenio.processoTCE.indexOf(filtrarPor) !== -1
    );
  }

  constructor(private convenioService: ConvenioService) { }

  ngOnInit(): void {
    this.getConvenios();
  }

  public getConvenios(): void {
    this.convenioService.getConvenios().subscribe({
      next: (convenios: Convenio[]) => {
        this.convenios = convenios;
        this.conveniosFiltrados = this.convenios;
      },
      error: (error: any) => console.log(error)
      });
  }
}
