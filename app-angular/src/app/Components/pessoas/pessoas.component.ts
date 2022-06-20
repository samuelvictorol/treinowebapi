import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-pessoas',
  templateUrl: './pessoas.component.html',
  styleUrls: ['./pessoas.component.css']
})
export class PessoasComponent implements OnInit {
  formulario: any
  tituloFormulario!: string

  constructor() { }

  ngOnInit() {
    this.tituloFormulario = 'Nova Pessoa';

      this.formulario = new  FormGroup({
      //forms controle são os inputs
      Nome: new FormControl(null),
      Cpf : new FormControl(null),
      Idade : new FormControl(null),
      Nascimento : new FormControl(null)
  })
  }

}
