using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoMeditation.Controllers
{
    public class LocalesController : Controller
    {
		private MongoDatabase _mongo = new MongoDatabase("mongodb://benchris:PASSWORD@mongomeditation-shard-00-00-gj3ul.mongodb.net:27017,mongomeditation-shard-00-01-gj3ul.mongodb.net:27017,mongomeditation-shard-00-02-gj3ul.mongodb.net:27017/admin?ssl=true&replicaSet=MongoMeditation-shard-0&authSource=admin");
        
		public ActionResult Index()
        {
            return View ();
        }

        public ActionResult Details(int id)
        {
            return View ();
        }

        public ActionResult Create()
        {
            return View ();
        } 

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
			var model = new LocaleViewModel(
				collection.Get("name"),
				collection.Get("description"),
				collection.Get("location")
			);
            try {
				var db = _mongo.db();
				var mongoCollection = db.GetCollection<BsonDocument>("locales");
				mongoCollection.InsertOneAsync(model.toBsonDocument());
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
        
        public ActionResult Edit(int id)
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }

        public ActionResult Delete(int id)
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
    }
}