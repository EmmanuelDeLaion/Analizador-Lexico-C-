using System;
using Irony.Parsing;


namespace AnalizadorLexico.Analizador
{

    class sintactico : Grammar
    {
        public static string imprimirerrores = "";

        public static bool Parse(string text)
        {


            Gramatica gramatica = new Gramatica();
            LanguageData lenguaje = new LanguageData(gramatica);
            Parser parser = new Parser(lenguaje);
            ParseTree arbol = parser.Parse(text);
            ParseTreeNode root = arbol.Root;




            if (root == null)
            {
                foreach (var error in arbol.ParserMessages)
                {
                    imprimirerrores += "Error: " + error.Message + " en linea: " + (error.Location.Line + 1) + ", columna: " + error.Location.Column + "\r\n";
                }
                return false;
            }
            return true;
        }

    
    }


}
