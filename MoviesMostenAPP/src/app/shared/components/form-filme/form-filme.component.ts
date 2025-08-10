
import { Component, EventEmitter, inject, Output } from '@angular/core';
import { FormBuilder, ReactiveFormsModule, Validators, FormArray, FormControl } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { CriarFilmeSerieDTO } from '../../../core/interfaces/filmeSerie';

@Component({
  selector: 'app-form-filme',
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './form-filme.component.html',
  styleUrl: './form-filme.component.css'
})
export class FormFilmeComponent {
  private formBuilder = inject(FormBuilder);

  @Output()
  criarFilme = new EventEmitter<CriarFilmeSerieDTO>();

  form = this.formBuilder.group({
    titulo: ['', Validators.required],
    descricao: [''],
    urlImagem: ['', Validators.required],
    genero: this.formBuilder.array([], Validators.required),
    generoInput: ['']
  });

  isTituloFocused: boolean = false;
  isImagemFocused: boolean = false;
  isGeneroFocused: boolean = false;

  get generoInputControl() {
    return this.form.get('generoInput') as FormControl;
  }

  get generos() {
    return this.form.get('genero') as FormArray;
  }

  addGenero() {
    const input = this.form.get('generoInput') as FormControl;
    const value = input?.value?.trim();
    if (value) {
      this.generos.push(this.formBuilder.control(value));
      input?.reset();
    }
  }

  removeGenero(index: number) {
    this.generos.removeAt(index);
  }

  removeAllGeneros() {
    this.generos.clear();
  }

  onSubmit() {
    if (this.form.valid) {
      const campos: CriarFilmeSerieDTO = {
        titulo: this.form.value.titulo!,
        descricao: this.form.value.descricao || '',
        imagem: this.form.value.urlImagem!,
        genero: this.form.value.genero! as string[]
      };

      this.criarFilme.emit(campos);
    }

    else {
      console.log('Formulário inválido');
    }
  }
}
