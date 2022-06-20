import { Component, OnInit, NgModule } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  btnLogin = true
  h1 = 'Fazer Login';
  btn2 = 'Registre-se agora!'
  constructor() { }

  ngOnInit() {
  }

  Registrar(){
    this.btnLogin = !this.btnLogin;
      if(this.btnLogin == true){
        this.h1 = 'Fazer Login'
        this.btn2 = 'Registre-se agora!'
      }else{
        this.h1 = 'Registre-se Agora'
        this.btn2 = ' Voltar'
      }
  }
}
