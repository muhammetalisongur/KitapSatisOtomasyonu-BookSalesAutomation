﻿using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }        

        public void Add(Category category)
        {
           _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public Category GetById(int id)
        {
          return  _categoryDal.GetById(x => x.ID == id);
            
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Update(Category category)
        {
           _categoryDal.Update(category);
        }
    }
}
