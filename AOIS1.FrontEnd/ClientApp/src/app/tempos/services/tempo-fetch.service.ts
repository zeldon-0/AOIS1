import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Tempo } from '../models/tempo';
import { Observable, of } from 'rxjs';
@Injectable({
  providedIn: 'root'
})

export class TempoFetchService {

    constructor(private http: HttpClient) { }
    readonly  apiUrl : string  = `https://localhost:5001/api/tempos`;

    getAll() : Observable<Tempo[]> {
        return this.http.get<Tempo[]>(`${this.apiUrl}/getAllTempos`);
    }
}