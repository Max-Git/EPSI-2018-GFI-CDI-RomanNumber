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
        [Fact]
        public void Quand_On_entre_4_on_repond_IV()
        {
            Convertisseur convertisseur = new Convertisseur();
            Assert.Equal("IV", convertisseur.convertir(4));
            
        }
        [Fact]
        public void Quand_On_entre_5_on_repond_V()
        {
            Convertisseur convertisseur = new Convertisseur();
            Assert.Equal("V", convertisseur.convertir(5));
            
        }
        [Fact]
        public void Quand_On_entre_9_on_repond_IX()
        {
            Convertisseur convertisseur = new Convertisseur();
            Assert.Equal("IX", convertisseur.convertir(9));
            
        }
    }

    internal class Convertisseur
    {
        internal string convertir(int chiffreArabe)
        {
            string chiffreRomain = "";
            
            const string I = "I";
            const string V = "V";
            const string X = "X";

            if (chiffreArabe <= 3)
            {
                for (int i = 0; i < chiffreArabe; i++)
                {
                    chiffreRomain += I;
                }
            }else if(chiffreArabe == 4)
            {
                chiffreRomain = I + V;
            }
            else if(chiffreArabe == 5){
                chiffreRomain = V;
            }
            else{
                chiffreRomain = I + X;
            }
            return chiffreRomain;
        }
    }
}
