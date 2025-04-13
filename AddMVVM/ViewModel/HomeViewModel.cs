using AddMVVM.Helper;
using AddMVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AddMVVM.ViewModel
{
    public class HomeViewModel : Notify
    {
       // int Result;

        public ClickEvent AddData { get; set; }

        public ClickEvent ClearData { get; set; }


        private HomeModel _homefield;
        public HomeModel Homefield
        {
            get { return _homefield; }
            set { _homefield = value; }
        }

        public HomeViewModel()
        {
            
            AddData = new ClickEvent(Add);
            ClearData = new ClickEvent(Clear);
            Homefield = new HomeModel();

        }

        private int _result;
        public int Result
        {
            get { return _result; }
            set
            {
                _result = value;
            }
        }

        public void Add()
        {
            //int fno = Homefield.Fno;
            //int sno = Homefield.Sno;
            //int result = fno + sno;
            //Homefield = new HomeModel();
            //Homefield.Result = result;
            //MessageBox.Show(result.ToString());
        }

        public void Clear()
        {
            Homefield.Fno = 0;
            Homefield.Sno = 0;
            Homefield.Totale = 0;
        }
    }
}
