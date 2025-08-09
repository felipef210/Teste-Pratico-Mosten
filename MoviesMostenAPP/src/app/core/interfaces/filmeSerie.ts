export interface FilmeSerieDTO {
  id: number;
  titulo: string;
  genero: string;
  descricao: string;
  imagem: string;
  gostei: number;
  naoGostei: number;
}

export interface CriarFilmeSerieDTO {
  titulo: string;
  genero: string;
  descricao: string;
  imagem: string;
}
