import { Component, OnInit } from '@angular/core';
import {InstrumentFetchService} from '../../services/instrument-fetch.service';
import {Instrument} from '../../models/instrument';
import {MatCheckboxModule} from '@angular/material/checkbox';


@Component({
  selector: 'app-instrument',
  templateUrl: './instrument.component.html',
  styleUrls: ['./instrument.component.css']
})
export class InstrumentComponent implements OnInit {

  constructor(private instrumentFetchService : InstrumentFetchService) { }

  public instruments : Instrument[];
  ngOnInit() {
    this.instrumentFetchService.getAll()
      .subscribe(
          instruments => {
            this.instruments = instruments;
        }
      )
  }

}
