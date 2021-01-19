using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AnalizadorLexico
{
    class claseAutomata
    {

        string textoIma;
        int estadoActual;

        public char siguienteCaracter(ref int contador)
        {
            if (contador == textoIma.Length)
            {
                contador++;
                return ' ';
            }
            else
                return textoIma[contador++];
        }




        public bool ReconocerTexto(string texto, int token, ref int contador, int noAuto)
        {
            char caracter;
            textoIma = texto;
            string lenguaje;


            switch (noAuto)
            {
                case 0:
                    estadoActual = 0;
                    break;
                case 1:
                    estadoActual = 3;
                    break;
                case 2:
                    estadoActual = 6;
                    break;
                case 3:
                    estadoActual = 9;
                    break;
            }


            while (contador <= textoIma.Length)
                switch (estadoActual)
                {
                    case 0:
                        caracter = siguienteCaracter(ref contador);
                        if ((lenguaje = "\n\r\t").IndexOf(caracter) >= 0)
                            estadoActual = 1;
                        else
                        {
                            contador = token;
                            return false;
                        }
                        break;


                    case 1:
                        caracter = siguienteCaracter(ref contador);
                        if ((lenguaje = "\n\r\t").IndexOf(caracter) >= 0)
                            estadoActual = 1;
                        else
                            if ((lenguaje = "!\"#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_'abcdefghijklmnopqrstuvwxyz{|}~€‚ƒ„...†‡ˆ‰Š‹ŒŽ''“”•–— ̃™š›œžŸ ¡¢£¤¥¦§ ̈©ª«¬-® ̄°±²³ ́μ¶· ̧¹º»¼½¾¿\f").IndexOf(caracter) >= 0)
                            estadoActual = 2;
                        else
                        {
                            contador = token;
                            return false;
                        }
                        break;


                    case 2:
                        contador--;
                        return true;
                        break;


                    case 3:
                        caracter = siguienteCaracter(ref contador);
                        if ((lenguaje = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz").IndexOf(caracter) >= 0)
                            estadoActual = 4;
                        else
                        {
                            contador = token;
                            return false;
                        }
                        break;


                    case 4:
                        caracter = siguienteCaracter(ref contador);
                        if ((lenguaje = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz").IndexOf(caracter) >= 0)
                            estadoActual = 4;
                        else
                            if ((lenguaje = "0123456789").IndexOf(caracter) >= 0)
                            estadoActual = 4;
                        else
                                if ((lenguaje = "_").IndexOf(caracter) >= 0)
                            estadoActual = 4;
                        else
                                if ((lenguaje = " !\"#$%&\'()*+,-./:;<=>?@[\\]^`{|}~€‚ƒ„...†‡ˆ‰Š‹ŒŽ‘’“”•–— ̃™š›œžŸ ¡¢£¤¥¦§ ̈©ª«¬-® ̄°±²³ ́μ¶· ̧¹º»¼½¾¿\n\t\r\f").IndexOf(caracter) >= 0)
                            estadoActual = 5;
                        else
                        {
                            contador = token;
                            return false;
                        }
                        break;


                    case 5:
                        contador--;
                        return true;
                        break;


                    case 6:
                        caracter = siguienteCaracter(ref contador);
                        if ((lenguaje = "0123456789").IndexOf(caracter) >= 0)
                            estadoActual = 7;
                        else
                        {
                            contador = token;
                            return false;
                        }
                        break;


                    case 7:
                        caracter = siguienteCaracter(ref contador);
                        if ((lenguaje = "0123456789").IndexOf(caracter) >= 0)
                            estadoActual = 7;
                        else
                            if ((lenguaje = " !\"#$%&\'()*+,-./:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~€‚ƒ„...†‡ˆ‰Š‹ŒŽ‘’“”•–— ̃™š›œžŸ ¡¢£¤¥¦§ ̈©ª«¬-® ̄°±²³ ́μ¶· ̧¹º»¼½¾¿\n\t\r\f").IndexOf(caracter) >= 0)
                            estadoActual = 8;
                        else
                        {
                            contador = token;
                            return false;
                        }
                        break;


                    case 8:
                        contador--;
                        return true;
                        break;




                    case 9:
                        caracter = siguienteCaracter(ref contador);
                        if ((lenguaje = "=").IndexOf(caracter) >= 0)
                            estadoActual = 10;
                        else
                        if ((lenguaje = ";").IndexOf(caracter) >= 0)
                            estadoActual = 10;
                        else
                        if ((lenguaje = ",").IndexOf(caracter) >= 0)
                            estadoActual = 10;
                        else
                        if ((lenguaje = ".").IndexOf(caracter) >= 0)
                            estadoActual = 10;
                        else
                        if ((lenguaje = "+").IndexOf(caracter) >= 0)
                            estadoActual = 10;
                        else
                        if ((lenguaje = "-").IndexOf(caracter) >= 0)
                            estadoActual = 10;
                        else
                        if ((lenguaje = "*").IndexOf(caracter) >= 0)
                            estadoActual = 10;
                        else
                        if ((lenguaje = "/").IndexOf(caracter) >= 0)
                            estadoActual = 10;
                        else
                        if ((lenguaje = "(").IndexOf(caracter) >= 0)
                            estadoActual = 10;
                        else
                        if ((lenguaje = ")").IndexOf(caracter) >= 0)
                            estadoActual = 10;
                        else
                        {
                            contador = token;
                            return false;
                        }
                        break;



                    case 10:
                        return true;
                        break;




                    case 11:
                        caracter = siguienteCaracter(ref contador);
                        if ((lenguaje = "\"").IndexOf(caracter) >= 0)
                            estadoActual = 12;
                        else
                        {
                            contador = token;
                            return false;
                        }
                        break;




                    case 12:
                        caracter = siguienteCaracter(ref contador);
                        if ((lenguaje = "\"").IndexOf(caracter) >= 0)
                            estadoActual = 13;
                        else
                            if ((lenguaje = " !#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~€‚ƒ„...†‡ˆ‰Š‹ŒŽ‘’“”•–— ̃™š›œžŸ ¡¢£¤¥¦§ ̈©ª«¬-® ̄°±²³ ́μ¶· ̧¹º»¼½¾¿\n\t\r\f").IndexOf(caracter) >= 0)
                            estadoActual = 12;
                        else
                        {
                            contador = token;
                            return false;
                        }
                        break;




                    case 13:
                        return true;
                        break;
                }




            switch (estadoActual)
            {
                case 2:
                case 5:
                case 8:
                    --contador;
                    return true;
            }
            return false;

        }
    }
}
