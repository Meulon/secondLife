﻿using SecondLife.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecondLife.Repositories.Repositories
{
    public interface IAnnonceRepository
    {
        List<Annonce> All();
        Annonce One();
        Annonce Add(Annonce annonce);
        bool Exists(Annonce annonce);
        void Update(Annonce updatedObject);
        bool Delete(int id);
        Annonce Get(int id);
    }

    public interface IRepository<T>
    {
        List<T> All();
        T One(int id);
        T Add(T annonce);
        T Remove(T annonce);
        T Update(T annonce);
        bool Exists(T annonce);
    }
}
