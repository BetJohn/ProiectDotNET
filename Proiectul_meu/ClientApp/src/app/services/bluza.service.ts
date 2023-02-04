import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Bluza } from '../models/Bluza';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})
export class BluzaService {
  private readonly route = 'bluza'

  constructor(private readonly apiService: ApiService) { }
  getAllBluze(): Observable<Array<Bluza>> {
    return this.apiService.get(this.route);
  }

  getBluzaByid(id: string): Observable<Bluza> {
    return this.apiService.get(this.route + '/' + id);
  }

  addBluza(bluza: Bluza): Observable<Bluza> {
    return this.apiService.post(this.route, bluza);
  }

  updateBluza(bluza: Bluza): Observable<Bluza> {
    return this.apiService.post(this.route, bluza);
  }

  deleteBluza(id: string): Observable<Bluza> {
    return this.apiService.delete(this.route + '/' + id);
  }
}
