import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-convenios',
  templateUrl: './convenios.component.html',
  styleUrls: ['./convenios.component.scss']
})
export class ConveniosComponent implements OnInit {

  public convenios: any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getConvenios();
  }

  public getConvenios(): void {
    this.http.get('https://localhost:5001/api/Convenios').subscribe(
      response => this.convenios = response,
      error => console.log(error)
    );
  }
}
