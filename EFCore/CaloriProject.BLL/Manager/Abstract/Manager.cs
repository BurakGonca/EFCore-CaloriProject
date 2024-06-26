﻿using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using CaloriProject.DAL.Repostory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CaloriProject.BLL.Manager.Abstract
{
    public abstract class Manager<TModel, TEntity, TMapperProfile> : IManager<TModel> where TModel : class
        where TEntity : class
        where TMapperProfile : Profile, new()
    {
        protected IMapper _mapper;
        protected IRepostory<TEntity> _repository;
        protected MapperConfiguration _config;


        public Manager()
        {

            //constructor'da mapper'ın configurasyonunu yapıyoruz.
            //nereden nereye eşleştireceğini belirliyoruz.
            //TModel dan TEntity'ye ve TEntity'den TModel'a eşleme yap diyoruz.
            _config = new MapperConfiguration(cfg =>
            {
                cfg.AddExpressionMapping().CreateMap<TModel, TEntity>().ReverseMap();
                cfg.AddProfile<TMapperProfile>();
            });


            _mapper = new Mapper(_config);
        }
        public void Add(TModel model)
        {
            //UI'dan gelen TModel'ı önce TEntity'ye eşleştirip çevirmemiz gerekli. TEntity'ye çevirince de IRepository kullanarak ekle.

            TEntity cevirilenEntity = _mapper.Map<TEntity>(model);
            _repository.Add(cevirilenEntity);
        }

        public void Delete(TModel model)
        {
            TEntity convertedEntity = _mapper.Map<TEntity>(model);
            _repository.Delete(convertedEntity);
        }

        public List<TModel> GetAll()
        {
            List<TEntity> EntitiesFromDb = _repository.GetAll().ToList();

            List<TModel> models = new List<TModel>();

            foreach (TEntity entity in EntitiesFromDb)
            {
                TModel model = _mapper.Map<TModel>(entity);
                models.Add(model);
            }

            return models;

        }

        public TModel GetById(int id)
        {
            TEntity entity = _repository.GetById(id);

            TModel model = _mapper.Map<TModel>(entity);

            return model;
        }

        public void Remove(TModel model)
        {
            TEntity cevirilenEntity = _mapper.Map<TEntity>(model);
            _repository.Remove(cevirilenEntity);
        }

        public List<TModel> Search(Expression<Func<TModel, bool>> predicate)
        {
            //önce hakiki ürünleri predicate'e göre (filtereye göre) getir.
            //sonra bu filtrelenmiş ürünleri kullanıcının muhattap olacağı model listesi olarak döndür.


            //daha da öncesinde metodan gelecek olan tmodel predicate'i de entity predicateine eşleştirmemiz gerekir.

            Expression<Func<TEntity, bool>> predicateEntities = _mapper.Map<Expression<Func<TEntity, bool>>>(predicate);

            //sonra bu tentity predicate ini kullanarak repository'nin search'ünü kullanacağız.
            //ve filtreli verileri TEntity cinsinden alacağız.

            //son olarak da bunu istenen şekle TModel listesine eşleştireceğiz.

            List<TEntity> filteredEntitiesFromDb = _repository.Search(predicateEntities).ToList();

            //şimdi de bu filtrelenmiş entitiy'ler içerisinden gezinerek hepsini TModel entity'ye çevirip listeye atalı ve döndürelim.

            List<TModel> models = new List<TModel>();

            foreach (TEntity entity in filteredEntitiesFromDb)
            {
                TModel model = _mapper.Map<TModel>(entity);
                models.Add(model);
            }

            return models;



        }

        public void Update(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repository.Update(entity);

        }

        //Bize bir de include'lar da yapılan get metodları gerekli.
        public List<TModel> GetAllWithIncludes(params string[] navigationProperties)
        {
            //önce repository'deki GetAllWithIncludes metodunu çağır
            //Ama çağırınca TEntity tipinde gelir tabi.
            //Bİz de bunu yine yukarıda yaptığımız gibi bu listeyi TModel listesine döndüreceğiz.

            List<TEntity> entities = _repository.GetAllWithIncludes(navigationProperties).ToList();

            List<TModel> models = _mapper.Map<List<TModel>>(entities);

            return models;
        }

        public List<TModel> GetAllWithIncludes()
        {
            //DAL dan gelenleri TModel listesine yukarıdaki gibi dönüştürecek

            List<TEntity> entities = _repository.GetAllWithIncludes().ToList();

            List<TModel> models = _mapper.Map<List<TModel>>(entities);

            return models;

        }




    }
}
