import { RedeSocial } from './RedeSocial';
import { Lote } from "./Lote";
import { Palestrante } from './Palestrante';

export interface Evento {
  id: number;
  descricao: string;
  dataEvento?: Date;
  dataEventoCriaco?: Date;
  dataEventoAtualizacao?: Date;
  tema: string; 
  status: string; 
  imagemURL: string;
  telefone: string;
  email: string;  
}
