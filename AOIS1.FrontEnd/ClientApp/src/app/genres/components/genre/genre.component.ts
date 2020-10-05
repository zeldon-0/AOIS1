import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import {GenreFetchService} from '../../services/genre-fetch.service';
import {Genre} from '../../models/genre';
import {MatCheckboxModule} from '@angular/material/checkbox';


@Component({
  selector: 'app-genre',
  templateUrl: './genre.component.html',
  styleUrls: ['./genre.component.css']
})
export class GenreComponent implements OnInit {

  constructor(private genreFetchService : GenreFetchService) { }

  public genres : Genre[];
  ngOnInit() {
    this.genreFetchService.getAll()
      .subscribe(
          genres => {
            this.genres = genres;
        }
      )
  }
  @Output() addedGenre = new EventEmitter<Genre>();

  emit(genre : Genre){
    this.addedGenre.emit(genre);
  }

}
