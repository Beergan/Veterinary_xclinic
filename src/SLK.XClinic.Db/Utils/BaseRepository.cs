using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SLK.XClinic.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SLK.XClinic.Db;

public class BaseRepository<T> : IRepository<T> where T : class
{
    protected readonly Func<IDbContext> _dbFactory;

    private IDbContext _dbContext;
    protected DbSet<T> DbSet => _dbContext.Set<T>();

    public BaseRepository(IDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public virtual IQueryable<T> Query()
    {
        return DbSet.AsNoTracking();
    }

    public virtual IQueryable<T> Query(Expression<Func<T, bool>> filter)
    {
        return DbSet.AsNoTracking().Where(filter);
    }

    public virtual async Task<bool> Exists(Expression<Func<T, bool>> filter)
    {
        return await this.Query().AnyAsync(filter);
    }

    public virtual async Task<bool> NotExists(Expression<Func<T, bool>> filter)
    {
        return !await this.Query().AnyAsync(filter);
    }

    public virtual async Task<T> GetOne()
    {
        return await this.Query().FirstOrDefaultAsync();
    }

    public async Task<T> GetOne(Expression<Func<T, bool>> filter)
    {
        return await this.Query().Where(filter).FirstOrDefaultAsync();
    }

    public virtual IQueryable<T> QueryEdit(Expression<Func<T, bool>> filter)
    {
        return DbSet.Where(filter);
    }

    public async Task<T> GetOneEdit(Expression<Func<T, bool>> filter)
    {
        return await this.DbSet.Where(filter).FirstOrDefaultAsync();
    }

    public virtual async Task<T> GetOne(object id)
    {
        var entity = await DbSet.FindAsync(id);
        //_dbContext.Entry(entity).State = EntityState.Detached;

        return await Task.FromResult<T>(entity);
    }

    public async Task<IList<T>> GetList()
    {
        return await this.Query().ToListAsync();
    }

    public async Task<IList<T>> GetList(Expression<Func<T, bool>> filter)
    {
        return await this.Query(filter).ToListAsync();
    }

    public virtual async Task Insert(T entity, bool commit = true)
    {
        await DbSet.AddAsync(entity);

        if (commit)
        {
            await _dbContext.SaveChangesAsync();
            //_dbContext.Entry(entity).State = EntityState.Detached;
        }
    }

    public virtual async Task InsertRange(params T[] entities)
    {
        DbSet.AddRange(entities);
        await _dbContext.SaveChangesAsync();

        //foreach (var entity in entities)
        //    _dbContext.Entry(entity).State = EntityState.Detached;
    }

    public virtual async Task Update(T entity, bool commit = true)
    {
        var idProperty = typeof(T).GetProperty("Id");
        var entityId = idProperty?.GetValue(entity);

        var existingEntity = await DbSet.FindAsync(entityId);

        if (existingEntity != null)
        {
            // Đảm bảo entity không bị theo dõi trước khi cập nhật
            _dbContext.Entry(existingEntity).State = EntityState.Detached;

            // Cập nhật toàn bộ giá trị
            _dbContext.Entry(existingEntity).CurrentValues.SetValues(entity);
            _dbContext.Entry(existingEntity).State = EntityState.Modified;
        }

        if (commit)
        {
            await _dbContext.SaveChangesAsync();

            // Detach entity sau khi lưu để tránh lỗi tracking
            _dbContext.Entry(entity).State = EntityState.Detached;
        }
    }

    //public virtual async Task UpdateList(List<T> listEntity, bool commit = true)
    //{
    //    foreach (var entity in listEntity.DefaultIfEmpty())
    //    {
    //        var idProperty = typeof(T).GetProperty("Id");
    //        var entityId = idProperty?.GetValue(entity);

    //        var existingEntity = await DbSet.FindAsync(entityId);

    //        if (existingEntity != null)
    //        {
    //            _dbContext.Entry(existingEntity).CurrentValues.SetValues(entity);
    //        }
    //        else
    //        {
    //            DbSet.Attach(entity);
    //            _dbContext.Entry(entity).State = EntityState.Modified;
    //        }

    //        if (commit)
    //        {
    //            await _dbContext.SaveChangesAsync();
    //            _dbContext.Entry(entity).State = EntityState.Detached;
    //        }
    //    }
    //}

    public virtual async Task Remove(T entity, bool commit = true)
    {
        if (_dbContext.Entry(entity).State == EntityState.Detached)
        {
            DbSet.Attach(entity);
        }

        DbSet.Remove(entity);

        if (commit)
        {
            await _dbContext.SaveChangesAsync();
            //_dbContext.Entry(entity).State = EntityState.Detached;
        }
    }

    public EntityEntry Attach(T entity)
    {
        return DbSet.Attach(entity);
    }
}