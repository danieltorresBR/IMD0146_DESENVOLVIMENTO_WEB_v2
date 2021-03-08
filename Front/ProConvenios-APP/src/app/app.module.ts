import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

import { CollapseModule } from 'ngx-bootstrap/collapse';
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ConveniosComponent } from './convenios/convenios.component';
import { ContratosComponent } from './contratos/contratos.component';
import { NavComponent } from './nav/nav.component';
import { TituloComponent } from './titulo/titulo.component';
import { ConvenioService } from './services/convenio.service';




@NgModule({
  declarations: [
    AppComponent,
    ConveniosComponent,
    ContratosComponent,
    NavComponent,
    TituloComponent,
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    CollapseModule.forRoot(),
    FormsModule,
    TooltipModule.forRoot(),
    BsDropdownModule.forRoot()
  ],
  providers: [ConvenioService],
  bootstrap: [AppComponent]
})
export class AppModule { }
