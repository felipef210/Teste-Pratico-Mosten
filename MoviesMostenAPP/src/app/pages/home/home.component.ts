import { Component, inject } from '@angular/core';
import { FilmeSerieDTO } from '../../core/interfaces/filmeSerie';
import { CardFilmeComponent } from "../../shared/components/card-filme/card-filme.component";
import { FilmeService } from '../../core/services/filme.service';
import { FormBuilder, ReactiveFormsModule } from '@angular/forms';
import { debounce, debounceTime } from 'rxjs';

@Component({
  selector: 'app-home',
  imports: [CardFilmeComponent, ReactiveFormsModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  items: FilmeSerieDTO[] = [];
  totalAvaliacoes!: number;
  totalCurtidas!: number;
  totalDescurtidas!: number;

  private filmeService = inject(FilmeService);
  private formBuilder = inject(FormBuilder);

  form = this.formBuilder.group({
    search: ['']
  });

  constructor() {
    this.getRegistros();
    this.getTotalAvaliacoes();

    this.form.valueChanges.pipe(debounceTime(300)).subscribe((value) => {
      const searchTerm = value.search?.trim().toLowerCase();

      if (searchTerm) {
        this.filmeService.filtro(searchTerm).subscribe((response) => {
          this.items = response;
        });
      }

      else
        this.getRegistros();
    });
  }

  getRegistros() {
    this.filmeService.get().subscribe((response) => {
      this.items = response;
    });
  }

  getTotalAvaliacoes() {
    this.filmeService.getTotalAvaliacoes().subscribe((response) => {
      this.totalAvaliacoes = response;
    });

    this.filmeService.getTotalCurtidas().subscribe((response) => {
      this.totalCurtidas = response;
    });

    this.filmeService.getTotalDescurtidas().subscribe((response) => {
      this.totalDescurtidas = response;
    });
  }
}
