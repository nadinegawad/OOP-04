﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04
{
    internal class Airplane : Vechile, IMovable, IFlyable
    {
        void IMovable.Backward()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Backward()
        {
            throw new NotImplementedException();
        }

        void IMovable.Forward()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Forward()
        {
            throw new NotImplementedException();
        }

        void IMovable.Left()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Left()
        {
            throw new NotImplementedException();
        }

        void IMovable.Right()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Right()
        {
            throw new NotImplementedException();
        }
    }
}
