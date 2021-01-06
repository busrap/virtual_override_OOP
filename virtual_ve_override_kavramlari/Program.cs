using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_ve_override_kavramlari
{
    class Program
    {
        static void Main(string[] args)
        {

            B Bn = new B();
            Bn.M();
            Console.Read();
        }

        //Eğer bir base class içerisin de ki herhangi bir method,drived classlar da başka bir biçimde kullanılacaksa o metoh metot class'da virtual olarak tanımlana bilir.
        //Virtual tanımlanan o method drived classlar da yeniden şekillendirilerek kullanıla bilir..(override işlemi)(virtual tanımlanan herhangi bir yapı için geçerli)
        class A
        {
            public virtual void M()
            {
                Console.WriteLine("Bu bir örnek metoddur!");
            }
            public virtual void M2(int b)
            {

            }
            public virtual int P { get; set; }

        }
        class B :A
        {
            public override void M()  //override yazdığımız zaman inherit olduğu class da ki virtual tanımlanmış tüm yapıları getirir
            {
                Console.WriteLine("Override edilmiş metod");
            }
            public override int P { get => base.P; set => base.P = value; }
        }




    }
}
