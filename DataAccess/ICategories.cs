﻿using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface ICategories
    {
        List<Category> GetCategories();
    }
}
