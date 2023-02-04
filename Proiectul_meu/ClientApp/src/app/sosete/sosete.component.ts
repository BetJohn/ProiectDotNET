import { Component, OnInit } from '@angular/core';
import { SoseteService } from '../services/sosete.service';

@Component({
  selector: 'app-sosete',
  templateUrl: './sosete.component.html',
  styleUrls: ['./sosete.component.css']
})
export class SoseteComponent implements OnInit {

  constructor(private readonly SoseteService: SoseteService) { }

  ngOnInit(): void {
  }

}
