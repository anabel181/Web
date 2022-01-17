using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace lab3.Models
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<FilmContext>
    {
        protected override void Seed(FilmContext db)
        {
            db.Films.Add(new Film { Name = "1+1", Picture = "Content/1+1.jpg", Producer = "Оливье Накаш, Эрик Толедано", Genre = "Комедия", Year = 2011, Rating = 88, Description = "Пострадав в результате несчастного случая, богатый аристократ Филипп нанимает в помощники человека, который менее всего подходит для этой работы, – молодого жителя предместья Дрисса, только что освободившегося из тюрьмы. Несмотря на то, что Филипп прикован к инвалидному креслу, Дриссу удается привнести в размеренную жизнь аристократа дух приключений." });
            db.Films.Add(new Film { Name = "Назад в будущее", Picture = "Content/back_to_the_future.jpg", Producer = "Роберт Земекис", Genre = "Фантастика", Year = 1985, Rating = 86, Description = "Подросток Марти с помощью машины времени, сооружённой его другом-профессором доком Брауном, попадает из 80-х в далекие 50-е. Там он встречается со своими будущими родителями, ещё подростками, и другом-профессором, совсем молодым." });
            db.Films.Add(new Film { Name = "Один дома", Picture = "Content/home_alone.jpg", Producer = "Крис Коламбус", Genre = "Комедия", Year = 1990, Rating = 82, Description = "Американское семейство отправляется из Чикаго в Европу, но в спешке сборов бестолковые родители забывают дома... одного из своих детей. Юное создание, однако, не теряется и демонстрирует чудеса изобретательности. И когда в дом залезают грабители, им приходится не раз пожалеть о встрече с милым крошкой." });
            
            base.Seed(db);
        }
    }
}