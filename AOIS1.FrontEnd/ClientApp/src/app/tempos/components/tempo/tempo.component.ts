import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { Tempo } from '../../models/tempo';
import {  TempoFetchService } from '../../services/tempo-fetch.service';
@Component({
  selector: 'app-tempo',
  templateUrl: './tempo.component.html',
  styleUrls: ['./tempo.component.css']
})
export class TempoComponent implements OnInit {


  constructor(private tempoFetchService : TempoFetchService) { }

  public tempos : Tempo[];

  ngOnInit() {
    this.tempoFetchService.getAll()
      .subscribe(
          tempos => {
            this.tempos = tempos;
        }
      )
  }

  @Output() addedTempo = new EventEmitter<Tempo>();

  emit(tempo : Tempo){
    this.addedTempo.emit(tempo);
  }

}
