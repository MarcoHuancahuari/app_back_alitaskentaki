﻿using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface ICategoriaRepository
    {
        public BaseResponse ObtenerCategorias();
    }
}
