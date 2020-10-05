import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Genre } from '../models/genre';
import { Observable, of } from 'rxjs';
@Injectable({
  providedIn: 'root'
})

export class GenreFetchService {

    constructor(private http: HttpClient) { }
    readonly  apiUrl : string  = `https://localhost:5001/api/genres`;

    getAll() : Observable<Genre[]> {
        return this.http.get<Genre[]>(`${this.apiUrl}/getAllGenres`);
    }
}