import { Component } from '@angular/core';
import { RecommendationQuery } from "../artists/models/recommendation-query";
import { ArtistResult } from "../artists/models/artist-result";
import { Genre } from "../genres/models/genre";
import { Instrument } from "../instruments/models/instrument";
import { Tempo } from "../tempos/models/tempo";
import { Novelty } from "../novelties/models/novelty";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  public query : RecommendationQuery;
  constructor(){
     this.query = new RecommendationQuery();
  }
  public genresVisible : boolean = false;
  public instrumentsVisible : boolean = false;
  public noveltiesVisible : boolean = false;
  public temposVisible : boolean = false;
  
  onAddedGenre(genre : Genre){

    if (this.query.genres.some(g => g.id === genre.id)){

      this.query.genres = this.query.genres.filter( g => g.id != genre.id);
    }
    else{
      this.query.genres.push(genre);
    }
  }

  onAddedInstrument(instrument : Instrument){

    if (this.query.instruments.some(i => i.id === instrument.id)){

      this.query.instruments = this.query.instruments.filter( i => i.id != instrument.id);
    }
    else{
      this.query.instruments.push(instrument);
    }
    
  }
  onAddedTempo(tempo : Tempo){

    if (this.query.tempos.some(t => t.id === tempo.id)){

      this.query.tempos = this.query.tempos.filter( t => t.id != tempo.id);
    }
    else{
      this.query.tempos.push(tempo);
    }
    
  }
  onAddedNovelty(novelty : Novelty){

    if (this.query.novelties.some(n => n.id === novelty.id)){

      this.query.novelties = this.query.novelties.filter( n => n.id != novelty.id);
    }
    else{
      this.query.novelties.push(novelty);
    }
    
  }
}
