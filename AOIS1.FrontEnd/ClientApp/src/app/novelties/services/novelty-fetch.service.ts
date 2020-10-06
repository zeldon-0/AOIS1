import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Novelty } from '../models/novelty';
import { Observable, of } from 'rxjs';
@Injectable({
  providedIn: 'root'
})

export class NoveltyFetchService {

    constructor(private http: HttpClient) { }
    readonly  apiUrl : string  = `https://localhost:5001/api/novelties`;

    getAll() : Observable<Novelty[]> {
        return this.http.get<Novelty[]>(`${this.apiUrl}/getAllNovelties`);
    }
}