﻿using StoreMusfer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreMusfer.DateAccsse.Repository.IRepository
{
    public interface ICategoryRepository :IRepository<Category>
    {
        void update(Category obj);
       
    }
}
