using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AnalizadorLexico
{
    class Lexico
    {
        //objeto de la clase Automata
        claseAutomata objAutomata;

        //arreglo de lexemas y tokens
        string[] lexemas;
        string[] tokens;

        string lexema;
        int noTokens;
        int contador;
        int iniToken;
        const int TOKREC = 5;
        const int TokensMaximos = 500;
        
        private bool reservadas()
        {
            string[] palabrasReservadas = {
                "booleano",
                "principal",
                "romper",
                "caso",
                "capturar",
                "caracter",
                "clase",
                "constante",
                "doble",
                "sino",
                "extender",
                "final",
                "finalmente",
                "flotante",
                "para","si",
                "importar",
                "entero",
                "largo",
                "nuevo",
                "paquete",
                "privado",
                "publico",
                "retornar",
                "cadena",
                "cambiar",
                "tratar",
                "vacio",
                "mientras",
                "estatico",
                "imprimir",
                "escaner",
                "sistema"
            };
            for (int i = 0; i < palabrasReservadas.Length; i++)
                if (lexema == palabrasReservadas[i])
                    return false;
            return true;
        }


        //constructor
        public Lexico()
        {
            objAutomata = new claseAutomata();
            lexemas = new string[TokensMaximos];
            tokens = new string[TokensMaximos];
            contador = 0;
            iniToken = 0;
            noTokens = 0;
        }


        //getters lexemas, tokens y no tokens
        public string[] Token
        {
            get { return tokens; }
        }
        public int NoTokens
        {
            get { return noTokens; }
        }
        public string[] Lexema
        {
            get { return lexemas; }
        }
        

        //inicializar contadores
        public void Inicia()
        {
            contador = 0; iniToken = 0; noTokens = 0;
        }




        public void AnalizarTexto(string texto)
        {
            bool recAuto;
            int noAuto;
            while (contador < texto.Length)
            {
                recAuto = false; noAuto = 0;
                for (; noAuto < TOKREC && !recAuto;)
                    if (objAutomata.ReconocerTexto(texto, iniToken, ref contador, noAuto))
                        recAuto = true;
                    else
                        noAuto++;
                if (recAuto)
                {
                    lexema = texto.Substring(iniToken, contador - iniToken); switch (noAuto)
                    {

                        case 0:
                            tokens[noTokens] = "Delimitador";
                            break;


                        case 1:
                            if (reservadas())
                                tokens[noTokens] = "Identificador";
                            else
                                tokens[noTokens] = "Reservada";
                            break;



                        case 2:
                            tokens[noTokens] = "Digito";
                            break;



                        case 3:
                            tokens[noTokens] = "Operador";
                            break;



                        case 4:
                            tokens[noTokens] = " ";
                            break;
                    }
                    if (noAuto != 0)
                        lexemas[noTokens++] = lexema;
                }
                else
                    contador++;
                iniToken = contador;
            }
        }
    }
}
