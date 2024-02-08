using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieDziedziczenie
{
    //c# access modifiers
    // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
    internal class Raport
    {
        public string Zawartosc { get; set; }
        public int Rozmiar {  get; set; }
        public string Autor {  get; set; }
        public string Sciezka { get; set; }
        public string Nazwa {  get; set; }

        private protected string rozszerzenie;

        public virtual void Zapisz()
        {

        }
    }
}
