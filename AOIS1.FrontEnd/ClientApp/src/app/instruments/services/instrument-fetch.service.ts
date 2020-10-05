import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Instrument } from '../models/instrument';
import { Observable, of } from 'rxjs';
@Injectable({
  providedIn: 'root'
})

export class InstrumentFetchService {

    constructor(private http: HttpClient) { }
    readonly  apiUrl : string  = `https://localhost:5001/api/instruments`;

    getAll() : Observable<Instrument[]> {
        return this.http.get<Instrument[]>(`${this.apiUrl}/getAllInstruments`);
    }
}