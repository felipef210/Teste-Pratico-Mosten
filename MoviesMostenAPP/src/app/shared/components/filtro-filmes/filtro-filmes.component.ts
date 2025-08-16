import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { debounceTime } from 'rxjs';
import { FiltroDTO } from '../../../core/interfaces/filtroDTO';

@Component({
  selector: 'app-filtro-filmes',
  templateUrl: './filtro-filmes.component.html',
  styleUrls: ['./filtro-filmes.component.css'],
  imports: [ReactiveFormsModule]
})
export class FiltroFilmesComponent {
  @Output() filtroChange = new EventEmitter<FiltroDTO>();

  formBuilder = inject(FormBuilder);

  form = this.formBuilder.group({
    search: [''],
    genero: [''],
    melhorAvaliacao: [false]
  });

  constructor() {
    this.form.valueChanges.pipe(debounceTime(300)).subscribe((value) => {
      const filtro: FiltroDTO = {
        titulo: value.search ?? '',
        genero: value.genero ?? '',
        topAvaliacoes: value.melhorAvaliacao ?? false
      };
      this.filtroChange.emit(filtro);
    });
  }
}
