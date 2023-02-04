import { Component, OnInit } from '@angular/core';
import { PantaloniService } from '../services/pantaloni.service';

@Component({
  selector: 'app-pantaloni',
  templateUrl: './pantaloni.component.html',
  styleUrls: ['./pantaloni.component.css']
})
export class PantaloniComponent implements OnInit {

  constructor(private readonly PantaloniService: PantaloniService) { }

  ngOnInit(): void {
  }

}
