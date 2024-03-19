using CaloriProject.DAL.Repostory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriProject.BLL.Manager.Abstract
{
    public abstract class Manager<TEntity> where TEntity : class
    {
        protected IRepostory<TEntity> _repository;

        public void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public void Remove(TEntity entity)
        {
            _repository.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }




    }
}
