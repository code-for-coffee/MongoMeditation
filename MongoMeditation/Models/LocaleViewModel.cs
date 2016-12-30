using System;
using System.Threading.Tasks;
using MongoDB.Bson;


namespace MongoMeditation
{
	public class LocaleViewModel
	{
		public LocaleViewModel(string name, string description, string location)
		{
			this.name = name;
			this.description = description;
			this.location = location;
		}
		public string name { get; set; }
		public string description { get; set; }
		public string location { get; set; }

		public BsonDocument toBsonDocument()
		{
			return new BsonDocument
			{
				{ "name", this.name },
				{ "description", this.description },
				{ "location", this.location }

			};
		}
	}
}
