import { Trening } from "./Trening";
import { Tricou } from "./Tricou";

export interface TricouLaTrening {
  id: string;
  trening: Trening;
  tricou: Tricou;
}
