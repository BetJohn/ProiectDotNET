import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Tricou } from '../models/Tricou';
import { ApiService } from './api.service';
@Injectable({
  providedIn: 'root'
})
export class TricouService {
  private readonly route = 'tricou'
  
  constructor(private readonly apiService: ApiService) { }
  getAllTricouri(): Observable<Array<Tricou>> {
    return this.apiService.get(this.route);
  }

  getTricouByid(id: string): Observable<Tricou> {
    return this.apiService.get(this.route + '/' + id);
  }
  
  addTricou(tricou: Tricou): Observable<Tricou> {
    return this.apiService.post(this.route + '/create', tricou);
  }
  
  updateTricou(tricou: Tricou): Observable<Tricou> {
    return this.apiService.post(this.route + '/update', tricou);
  }
  
  deleteTricou(id: string): Observable<Tricou> {
    return this.apiService.delete(this.route + '/' + id);
  }
}
