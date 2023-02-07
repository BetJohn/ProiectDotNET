import { Component, OnInit } from '@angular/core';
import { Sosete } from '../models/Sosete'
import { SoseteService } from '../services/sosete.service';
import { MatListModule } from '@angular/material/list';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Trening } from '../models/Trening';
@Component({
  selector: 'app-sosete',
  templateUrl: './sosete.component.html',
  styleUrls: ['./sosete.component.css']
})
export class SoseteComponent implements OnInit {
  public sosete: Array<Sosete> = [];
  public soseteForm: FormGroup;

  constructor(private readonly SoseteService: SoseteService, private formBuilder: FormBuilder) {
    this.soseteForm = this.formBuilder.group({
      descriere: ['', Validators.required],
      culoare: ['', Validators.required],
      marime: ['', Validators.required],
      material: ['', Validators.required],
      pret: ['', Validators.required],
      scurte: [false],
      diferite: [false],
      descriereBluza: ['', Validators.required],
      culoareBluza: ['', Validators.required],
      marimeBluza: ['', Validators.required],
      materialBluza: ['', Validators.required],
      pretBluza: ['', Validators.required],
      hoodieBluza: [false],
      descrierePantaloni: ['', Validators.required],
      culoarePantaloni: ['', Validators.required],
      marimePantaloni: ['', Validators.required],
      materialPantaloni: ['', Validators.required],
      pretPantaloni: ['', Validators.required],
      scurtiPantaloni: [false]
    });
}

  ngOnInit(): void {
    this.SoseteService.getAllSosete().subscribe(sosete => {
      this.sosete = sosete;
    });
  }
  deleteSosete(id: string | undefined) {
    if (id === null || id === undefined)
      return;
    this.SoseteService.deleteSosete(id).subscribe(() => {
      window.location = window.location
    });
  }

  onSubmit() {
    let sosete: Sosete = {
      descriere: this.soseteForm.value.descriere,
      culoare: this.soseteForm.value.culoare,
      marime: this.soseteForm.value.marime,
      material: this.soseteForm.value.material,
      pret: this.soseteForm.value.pret,
      scurte: this.soseteForm.value.scurte,
      diferite: this.soseteForm.value.diferite,
      trening: {
        bluza: {
          descriere: this.soseteForm.value.descriereBluza,
          culoare: this.soseteForm.value.culoareBluza,
          marime: this.soseteForm.value.marimeBluza,
          material: this.soseteForm.value.materialBluza,
          pret: this.soseteForm.value.pretBluza,
          hoodie: this.soseteForm.value.hoodieBluza
        },
        pantaloni: {
          descriere: this.soseteForm.value.descrierePantaloni,
          culoare: this.soseteForm.value.culoarePantaloni,
          marime: this.soseteForm.value.marimePantaloni,
          material: this.soseteForm.value.materialPantaloni,
          pret: this.soseteForm.value.pretPantaloni,
          scurti: this.soseteForm.value.scurtiPantaloni
        }
      }
    };

    this.SoseteService.addSosete(sosete).subscribe(() => { window.location = window.location; });
  }
}
