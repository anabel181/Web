import { Component, OnInit } from '@angular/core';
import { DataService } from './data.service';
import { Film } from './film';

@Component({
    selector: 'app',
    templateUrl: './app.component.html',
    providers: [DataService]
})
export class AppComponent implements OnInit {

    film: Film = new Film();   // изменяемый товар
    films: Film[];                // массив товаров
    tableMode: boolean = true;          // табличный режим

    constructor(private dataService: DataService) {}

    ngOnInit() {
        this.loadFilms();    // загрузка данных при старте компонента  
    }
    // получаем данные через сервис
    loadFilms() {
        this.dataService.getFilms()
            .subscribe((data: Film[]) => this.films = data);
    }
    // сохранение данных
    save() {
        if (this.film.id == null) {
            this.dataService.createFilm(this.film)
                .subscribe((data: Film) => this.films.push(data));
        } else {
            this.dataService.updateFilm(this.film)
                .subscribe(data => this.loadFilms());
        }
        this.cancel();
    }
    editFilm(p: Film) {
        this.film = p;
    }
    cancel() {
        this.film = new Film();
        this.tableMode = true;
    }
    delete(p: Film) {
        this.dataService.deleteFilm(p.id)
            .subscribe(data => this.loadFilms());
    }
    add() {
        this.cancel();
        this.tableMode = false;
    }
}