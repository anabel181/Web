using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab3.Models
{
    public class Review
    {
        //ID обзора
        public int ReviewId { get; set; }
        //ID фильма
        public int FilmId { get; set; }
        //Имя
        public string Name { get; set; }
        //Почта
        public string Email { get; set; }
        //Текст обзора
        public string Text { get; set; }
    }
}