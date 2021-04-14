import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class BrojacService {

  constructor() { }

  /**
   * metoda koja vraća niz objekata brojeva
   * @returns niz ovbjakata brojeva
   */
  getBrojevi(): any[]{
    return [
      {broj: 1, slovima: 'jedan'},
      {broj: 2, slovima: 'dva'},
      {broj: 3, slovima: 'tri'},
      {broj: 4, slovima: 'cetiri'},
    ];
  }
}
