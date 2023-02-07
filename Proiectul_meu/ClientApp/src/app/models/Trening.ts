import { Bluza } from "./Bluza";
import { Pantaloni } from "./Pantaloni";
import { TricouLaTrening } from "./TricouLaTrening";

export interface Trening {
  id?: string;
  bluza: Bluza;
  bluzaId?: string;
  tricouri?: Array<TricouLaTrening>;
  pantaloni: Pantaloni;
}
