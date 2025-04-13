using AddMVVM.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddMVVM.Model
{
    public class HomeModel : Notify
    {

        private int _fno;
        public int Fno
        {
            get { return _fno; }
            set
            {
                _fno = value;
                onproperty("Fno");
                _totale = _fno + _sno;
                onproperty("Totale");
            }
        }

        private int _sno;
        public int Sno
        {
            get { return _sno; }
            set
            {
                _sno = value;
                onproperty("Sno");
                _totale = _fno + _sno;
                onproperty("Totale");

            }
        }


        private int _totale;
        public int Totale
        {
            get { return _totale; }
            set
            {
              
                _totale = _fno + _sno;
                onproperty("Totale");
            }
        }


        private int _show;

        public int Show
        {
            get { return _show; }
            set { _show = value;
                onproperty("Show");
            }
        }



        //private int _result;
        //public int Result
        //{
        //    get { return _result; }
        //    set
        //    {
        //        _result = value;
        //        onproperty("Result");
        //    }
        //}

        //private int _Totale;
        //public double Totale
        //{
        //    get { return _Totale; }
        //}
    }
}
              

 




