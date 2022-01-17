using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab3.Models;

namespace lab3.Controllers
{
	public class HomeController : Controller
	{
		// создаем контекст данных
		FilmContext db = new FilmContext();

		public ActionResult Index()
		{
			// получаем из бд все объекты Films
			IEnumerable<Film> films = db.Films;
			// передаем все объекты в динамическое свойство Films в ViewBag
			ViewBag.Films = films;
			// возвращаем представление
			return View();
		}

		public ActionResult Review(int id)
		{
			IEnumerable<Review> reviews = db.Reviews.Where(a => a.FilmId == id);
			ViewBag.Name = db.Films.FirstOrDefault(p => p.Id == id).Name;
			ViewBag.Reviews = reviews;
			ViewBag.Id = id;
			return View();
		}

		[HttpGet]
		public ActionResult AddReview(int id)
		{
			ViewBag.FilmId = id;
			return View();
		}
		[HttpPost]
		public RedirectResult AddReview(Review review)
		{
			// добавляем информацию о покупке в базу данных
			db.Reviews.Add(review);
			// сохраняем в бд все изменения
			db.SaveChanges();
			return Redirect("/Home");
		}

		public RedirectResult DeleteReview(int id)
		{
			var s = db.Reviews.FirstOrDefault(p => p.ReviewId == id);

			db.Reviews.Remove(s);
			db.SaveChanges();

			return Redirect("/Home");
		}

		[HttpPost]
		public ActionResult GenreSearch(string genre)
		{
			var b = db.Films.Where(a => a.Genre.Contains(genre)).ToList();
			if (b.Count <= 0)
			{
				return HttpNotFound();
			}
			return PartialView(b);
		}

		[HttpGet]
		public ActionResult AddFilm()
		{
			//ViewBag.GameId = id;
			return View();
		}
		[HttpPost]
		public RedirectResult AddFilm(Film film)
		{
			// добавляем информацию о покупке в базу данных
			db.Films.Add(film);
			// сохраняем в бд все изменения
			db.SaveChanges();
			return Redirect("/Home");
		}


		public RedirectResult DeleteFilm(int id)
		{
			var s = db.Films.FirstOrDefault(p => p.Id == id);

			db.Films.Remove(s);
			db.SaveChanges();

			return Redirect("/Home");
		}
	}
}