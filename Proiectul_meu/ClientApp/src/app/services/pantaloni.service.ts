import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Pantaloni } from '../models/Pantaloni';
import { ApiService } from './api.service';
@Injectable({
  providedIn: 'root'
})
export class PantaloniService {
  private readonly route = 'pantaloni'

  constructor(private readonly apiService: ApiService) { }
  getAllPantaloniri(): Observable<Array<Pantaloni>> {
    return this.apiService.get(this.route);
  }

  getPantaloniByid(id: string): Observable<Pantaloni> {
    return this.apiService.get(this.route + '/' + id);
  }

  addPantaloni(Pantaloni: Pantaloni): Observable<Pantaloni> {
    return this.apiService.post(this.route + '/create', Pantaloni);
  }

  updatePantaloni(Pantaloni: Pantaloni): Observable<Pantaloni> {
    return this.apiService.post(this.route + '/update', Pantaloni);
  }

  deletePantaloni(id: string): Observable<Pantaloni> {
    return this.apiService.delete(this.route + '/' + id);
  }
}
