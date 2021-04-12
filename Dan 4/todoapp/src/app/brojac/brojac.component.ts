import { BrojacService } from './../Services/brojac.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-brojac',
  templateUrl: './brojac.component.html',
  styleUrls: ['./brojac.component.css']
})
export class BrojacComponent implements OnInit {

  title: string;
  brojac: number;

  brojevi: any[];

  constructor(private servis: BrojacService) { }

  ngOnInit(): void {
    this.title = 'Brojač';
    this.brojac = 0;

    this.brojevi = this.servis.getBrojevi();
  }

  /**
   * Povecava brojac
   */
  povecajBrojac(): void{
    this.brojac++;
  }
}
