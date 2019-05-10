using System;
using System.Diagnostics;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class InheritedTest2
    {
        /*
        Masquer une méthode : Quand nous avons parlé de substitution, nous avons vu qu'on pouvait substituer une méthode grâce au mot-clé override. 
        Cette méthode devait d'ailleurs s'être déclarée comme candidate à cette substitution grâce au mot-clé virtual. 
        */

        [TestMethod]
        public void InheritedTestMethod2()
        {
            Chien chien = new Chien();
            Caniche caniche = new Caniche();
            Chien canicheTraiteCommeUnChien = new Caniche();

            chien.Aboyer();                         // Wouaf !   //
            caniche.Aboyer();                       // Wiiff     //
            canicheTraiteCommeUnChien.Aboyer();     // Wiiff     //
        }

        public class Chien
        {
            public virtual void Aboyer()
            {
                Trace.WriteLine("Wouaf !");
            }
        }

        public class Caniche : Chien
        {
            public override void Aboyer()
            {
                Trace.WriteLine("Wiiff");
            }
        }

    }
}
