import { Trening } from "./Trening";

export interface Sosete {
  Id: string;
  Descriere: string;
  Culoare: string;
  Marime: string;
  Material: string;
  Pret: number;
  Scurte: boolean;
  Diferite: boolean;
  TreningId: string;
  Trening: Trening;
}
