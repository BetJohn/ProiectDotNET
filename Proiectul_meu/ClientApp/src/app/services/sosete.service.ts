import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Sosete } from '../models/Sosete';
import { ApiService } from './api.service';
@Injectable({
  providedIn: 'root'
})
export class SoseteService {
  private readonly route = 'sosete'

  constructor(private readonly apiService: ApiService) { }
  getAllSoseteri(): Observable<Array<Sosete>> {
    return this.apiService.get(this.route);
  }

  getSoseteByid(id: string): Observable<Sosete> {
    return this.apiService.get(this.route + '/' + id);
  }

  addSosete(sosete: Sosete): Observable<Sosete> {
    return this.apiService.post(this.route, sosete);
  }

  updateSosete(sosete: Sosete): Observable<Sosete> {
    return this.apiService.post(this.route, sosete);
  }

  deleteSosete(id: string): Observable<Sosete> {
    return this.apiService.delete(this.route + '/' + id);
  }
}
