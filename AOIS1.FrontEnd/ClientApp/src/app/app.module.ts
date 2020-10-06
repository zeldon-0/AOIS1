import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { GenreComponent } from './genres/index';
import { InstrumentComponent } from './instruments/components/genre/instrument.component';
import { TempoComponent } from './tempos/components/tempo/tempo.component';
import { NoveltyComponent } from './novelties/components/novelty/novelty.component';
import { ArtistRecommendationComponent } from './artists/components/artist-recommendation/artist-recommendation.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    GenreComponent,
    InstrumentComponent,
    TempoComponent,
    NoveltyComponent,
    ArtistRecommendationComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'genres', component: GenreComponent}
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
