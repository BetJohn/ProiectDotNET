import { Component, OnInit } from '@angular/core';
import { TreningService } from '../services/trening.service';

@Component({
  selector: 'app-trening',
  templateUrl: './trening.component.html',
  styleUrls: ['./trening.component.css']
})
export class TreningComponent implements OnInit {

  constructor(private readonly TreningService: TreningService) { }

  ngOnInit(): void {
  }

}
