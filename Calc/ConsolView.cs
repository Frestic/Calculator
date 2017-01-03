using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{

    class ConsolView
    {
        const string STR = "Выбирете операцию\n 1-сложение\n2-умножение\n3-Делениеъ\n4-разность\nДля выхода нажмите 0";
        private string _x;

        public string X
        {
            get { return _x; }
            set { _x = value; }
        }
        private string _y;
        
        public string Y
        {
            get { return _y; }
            set { _y = value; }
        }
        private string _z;

        public string Z
        {
            get { return _z; }
            set { _z = value; }
        }
        public ConsolView()
        {

        }

        public void View()
        {
            Console.WriteLine("Введите 1-ое число");
            _x = Console.ReadLine();
            Console.WriteLine("Введите 2-ое число");
            _y = Console.ReadLine();
            Console.WriteLine(STR);
            _z = Console.ReadLine();

        }

        public void PrintResult(string x, string y,char znak,double result)
        {
            Console.WriteLine(x + znak + y + "="+ result);
            
        }
    }
}
