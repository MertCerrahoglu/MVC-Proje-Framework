﻿using BusinessLayer.Abstract;
using DateAccessLayer.Abstrack;
using DateAccessLayer.Concrete.Ropositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal=categorydal;
        }

        public void CategoryAdd(Category category)
        {
            _categorydal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
           _categorydal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categorydal.Update(category);
        }

        public Category GetByID(int id)
        {
           return _categorydal.Get(x => x.CategoryID== id);
        }

        public List<Category> GetList()
        {
            return _categorydal.List();
        }
        



        // GenericRepository<Category> repo = new GenericRepository<Category>();

        //public List<Category> GetAllBL()
        //{
        //    return repo.List();
        //}
        //public void CategoryAddBL(Category p)
        //{

        //    if (p.CategoryName=="" || p.CategoryName.Length <= 3 ||
        //        p.CategoryDescription =="" || p.CategoryName.Length >=51)
        //    {
        //        //HATA MESAJI
        //    }
        //    else
        //    {
        //        repo.Insert(p);
        //    }
        //}

    }
}// ctrl+k+d  (satırları düzene sokar)
