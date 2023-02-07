/// <reference path="../sosete/sosete.component.ts" />
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Bluza } from '../models/Bluza';
import { BluzaService } from '../services/bluza.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-bluza',
  templateUrl: './bluza.component.html',
  styleUrls: ['./bluza.component.css']
})
export class BluzaComponent implements OnInit {
  public bluze: Array<Bluza> = [];
  public bluzaForm: FormGroup;

  constructor(private readonly BluzaService: BluzaService, private formBuilder: FormBuilder) {
    this.bluzaForm = this.formBuilder.group({
      descriere: ['', Validators.required],
      culoare: ['', Validators.required],
      marime: ['', Validators.required],
      material: ['', Validators.required],
      pret: ['', Validators.required],
      hoodie: [false]
    });
  }

  ngOnInit(): void {
    this.BluzaService.getAllBluze().subscribe(bluze => {
      this.bluze = bluze;
    });
  }

  deleteBluza(id: string | undefined) {
    if (id === null || id === undefined)
      return;
    this.BluzaService.deleteBluza(id).subscribe(() => { window.location = window.location; });
  }

  onSubmit() {
    this.BluzaService.addBluza(this.bluzaForm.value).subscribe(() => { window.location = window.location; });
  }
}
