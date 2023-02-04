import { Component, OnInit } from '@angular/core';
import { Bluza } from '../models/Bluza';
import { BluzaService } from '../services/bluza.service';
import { MatListModule } from '@angular/material/list';
@Component({
  selector: 'app-bluza',
  templateUrl: './bluza.component.html',
  styleUrls: ['./bluza.component.css']
})
export class BluzaComponent implements OnInit {
  public bluze: Array<Bluza> = [];

  constructor(private readonly BluzaService: BluzaService) { }

  ngOnInit(): void {
    this.BluzaService.getAllBluzari().subscribe(bluze => {
      this.bluze = bluze;
    });
  }

  deleteBluza(id: string) {
    this.BluzaService.deleteBluza(id).subscribe(() => { });
  }
}
