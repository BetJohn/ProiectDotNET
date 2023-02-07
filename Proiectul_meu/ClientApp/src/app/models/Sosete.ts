import { Trening } from "./Trening";

export interface Sosete {
  id?: string;
  descriere: string;
  culoare: string;
  marime: string;
  material: string;
  pret: number;
  scurte: boolean;
  diferite: boolean;
  treningId?: string;
  trening: Trening;
}
