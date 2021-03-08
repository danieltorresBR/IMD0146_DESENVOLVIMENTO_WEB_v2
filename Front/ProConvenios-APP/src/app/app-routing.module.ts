import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { ConveniosComponent } from './convenios/convenios.component';

const routes: Routes = [
  { path: 'convenios', component: ConveniosComponent},
  { path: '', redirectTo: 'convenios', pathMatch: 'full'},
  { path: '**', redirectTo: 'convenios', pathMatch: 'full'}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
