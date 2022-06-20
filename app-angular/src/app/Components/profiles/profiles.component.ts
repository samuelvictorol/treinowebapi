import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-profiles',
  templateUrl: './profiles.component.html',
  styleUrls: ['./profiles.component.css']
})
export class ProfilesComponent implements OnInit {
  formulario: any
  tituloFormulario!: string

  constructor() { }

  ngOnInit() {
    this.tituloFormulario = 'Novo Profile';

      this.formulario = new  FormGroup({
      //forms controle são os inputs
      Nome: new FormControl(null),
      Cpf : new FormControl(null),
      Idade : new FormControl(null),
      Nascimento : new FormControl(null)
  })
  }

}
