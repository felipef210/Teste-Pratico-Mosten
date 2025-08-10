import { Component, inject, Input, numberAttribute, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FilmeSerieDTO } from '../../core/interfaces/filmeSerie';
import { FilmeService } from '../../core/services/filme.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-detalhes-filme',
  imports: [CommonModule],
  templateUrl: './detalhes-filme.component.html',
  styleUrl: './detalhes-filme.component.css'
})
export class DetalhesFilmeComponent implements OnInit {
  errorMsg: string | null = null;
  filmeSerie!: FilmeSerieDTO;

  private filmeService = inject(FilmeService);
  private route = inject(ActivatedRoute);

  ngOnInit() {
    const id = Number(this.route.snapshot.paramMap.get('id'));

    this.filmeService.getById(id).subscribe((filmeSerie: FilmeSerieDTO) => {
      this.filmeSerie = filmeSerie;
    });
  }

  curtirFilme() {
    this.errorMsg = null;
    this.filmeService.like(this.filmeSerie.id).subscribe({
      next: () => {
        window.location.reload();
      },
      error: () => {
        this.errorMsg = 'Erro ao curtir. Tente novamente.';
      }
    });
  }

  descurtirFilme() {
    this.errorMsg = null;
    this.filmeService.dislike(this.filmeSerie.id).subscribe({
      next: () => {
        window.location.reload();
      },
      error: () => {
        this.errorMsg = 'Erro ao descurtir. Tente novamente.';
      }
    });
  }
}
