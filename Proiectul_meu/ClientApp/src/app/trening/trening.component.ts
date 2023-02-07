import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Trening } from '../models/Trening';
import { TreningService } from '../services/trening.service';

@Component({
  selector: 'app-trening',
  templateUrl: './trening.component.html',
  styleUrls: ['./trening.component.css']
})
export class TreningComponent implements OnInit {
  public treninguri: Array<Trening> = [];
  public treningForm: FormGroup;

  constructor(private readonly TreningService: TreningService, private formBuilder: FormBuilder) {
    this.treningForm = this.formBuilder.group({
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
    this.TreningService.getAllTreningri().subscribe(trening => {
      this.treninguri = trening;
    });
  }

  deleteTrening(id: string | undefined) {
    if (id === null || id === undefined)
      return;
    this.TreningService.deleteTrening(id).subscribe(() => { window.location = window.location; });
  }

  onSubmit() {
    let trening: Trening = {
      bluza: {
        descriere: this.treningForm.value.descriereBluza,
        culoare: this.treningForm.value.culoareBluza,
        marime: this.treningForm.value.marimeBluza,
        material: this.treningForm.value.materialBluza,
        pret: this.treningForm.value.pretBluza,
        hoodie: this.treningForm.value.hoodieBluza
      },
      pantaloni: {
        descriere: this.treningForm.value.descrierePantaloni,
        culoare: this.treningForm.value.culoarePantaloni,
        marime: this.treningForm.value.marimePantaloni,
        material: this.treningForm.value.materialPantaloni,
        pret: this.treningForm.value.pretPantaloni,
        scurti: this.treningForm.value.scurtiPantaloni
      }
    }
    this.TreningService.addTrening(trening).subscribe(() => { window.location = window.location; });
  }
}
