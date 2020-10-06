import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { RecommendationQuery, ArtistResult } from '../models/';
import { Observable, of } from 'rxjs';
@Injectable({
  providedIn: 'root'
})

export class ArtistRecommendationService {

    constructor(private http: HttpClient) { }
    readonly  apiUrl : string  = `https://localhost:5001/api/artists`;

    recommendArtist(query : RecommendationQuery) : Observable<ArtistResult> {
        return this.http.post<ArtistResult>(`${this.apiUrl}/recommendArtist`, query);
    }
}