using System;
using Norm;
using Norm.Collections;
using System.Linq;
using System.Configuration;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GARDIS.Models
{
	public class DataBase<T>
    	where T : ICollectable
	{
		public DataBase()
	    {
	        var connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
	        Mongo = (Mongo)Mongo.Create(connectionString);
            
	    }
	
	    private Mongo Mongo { get; set; }
        public void Dispose()
        {
            Mongo.Dispose();
        }
	    protected MongoCollection<T> Collection
	    {
	        get
	        {
	            return (MongoCollection<T>)Mongo.GetCollection<T>();
	        }
	    }
	
	    protected IQueryable<T> Query
	    {
	        get
	        {
	            return Collection.AsQueryable();
	        }
	    }
		public IQueryable<T> GetAll()
	    {
	        return Query;
	    }
	
	    public T Get(ObjectId id)
	    {
	        // Here's where ICollectable comes in handy!
            Func<T, bool> funct = (t) => t.Id == id;
            return Query.SingleOrDefault(funct) ;
	    }
	
	    internal void Update(T obj)
	    {
	        // Mongo and NoRM offer partial updates, but this is sufficient for our immediate purposes
	        Collection.Update(new { Id = obj.Id }, obj, false, false);
	    }
	
	    internal void Insert(T obj)
	    {
	        Collection.Insert(obj);
	    }
	
	    internal void Insert(IEnumerable<T> objs)
	    {
	        Collection.Insert(objs);
	    }
		internal void Delete(T obj)
	    {
	        Collection.Delete(obj);
	    }
		internal void Delete(IEnumerable<T> objs)
	    {
	        Collection.Delete(objs);
	    }
	}
}

