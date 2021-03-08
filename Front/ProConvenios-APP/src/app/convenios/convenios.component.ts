import { Component, OnInit, TemplateRef } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { ToastrService } from 'ngx-toastr';
import { Convenio } from '../models/Convenio';
import { ConvenioService } from '../services/convenio.service';

@Component({
  selector: 'app-convenios',
  templateUrl: './convenios.component.html',
  styleUrls: ['./convenios.component.scss'],
  //providers: [ConvenioService]
})
export class ConveniosComponent implements OnInit {
  modalRef!: BsModalRef;
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

  constructor(private convenioService: ConvenioService,
              private modalService: BsModalService,
              private toastr: ToastrService
              ) { }

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

  openModal(template: TemplateRef<any>): void {
    this.modalRef = this.modalService.show(template, {class: 'modal-sm'});
  }

  confirm(): void {
    this.modalRef.hide();
    this.toastr.success('O Convenio foi deletado com Sucesso.', 'Deletado!');
  }

  decline(): void {
    this.modalRef.hide();
  }
}
