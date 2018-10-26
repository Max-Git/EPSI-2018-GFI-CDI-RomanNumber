using System;
using Xunit;

namespace EPSI_2018_GFI_CDI_RomanNumber
{
    public class UnitTest1
    {
        [Fact]
        public void Quand_on_entre_un_tableau_de_chiffres_arabe_de_1_à_10_on_repond_avec_un_tableau_de_chiffres_romains_de_I_à_X()
        {
            Convertisseur convertisseur = new Convertisseur();
            string[] chiffresArabes = new string[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"};
            string[] chiffresRomains = new string[] {"I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X"};
            for (int i = 0; i < chiffresArabes.Length; i++)
            {
                Assert.Equal(chiffresRomains[i], convertisseur.convertir(int.Parse(chiffresArabes[i])));
            }
            
            
            
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
            else if(chiffreArabe >= 6 && chiffreArabe <= 8){
                chiffreRomain = V;
                for (int i = 0; i < chiffreArabe-5; i++)
                {
                    chiffreRomain += I; 
                }
            }
            else if (chiffreArabe == 9){
                chiffreRomain = I + X;
            }
            else{
                chiffreRomain = X;
            }
            return chiffreRomain;
        }
    }
}
