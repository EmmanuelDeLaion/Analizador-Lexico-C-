using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Irony.Parsing;
using System.Windows.Forms;

namespace AnalizadorLexico.Analizador
{

    class Gramatica : Grammar
    {

        public Gramatica() : base(caseSensitive: true)
        {
            #region Expresiones regulares
            RegexBasedTerminal cadena = new RegexBasedTerminal("STRING", "\".*\"|\'.*\'");
            IdentifierTerminal id = new IdentifierTerminal("ID");
            RegexBasedTerminal usodoble = new RegexBasedTerminal("REAL", @"[0-9]+\.[0-9]+");
            RegexBasedTerminal entero = new RegexBasedTerminal("INTEGER", @"[0-9]+");
            RegexBasedTerminal aritmetico = new RegexBasedTerminal("ARITMETICO", @"[\+\-/*%]");
            RegexBasedTerminal comparacion = new RegexBasedTerminal("COMPARACION", @"==|<>|<=|>=|<|>");
            RegexBasedTerminal logico = new RegexBasedTerminal("LOGICO", @"&&|\|\||!");
            #endregion

            #region Terminales
            //modificadores
            KeyTerm modPublico = ToTerm("publico");
            KeyTerm modPrivado = ToTerm("privado");
            KeyTerm modProtected = ToTerm("protegido");
            //funciones
            KeyTerm terminalclase = ToTerm("clase");
            KeyTerm funcionmain = ToTerm("principal");
            KeyTerm returnTerminal = ToTerm("return");
            KeyTerm terminalTrue = ToTerm("verdadero");
            KeyTerm terminalFalse = ToTerm("falso");
            KeyTerm nullTerminal = ToTerm("null");
            KeyTerm terminalVoid = ToTerm("vacio");
            KeyTerm terimalStatic = ToTerm("estatico");
            //tipos de datos
            KeyTerm tipoDatoVar = ToTerm("var");
            KeyTerm tipoDatoint = ToTerm("entero");
            KeyTerm tipoDatoDouble = ToTerm("doble");
            KeyTerm tipoDatoString = ToTerm("cadena");
            KeyTerm tipoDatoBool = ToTerm("booleano");
            KeyTerm arreglo = ToTerm("arreglo");
            //simbolos
            KeyTerm concatenar = ToTerm("+");
            KeyTerm incremento = ToTerm("++");
            KeyTerm decremento = ToTerm("--");
            KeyTerm exponencial = ToTerm("**");
            KeyTerm logaritmo = ToTerm("//");
            KeyTerm ternary = ToTerm("??");
            KeyTerm igual = ToTerm("=");
            KeyTerm comparar = ToTerm("==");
            KeyTerm colon = ToTerm(":");
            KeyTerm punto = ToTerm(".");
            KeyTerm coma = ToTerm(",");
            KeyTerm llaveAbrir = ToTerm("{");
            KeyTerm llaveCerrar = ToTerm("}");
            KeyTerm parentesisAbrir = ToTerm("(");
            KeyTerm parentesisCerrar = ToTerm(")");
            KeyTerm corcheteAabrir = ToTerm("[");
            KeyTerm corcheteCerrar = ToTerm("]");
            KeyTerm puntoycoma = ToTerm(";");
            //estructuras
            KeyTerm useTerminal = ToTerm("usar");
            KeyTerm forTerminal = ToTerm("para");
            KeyTerm ifTerminal = ToTerm("si");
            KeyTerm elseTerminal = ToTerm("sino");
            KeyTerm caseTerminal = ToTerm("caso");
            KeyTerm defaultTerminal = ToTerm("default");
            KeyTerm breakTerminal = ToTerm("romper");
            //comentarios
            CommentTerminal lineComment = new CommentTerminal("LINE-COMMENT", "//", "\n", "\r\n");
            CommentTerminal blockComment = new CommentTerminal("BLOCK-COMMENT", "/*", "*/");
            #endregion



            #region No terminales
            NonTerminal INICIO = new NonTerminal("INICIO");
            NonTerminal MODIFICADORES = new NonTerminal("MODIFICADORES");
            NonTerminal BLOQUEDECODIGO = new NonTerminal("BLOQUEDECODIGO");
            //tipo de dato
            NonTerminal TIPODATO = new NonTerminal("TIPODATO");
            NonTerminal TIPODATOMETODO = new NonTerminal("TIPODATOMETODO");
            NonTerminal NUMERO = new NonTerminal("NUMERO");
            NonTerminal BOOLEAN = new NonTerminal("BOOLEAN");
            NonTerminal IMPORT = new NonTerminal("IMPORT");
            NonTerminal LIBRERIA = new NonTerminal("LIBRERIA");
            //creacion de variables
            NonTerminal CREACIONDEVARIABLE = new NonTerminal("CREACIONDEVARIABLE");
            NonTerminal VARIABLENORMAL = new NonTerminal("VARIABLENORMAL");
            NonTerminal VARIABLEASIGN = new NonTerminal("VARIABLEASIGN");
            NonTerminal VALOR = new NonTerminal("VALUE");
            NonTerminal INCDEC = new NonTerminal("INCDEC");
            NonTerminal EXPLOG = new NonTerminal("EXPLOG");
            NonTerminal INDECEXPLOG = new NonTerminal("INCDECEXPLOG");
            NonTerminal IDVALOR = new NonTerminal("IDVALOR");
            NonTerminal LISTADEVALORES = new NonTerminal("LISTADEVALORES");
            NonTerminal ternaryOperator = new NonTerminal("TERNARY-OPERATOR");
            NonTerminal DECLARACIONARREGLO = new NonTerminal("DECLARACIONARREGLO");
            //estructuras
            NonTerminal ESTRUCTURAS = new NonTerminal("ESTRUCTURAS");
            NonTerminal ESTRUCTURAIF = new NonTerminal("ESTRUCTURAIF");
            NonTerminal ESTRUCTURAELSE = new NonTerminal("ESTRUCTURAELSE");
            NonTerminal BOOLNOTERMINAL = new NonTerminal("BOOLNOTERMINAL");
            NonTerminal ESTRUCTURACASO = new NonTerminal("ESTRUCTURACASO");
            NonTerminal ESTRUCTURACLASE = new NonTerminal("ESTRUCTURACLASE");
            //estructura metodo
            NonTerminal ESTRUCTURAFUNCION = new NonTerminal("ESTRUCTURAFUNCION");
            NonTerminal paramsList = new NonTerminal("PARAMS-LIST");
            //funcion princpal
            NonTerminal FUNCIONCLASEPRINCIPAL = new NonTerminal("FUNCIONCLASEPRINCIPAL");
            NonTerminal BLOQUECODIGOFUNCION = new NonTerminal("BLOQUECODIGOFUNCION");
            NonTerminal BLOQUECODIGOPRINCIPAL = new NonTerminal("BLOQUECODIGOPRINCIPAL");
            NonTerminal EXPRESIONVALORID = new NonTerminal("EXPRESIONVALORID");
            NonTerminal LLAMARFUNCION = new NonTerminal("LLAMARFUNCION");
            NonTerminal BLOQUECODIGOMETODO = new NonTerminal("BLOQUECODIGOMETODO");
            //expresiones de tipos de datos
            NonTerminal EXPRESION = new NonTerminal("EXPRESSION");
            NonTerminal EXPRESIONNUMERO = new NonTerminal("EXPRESIONNUMERO");
            NonTerminal EXPRESIONSTRING = new NonTerminal("EXPRESIONSTRING");
            NonTerminal EXPRESIONOBJETO = new NonTerminal("EXPRESIONOBJETO");
            NonTerminal EXPRESIONBOOLEANO = new NonTerminal("EXPRESIONBOOLEANO");
            #endregion



            #region Reglas de produccion
            INICIO.Rule = this.Empty
                | ESTRUCTURACLASE
                | BLOQUECODIGOPRINCIPAL;

            //estructura de la clase principal
            ESTRUCTURACLASE.Rule = MODIFICADORES + terminalclase + id + llaveAbrir + BLOQUECODIGOPRINCIPAL + llaveCerrar
                | terminalclase + id + llaveAbrir + BLOQUECODIGOFUNCION + llaveCerrar
                | MODIFICADORES + terminalclase + id + llaveAbrir + this.Empty + llaveCerrar
                | MODIFICADORES + terminalclase + id + llaveAbrir + BLOQUEDECODIGO + llaveCerrar;


            BLOQUECODIGOFUNCION.Rule = ESTRUCTURAFUNCION
                | ESTRUCTURAFUNCION + BLOQUECODIGOFUNCION;

            //tipos de modificadores
            MODIFICADORES.Rule = modPublico
                | modPrivado
                | modProtected;

            //bloque de codigo principal
            BLOQUECODIGOPRINCIPAL.Rule = FUNCIONCLASEPRINCIPAL
                | FUNCIONCLASEPRINCIPAL + BLOQUECODIGOFUNCION
                | BLOQUECODIGOFUNCION + FUNCIONCLASEPRINCIPAL;

            //funcion main
            FUNCIONCLASEPRINCIPAL.Rule =MODIFICADORES + terimalStatic + terminalVoid + funcionmain + parentesisAbrir + parentesisCerrar + llaveAbrir + BLOQUEDECODIGO + llaveCerrar;

            //bloque de codigo principal
            BLOQUEDECODIGO.Rule = this.Empty
                | CREACIONDEVARIABLE
                | VARIABLEASIGN
                | DECLARACIONARREGLO
                | ESTRUCTURAS
                | LLAMARFUNCION
                | breakTerminal
                | CREACIONDEVARIABLE + BLOQUEDECODIGO
                | VARIABLEASIGN + BLOQUEDECODIGO
                | DECLARACIONARREGLO + BLOQUEDECODIGO
                | ESTRUCTURAS + BLOQUEDECODIGO
                | LLAMARFUNCION + BLOQUEDECODIGO
                | breakTerminal + BLOQUEDECODIGO
                | FUNCIONCLASEPRINCIPAL + BLOQUEDECODIGO;


            //declaracion de variable
            CREACIONDEVARIABLE.Rule = VARIABLENORMAL + puntoycoma;

            VARIABLENORMAL.Rule = TIPODATO + id
                | TIPODATO + id + igual + EXPRESIONVALORID
                | TIPODATO + id + igual + ternaryOperator;

            //declarar arreglo
            DECLARACIONARREGLO.Rule = arreglo + id + puntoycoma
                | arreglo + id + igual + corcheteAabrir + corcheteCerrar + puntoycoma
                | arreglo + TIPODATO +  id + corcheteAabrir + corcheteCerrar + puntoycoma
                | arreglo + TIPODATO + id + corcheteAabrir + NUMERO + corcheteCerrar + puntoycoma
                | arreglo + id + igual + corcheteAabrir + entero + corcheteCerrar + puntoycoma
                | arreglo + id + igual + corcheteAabrir + id + corcheteCerrar + puntoycoma;

            //tipo de dato
            TIPODATO.Rule = tipoDatoVar
                | tipoDatoint
                | tipoDatoDouble
                | tipoDatoString
                | tipoDatoBool;

            VARIABLEASIGN.Rule = id + igual + EXPRESIONVALORID
                | id + igual + ternaryOperator;
            //valor
            VALOR.Rule = NUMERO
                | cadena
                | tipoDatoBool
                | nullTerminal;

            IDVALOR.Rule = id
                | VALOR;

            LISTADEVALORES.Rule = IDVALOR
                | IDVALOR + coma + LISTADEVALORES;

            EXPRESIONVALORID.Rule = IDVALOR
                | EXPRESION;
            //numero enterp/doble
            NUMERO.Rule = usodoble
                | entero;


            //tipo metodo
            TIPODATOMETODO.Rule = tipoDatoVar
                | tipoDatoint
                | tipoDatoDouble
                | tipoDatoString
                | tipoDatoBool
                | terminalVoid;

            BOOLEAN.Rule = terminalTrue
                | terminalFalse;

            //expresion con numero
            EXPRESIONNUMERO.Rule = NUMERO
                | id
                | NUMERO + aritmetico + EXPRESIONNUMERO
                | parentesisAbrir + EXPRESIONNUMERO + parentesisCerrar
                | NUMERO + INCDEC
                | INCDEC + NUMERO
                | NUMERO + INDECEXPLOG + NUMERO;

            INDECEXPLOG.Rule = INCDEC
                | EXPLOG;

            INCDEC.Rule = incremento
                | decremento;

            EXPLOG.Rule = exponencial
                | logaritmo;

            //expresion con cadena
            EXPRESIONSTRING.Rule = VALOR
                | id
                | EXPRESIONSTRING + INCDEC + EXPRESIONSTRING
                | parentesisAbrir + EXPRESIONSTRING + parentesisCerrar
                | EXPRESIONSTRING + concatenar + EXPRESIONSTRING;

            EXPRESIONOBJETO.Rule = id
                | id + parentesisAbrir + parentesisCerrar
                | id + punto + EXPRESIONOBJETO
                | id + parentesisAbrir + LISTADEVALORES + parentesisCerrar
                | id + punto + EXPRESIONOBJETO;

            EXPRESIONBOOLEANO.Rule = id
                | terminalTrue
                | terminalFalse
                | BOOLNOTERMINAL + comparacion + BOOLNOTERMINAL
                | BOOLNOTERMINAL + comparacion + BOOLNOTERMINAL + logico + EXPRESIONBOOLEANO;

            BOOLNOTERMINAL.Rule = IDVALOR
                | EXPRESION
                | terminalTrue
                | terminalFalse;

            ternaryOperator.Rule = EXPRESIONVALORID + ternary + EXPRESIONVALORID + colon + EXPRESIONVALORID;

            EXPRESION.Rule = EXPRESIONNUMERO
                | EXPRESIONSTRING
                | EXPRESIONOBJETO;


            //estructuras if/else/case
            ESTRUCTURAS.Rule = ESTRUCTURAIF;

            ESTRUCTURAIF.Rule = ifTerminal + IDVALOR + llaveAbrir + ESTRUCTURACASO + llaveCerrar
                | ifTerminal + EXPRESIONBOOLEANO + llaveAbrir + BLOQUEDECODIGO + llaveCerrar
                | ifTerminal + EXPRESIONBOOLEANO + llaveAbrir + BLOQUEDECODIGO + llaveCerrar + ESTRUCTURAELSE
                | ifTerminal + IDVALOR + llaveAbrir + ESTRUCTURACASO + llaveCerrar + ESTRUCTURAELSE
                | ifTerminal + parentesisAbrir + parentesisCerrar + llaveAbrir + llaveCerrar
                | ifTerminal + parentesisAbrir + ESTRUCTURACASO + parentesisCerrar + llaveAbrir + llaveCerrar
                | ifTerminal + parentesisAbrir + ESTRUCTURACASO + parentesisCerrar
                | ifTerminal + parentesisAbrir + ESTRUCTURACASO + parentesisCerrar + llaveAbrir + BLOQUEDECODIGO + llaveCerrar
                | ifTerminal + parentesisAbrir + id + comparar + NUMERO + parentesisCerrar + llaveAbrir + llaveCerrar + ESTRUCTURAELSE
                | ifTerminal + parentesisAbrir + id + comparar + NUMERO + parentesisCerrar + llaveAbrir + llaveCerrar;
                
            
            ESTRUCTURACASO.Rule = caseTerminal + IDVALOR + colon + BLOQUEDECODIGO
                | caseTerminal + IDVALOR + colon + BLOQUEDECODIGO + ESTRUCTURACASO
                | defaultTerminal + colon + BLOQUEDECODIGO;


            ESTRUCTURAELSE.Rule = elseTerminal + llaveAbrir + BLOQUEDECODIGO + llaveCerrar
                | elseTerminal + ESTRUCTURAIF
                | elseTerminal + llaveAbrir + llaveCerrar;

     
            //estructura de un metodo
            ESTRUCTURAFUNCION.Rule = TIPODATO + id + parentesisAbrir + parentesisCerrar + llaveAbrir + BLOQUECODIGOMETODO + llaveCerrar
                | TIPODATO + id + parentesisAbrir + paramsList + parentesisCerrar + llaveAbrir + BLOQUECODIGOMETODO + llaveCerrar
                | id + parentesisAbrir + paramsList + parentesisCerrar + llaveAbrir + BLOQUECODIGOMETODO + llaveCerrar;

            paramsList.Rule = TIPODATO + id
                | TIPODATO + id + coma + paramsList;

            //invocar metodo
            LLAMARFUNCION.Rule = id + parentesisAbrir + parentesisCerrar
                | id + parentesisAbrir + LLAMARFUNCION + parentesisCerrar;


            //bloque de codigo del metodo
            BLOQUECODIGOMETODO.Rule = returnTerminal
                | returnTerminal + EXPRESIONVALORID
                | BLOQUEDECODIGO
                | returnTerminal + BLOQUECODIGOMETODO
                | returnTerminal + EXPRESIONVALORID + BLOQUECODIGOMETODO
                | BLOQUEDECODIGO + BLOQUECODIGOMETODO;

            

            #endregion

            #region Preferencias
            this.Root = INICIO;
            this.NonGrammarTerminals.Add(lineComment);
            this.NonGrammarTerminals.Add(blockComment);
            #endregion

        }

    }

}
