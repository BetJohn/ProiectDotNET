import { Component, OnInit } from '@angular/core';
import { Sosete } from '../models/Sosete'
import { SoseteService } from '../services/sosete.service';
import { MatListModule } from '@angular/material/list';
@Component({
  selector: 'app-sosete',
  templateUrl: './sosete.component.html',
  styleUrls: ['./sosete.component.css']
})
export class SoseteComponent implements OnInit {
  public sosete: Array<Sosete> = [];
  

  constructor(private readonly SoseteService: SoseteService) { }

  ngOnInit(): void {
    this.SoseteService.getAllSosete().subscribe(sosete => {
      this.sosete = sosete;
    });
  }
  deleteSosete(id: string) {
    this.SoseteService.deleteSosete(id).subscribe(() => {
      window.location = window.location
    });
  }
}
