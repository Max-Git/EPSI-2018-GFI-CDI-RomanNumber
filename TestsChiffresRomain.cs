using System;
using Xunit;

namespace EPSI_2018_GFI_CDI_RomanNumber
{
    public class UnitTest1
    {
        [Fact]
        public void Quand_On_entre_1_on_repond_I()
        {
            Convertisseur convertisseur = new Convertisseur();
            Assert.Equal("I", convertisseur.convertir(1));
            
        }

        [Fact]
        public void Quand_On_entre_2_on_repond_II()
        {
            Convertisseur convertisseur = new Convertisseur();
            Assert.Equal("II", convertisseur.convertir(2));
            
        }
    }

    internal class Convertisseur
    {
        internal string convertir(int chiffreArabe)
        {
            if (chiffreArabe == 1)
                return "I";
            if (chiffreArabe == 2)
                return "II";

            return "Rome";
        }
    }
}
