import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent {
  public currentCount = 0;
  public tricouri: Tricou[] = [];

  public incrementCounter() {
    this.currentCount++;
  }
}

interface Tricou {

  Descriere: string;
  Culoare: string;
  Marime: string;
  Material: string;
  Pret: number;
}
