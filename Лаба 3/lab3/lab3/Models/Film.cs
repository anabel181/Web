using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab3.Models
{
    public class Film
    {
        // ID фильма
        public int Id { get; set; }
        // Обожка
        public string Picture { get; set; }
        // Название
        public string Name { get; set; }
        // Режисcер
        public string Producer { get; set; }
        // Жанр
        public string Genre { get; set; }
        // Год производства
        public int Year { get; set; }
        // Рейтинг
        public int Rating { get; set; }
        // Описание
        public string Description { get; set; }
        
        
    }
}