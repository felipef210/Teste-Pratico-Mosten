import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { FilmeSerieDTO } from '../interfaces/filmeSerie';
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
}
