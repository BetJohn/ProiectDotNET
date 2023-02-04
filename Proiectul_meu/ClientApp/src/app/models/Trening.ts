import { Bluza } from "./Bluza";
import { Pantaloni } from "./Pantaloni";
import { TricouLaTrening } from "./TricouLaTrening";

export interface Trening {
  Id: string;
  Bluza: Bluza;
  BluzaId: string;
  Tricouri: Array<TricouLaTrening>;
  Pantaloni: Pantaloni;
}
