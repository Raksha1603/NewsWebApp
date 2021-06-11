using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsWebApp.Models.Repository;

namespace NewsWebApp.Models.DataManager
{
    public class CategoryManager : IdRepository<News_Category>
    {
        readonly NewsWebAppContext db;

        public CategoryManager (NewsWebAppContext context)
        {
            db = context;
        }

        public IEnumerable<News_Category> GetAll()
        {
            return db.news_Categories.ToList();
        }

        public News_Category Get(string id)
        {
            return db.news_Categories.FirstOrDefault(e => e.CatID == id);
        }

        public void Add(News_Category newscat)
        {
            db.news_Categories.Add(newscat);
            db.SaveChanges();
            
        }

        public void Update(News_Category newscat, News_Category newscaategory)
        {
            newscaategory.CatID = newscat.CatID;
            newscaategory.Category = newscat.Category;
            newscaategory.Type = newscat.Type;

            db.SaveChanges();

           
        }

        public void Delete(News_Category newscat)
        {
            db.news_Categories.Remove(newscat);
            db.SaveChanges();
        }


    }
}
