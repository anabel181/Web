import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Film } from './film';

@Injectable()
export class DataService {

    private url = "/api/films";

    constructor(private http: HttpClient) {
    }

    getFilms() {
        return this.http.get(this.url);
    }

    getFilm(id: number) {
        return this.http.get(this.url + '/' + id);
    }

    createFilm(film: Film) {
        return this.http.post(this.url, film);
    }
    updateFilm(film: Film) {

        return this.http.put(this.url, film);
    }
    deleteFilm(id: number) {
        return this.http.delete(this.url + '/' + id);
    }
}