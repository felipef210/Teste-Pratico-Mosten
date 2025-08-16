import { Component, inject } from '@angular/core';
import { FilmeSerieDTO } from '../../core/interfaces/filmeSerie';
import { CardFilmeComponent } from "../../shared/components/card-filme/card-filme.component";
import { FilmeService } from '../../core/services/filme.service';
import { FormBuilder, ReactiveFormsModule } from '@angular/forms';
import { debounceTime } from 'rxjs';
import { ModalComponent } from "../../shared/components/modal/modal.component";
import { FiltroFilmesComponent } from '../../shared/components/filtro-filmes/filtro-filmes.component';
import { FiltroDTO } from '../../core/interfaces/filtroDTO';

@Component({
  selector: 'app-home',
  imports: [CardFilmeComponent, ReactiveFormsModule, ModalComponent, FiltroFilmesComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  items: FilmeSerieDTO[] = [];
  isModalOpen: boolean = false;
  totalAvaliacoes!: number;
  totalCurtidas!: number;
  totalDescurtidas!: number;
  errorMsg: string | null = null;

  private filmeService = inject(FilmeService);


  constructor() {
    this.getRegistros();
    this.getTotalAvaliacoes();
  }

  getRegistros() {
    this.filmeService.get().subscribe((response) => {
      this.items = response;
    });
  }

  filtro(filtro: FiltroDTO) {
    this.filmeService.filtro(filtro).subscribe((response) => {
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

  resetarVotos() {
    this.filmeService.resetVotos().subscribe({
      next: () => {
        this.isModalOpen = false;
        window.location.reload();
      },
      error: () => {
        this.errorMsg = 'Erro ao resetar os votos, tente novamente.';
      }
    })
  }
}
