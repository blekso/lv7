using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv7
{
    //6.zad
    //class Visitor : IVisitor
    //{
    //    public double Visit(DVD DVDItem)
    //    {
    //        if(DVDItem.Type == DVDType.SOFTWARE)
    //            {
    //                return double.NaN;
    //            }
    //        return DVDItem.Price * 0.1;
    //    }
    //    public double Visit(VHS VHSItem)
    //    {
    //        return VHSItem.Price * 0.1;
    //    }

    //    public double Visit(Book BookItem)
    //    {
    //        return BookItem.Price * 0.1;
    //    }
    //}

        //7.zad
    class Visitor : IVisitor
    {
        public double Visit(DVD DVDItem)
        {
            return DVDItem.Price;
        }
        public double Visit(VHS VHSItem)
        {
            return VHSItem.Price;
        }

        public double Visit(Book BookItem)
        {
            return BookItem.Price;
        }
    }
}
