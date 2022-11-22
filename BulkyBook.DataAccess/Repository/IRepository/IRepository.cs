using System;
using System.Linq.Expressions;

namespace BulkyBook.DataAccess.Repository.IRepository
{
	public interface IRepository<T> where T : class
	{
		//u => u.Name == "id"
		T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null);
		IEnumerable<T> GetAll(string? includeProperties = null);
		void Add(T entity);
		void Remove(T entity);
		void RemoveRange(IEnumerable<T> entity);
	}
}

