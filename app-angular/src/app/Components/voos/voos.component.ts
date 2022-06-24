import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-voos',
  templateUrl: './voos.component.html',
  styleUrls: ['./voos.component.css']
})
export class VoosComponent implements OnInit {

  passagens = [
    { empresa: 'Azul', ida: '10:05', volta: '11:45' },
    { empresa: 'Latam', ida: '10:05', volta: '11:45' },
    { empresa: 'Gol', ida: '10:05', volta: '11:45' },
    { empresa: 'Gol', ida: '10:05', volta: '11:45' },
    { empresa: 'Azul', ida: '10:05', volta: '11:45' },
    { empresa: 'Azul', ida: '10:05', volta: '11:45' },
    { empresa: 'Avianca', ida: '10:05', volta: '11:45' },
    { empresa: 'Latam', ida: '10:05', volta: '11:45' },
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
