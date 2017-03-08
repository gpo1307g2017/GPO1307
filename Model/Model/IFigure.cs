﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Интерфейс фигур
    /// </summary>
    interface IFigure
    {
        void CalculatedArea();

        int SelectFigure();

        void GetFigure(int select);
    }
}
