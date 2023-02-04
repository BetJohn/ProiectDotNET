import { Component, OnInit } from '@angular/core';
import { TricouService } from '../services/tricou.service';

@Component({
  selector: 'app-tricou',
  templateUrl: './tricou.component.html',
  styleUrls: ['./tricou.component.css']
})
export class TricouComponent implements OnInit {

  constructor(private readonly TricouService: TricouService) { }

  ngOnInit(): void {
  }

}
