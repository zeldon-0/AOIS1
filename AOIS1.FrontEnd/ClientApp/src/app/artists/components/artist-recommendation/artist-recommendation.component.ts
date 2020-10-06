import { Component, OnInit, Input } from '@angular/core';
import { ArtistResult, RecommendationQuery } from "../../models";
import { ArtistRecommendationService } from "../../services/artist-recommendation.service";

@Component({
  selector: 'app-artist-recommendation',
  templateUrl: './artist-recommendation.component.html',
  styleUrls: ['./artist-recommendation.component.css']
})
export class ArtistRecommendationComponent implements OnInit {

  constructor(
    private recommendationService : ArtistRecommendationService
  ) { }

  @Input() public recommendationQuery : RecommendationQuery;

  public artistResult : ArtistResult;
  ngOnInit(): void {
  }

  public recommend(): void{
    this.recommendationService
      .recommendArtist(this.recommendationQuery).subscribe(
        artist => {
          this.artistResult = artist;
        }
      )
  }
}
