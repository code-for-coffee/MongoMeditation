using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoMeditation
{
	public class MongoDatabase
	{
		public MongoDatabase(string databaseName)
		{
			database = databaseName;
		}
		protected static IMongoClient _client = new MongoClient();
		protected static IMongoDatabase _db = _client.GetDatabase(database);
		public static string database { get; set; }
		public IMongoDatabase db()
		{
			return _db;
		}
	}
}
