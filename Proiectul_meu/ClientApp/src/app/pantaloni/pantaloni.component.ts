import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Pantaloni } from '../models/Pantaloni';
import { PantaloniService } from '../services/pantaloni.service';

@Component({
  selector: 'app-pantaloni',
  templateUrl: './pantaloni.component.html',
  styleUrls: ['./pantaloni.component.css']
})
export class PantaloniComponent implements OnInit {
  public pantaloni: Array<Pantaloni> = [];
  public pantaloniForm: FormGroup;

  constructor(private readonly PantaloniService: PantaloniService, private formBuilder: FormBuilder) {
    this.pantaloniForm = this.formBuilder.group({
      descriere: ['', Validators.required],
      culoare: ['', Validators.required],
      marime: ['', Validators.required],
      material: ['', Validators.required],
      pret: ['', Validators.required],
      scurti: [false]
    });
}

  ngOnInit(): void {
    this.PantaloniService.getAllPantaloniri().subscribe(pantaloni => {
      this.pantaloni = pantaloni;
    });
  }

  deletePantaloni(id: string | undefined) {
    if (id === null || id === undefined)
      return;
    this.PantaloniService.deletePantaloni(id).subscribe(() => { window.location = window.location; });
  }

  onSubmit() {
    this.PantaloniService.addPantaloni(this.pantaloniForm.value).subscribe(() => { window.location = window.location; });
  }
}
