﻿

using ApplicationTibiDatas.Contexts;
using System.Linq.Expressions;

namespace ApplicationTibiDatas.Repositories;

internal class Repo<TEntity> where TEntity : class
{
    private readonly DataContext _context;

    public Repo(DataContext context)
    {
        _context = context;
    }

    public virtual TEntity Create (TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
        _context.SaveChanges();
        return entity;
    }

    public virtual IEnumerable <TEntity> GetEverything()
    {
        return _context.Set<TEntity>().ToList();
        
    }
    public virtual TEntity Get (Expression<Func<TEntity, bool >> expression) 
    {
        var entity = _context.Set<TEntity>().FirstOrDefault(expression);
        return entity!;
    }

    public virtual TEntity Update (Expression<Func<TEntity, bool>> expression ,TEntity entity)
    {
        var entityToUpdate = _context.Set<TEntity>().FirstOrDefault(expression);
        _context.Entry(entityToUpdate!).CurrentValues.SetValues(entity);

        _context.SaveChanges();

        return entityToUpdate!;
    }
    public virtual void Delete(Expression<Func<TEntity, bool>> expression)
    {
        var entity = _context.Set<TEntity>().FirstOrDefault(expression);
        _context.Remove(entity!);
        _context.SaveChanges();
       
    }
}
