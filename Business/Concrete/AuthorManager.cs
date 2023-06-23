﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthorManager : IAuthorService
    {
        private readonly IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public void Add(Author author)
        {
            _authorDal.Add(author);
        }

        public void Delete(Author author)
        {
            _authorDal.Delete(author);
        }

        public List<Author> GetAll()
        {
            return _authorDal.GetAll();
        }

        public Author GetById(int id)
        {
            return _authorDal.GetById(x => x.ID == id);
        }

        public void Update(Author author)
        {
            _authorDal.Update(author);
        }

        public async Task<IEnumerable<Author>> GetAllAuthorsWithAddress(int pageNo)
        {
            return await _authorDal.GetAllAuthorsWithAddress(pageNo);
        }
    }
}
