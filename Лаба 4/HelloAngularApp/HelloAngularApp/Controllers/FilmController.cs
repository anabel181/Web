using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using HelloAngularApp.Models;

namespace HelloAngularApp.Controllers
{
    [ApiController]
    [Route("api/films")]
    public class FilmController : Controller
    {
        ApplicationContext db;
        public FilmController(ApplicationContext context)
        {
            db = context;
            
            if (!db.Films.Any())
            {
                db.Films.Add(new Film { Name = "1+1", Picture = "https://ia2.ru/storage/images/f327b07fe57fa80e6270dc2fb8a599e0.jpg", Producer = "Оливье Накаш, Эрик Толедано", Genre = "Комедия", Year = 2011, Rating = 88, Description = "Пострадав в результате несчастного случая, богатый аристократ Филипп нанимает в помощники человека, который менее всего подходит для этой работы, – молодого жителя предместья Дрисса, только что освободившегося из тюрьмы. Несмотря на то, что Филипп прикован к инвалидному креслу, Дриссу удается привнести в размеренную жизнь аристократа дух приключений." });
                db.Films.Add(new Film { Name = "Назад в будущее", Picture = "https://sun9-41.userapi.com/impf/c855132/v855132673/199d/IdB8-VMoE4k.jpg?size=320x480&quality=96&sign=3e7981c75b211e3c3206430292d8582f&c_uniq_tag=Z6yEaIgErf_6HrLzR1XEhxLOq1coaaw1pC4i-gWOwAg&type=album", Producer = "Роберт Земекис", Genre = "Фантастика", Year = 1985, Rating = 86, Description = "Подросток Марти с помощью машины времени, сооружённой его другом-профессором доком Брауном, попадает из 80-х в далекие 50-е. Там он встречается со своими будущими родителями, ещё подростками, и другом-профессором, совсем молодым." });
                db.Films.Add(new Film { Name = "Один дома", Picture = "https://sun9-81.userapi.com/impg/6XdLrBj_X3dfszrT7Lth2NmZ_O2oXuzttmq_nQ/STwfe9DpudQ.jpg?size=300x450&quality=96&sign=d3abf388a838352e6e352337a1ab8495&type=album", Producer = "Крис Коламбус", Genre = "Комедия", Year = 1990, Rating = 82, Description = "Американское семейство отправляется из Чикаго в Европу, но в спешке сборов бестолковые родители забывают дома... одного из своих детей. Юное создание, однако, не теряется и демонстрирует чудеса изобретательности. И когда в дом залезают грабители, им приходится не раз пожалеть о встрече с милым крошкой." });
                db.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<Film> Get()
        {
            return db.Films.ToList();
        }

        [HttpGet("{id}")]
        public Film Get(int id)
        {
            Film skin = db.Films.FirstOrDefault(x => x.Id == id);
            return skin;
        }

        [HttpPost]
        public IActionResult Post(Film film)
        {
            if (ModelState.IsValid)
            {
                db.Films.Add(film);
                db.SaveChanges();
                return Ok(film);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public IActionResult Put(Film film)
        {
            if (ModelState.IsValid)
            {
                db.Update(film);
                db.SaveChanges();
                return Ok(film);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Film film = db.Films.FirstOrDefault(x => x.Id == id);
            if (film != null)
            {
                db.Films.Remove(film);
                db.SaveChanges();
            }
            return Ok(film);
        }
    }
}
