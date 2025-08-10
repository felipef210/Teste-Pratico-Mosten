import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { CriarFilmeSerieDTO, FilmeSerieDTO } from '../interfaces/filmeSerie';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FilmeService {
  private http = inject(HttpClient);
  private readonly url = environment.apiURL + '/api/FilmeSerie'

  constructor() { }

  public get(): Observable<FilmeSerieDTO[]> {
    return this.http.get<FilmeSerieDTO[]>(this.url);
  }

  public getById(id: number): Observable<FilmeSerieDTO> {
    return this.http.get<FilmeSerieDTO>(`${this.url}/${id}`);
  }

  public post(filmeSerie: CriarFilmeSerieDTO): Observable<FilmeSerieDTO> {
    return this.http.post<FilmeSerieDTO>(this.url, filmeSerie);
  }

  public like(id: number) {
    return this.http.post(`${this.url}/like/${id}`, {});
  }

  public dislike(id: number) {
    return this.http.post(`${this.url}/dislike/${id}`, {});
  }

  public getTotalAvaliacoes(): Observable<number> {
    return this.http.get<number>(`${this.url}/total-votos`);
  }

  public getTotalCurtidas(): Observable<number> {
    return this.http.get<number>(`${this.url}/votos-positivos`);
  }

  public getTotalDescurtidas(): Observable<number> {
    return this.http.get<number>(`${this.url}/votos-negativos`);
  }

  public filtro(titulo: string): Observable<FilmeSerieDTO[]> {
    return this.http.get<FilmeSerieDTO[]>(`${this.url}/filtro`, { params: { titulo } });
  }
}
