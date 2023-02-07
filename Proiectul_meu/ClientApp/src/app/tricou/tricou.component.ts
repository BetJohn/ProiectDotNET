import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Tricou } from '../models/Tricou';
import { TricouService } from '../services/tricou.service';

@Component({
  selector: 'app-tricou',
  templateUrl: './tricou.component.html',
  styleUrls: ['./tricou.component.css']
})
export class TricouComponent implements OnInit {
  public tricouri: Array<Tricou> = [];
  public tricouForm: FormGroup;

  constructor(private readonly TricouService: TricouService, private formBuilder: FormBuilder) {
    this.tricouForm = this.formBuilder.group({
      descriere: ['', Validators.required],
      culoare: ['', Validators.required],
      marime: ['', Validators.required],
      material: ['', Validators.required],
      pret: ['', Validators.required]
    });
}

  ngOnInit(): void {
    this.TricouService.getAllTricouri().subscribe(tricouri => {
      this.tricouri = tricouri;
    });
  }

  deleteTricou(id: string) {
    this.TricouService.deleteTricou(id).subscribe(() => { window.location = window.location; });
  }

  onSubmit() {
    this.TricouService.addTricou(this.tricouForm.value).subscribe(() => { window.location = window.location; });
  }
}
