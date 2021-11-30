using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inheritance
{
 
    public abstract class Person
    {
        public Person() { }

        protected string Adı;
        protected string Soyadı;
        protected DateTime DogumTarihi;
        protected string Cinsiyeti;


        public abstract void makeAction();
        public abstract void YemekYe();
        public abstract void SuIc();
        public abstract void Calis();
        public abstract void Uyu();
    }
}
