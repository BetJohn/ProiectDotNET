import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Trening } from '../models/Trening';
import { ApiService } from './api.service';
@Injectable({
  providedIn: 'root'
})
export class TreningService {
  private readonly route = 'trening'

  constructor(private readonly apiService: ApiService) { }
  getAllTreningri(): Observable<Array<Trening>> {
    return this.apiService.get(this.route);
  }

  getTreningByid(id: string): Observable<Trening> {
    return this.apiService.get(this.route + '/' + id);
  }
  
  addTrening(trening: Trening): Observable<Trening> {
    return this.apiService.post(this.route, trening);
  }

  updateTrening(trening: Trening): Observable<Trening> {
    return this.apiService.post(this.route, trening);
  }

  deleteTrening(id: string): Observable<Trening> {
    return this.apiService.delete(this.route + '/' + id);
  }
}
