import { Component, inject } from '@angular/core';
import { FormFilmeComponent } from "../../shared/components/form-filme/form-filme.component";
import { CriarFilmeSerieDTO } from '../../core/interfaces/filmeSerie';
import { FilmeService } from '../../core/services/filme.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-criar-filme',
  imports: [FormFilmeComponent],
  templateUrl: './criar-filme.component.html',
  styleUrl: './criar-filme.component.css'
})
export class CriarFilmeComponent {
  private filmeService = inject(FilmeService);
  private router = inject(Router);

  onSubmit(dto: CriarFilmeSerieDTO) {
    this.filmeService.post(dto).subscribe({
      next: () => {
        this.router.navigate(['/'])
      },
      error: err => {
        console.error('Erro ao criar filme/serie', err);
      }
    });

  }
}
