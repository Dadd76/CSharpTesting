using System;
using System.Diagnostics;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class InheritedTest3
    {
        /*
        Il est possible de masquer des méthodes qui ne sont pas forcément marquées comme virtuelles grâce au mot-clé new.
        À ce moment-là, la méthode ne se substitue pas à la méthode dérivée mais la masque pour les types dérivés
        */

        [TestMethod]
        public void InheritedTestMethod3()
        {
            Chien chien = new Chien();
            Caniche caniche = new Caniche();
            Chien canicheTraiteCommeUnChien = new Caniche();

            chien.Aboyer();                         // Wouaf !   //
            caniche.Aboyer();                       // Wiiff     //
            canicheTraiteCommeUnChien.Aboyer();     // Wouaf !   //
        }

        public class Chien
        {
            public void Aboyer()
            {
                Trace.WriteLine("Wouaf !");
            }
        }

        public class Caniche : Chien
        {
            public new void Aboyer()
            {
                Trace.WriteLine("Wiiff");
            }
        }

    }
}
