import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import {NoveltyFetchService} from "../../services/novelty-fetch.service";
import {Novelty} from "../../models/novelty";

@Component({
  selector: 'app-novelty',
  templateUrl: './novelty.component.html',
  styleUrls: ['./novelty.component.css']
})
export class NoveltyComponent implements OnInit {

  constructor(private noveltyFetchService : NoveltyFetchService) { }

  public novelties : Novelty[];
  ngOnInit() {
    this.noveltyFetchService.getAll()
      .subscribe(
          novelties => {
            this.novelties = novelties;
        }
      )
  }

  @Output() addedNovelty = new EventEmitter<Novelty>();

  emit(novelty : Novelty){
    this.addedNovelty.emit(novelty);
  }

}
