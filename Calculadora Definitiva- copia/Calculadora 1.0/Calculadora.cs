
using System;
using System.IO;
using System.Runtime.Serialization;
using com.calitha.goldparser.lalr;
using com.calitha.commons;


namespace com.calitha.goldparser
{

    [Serializable()]
    public class SymbolException : System.Exception
    {
        public SymbolException(string message) : base(message)
        {
        }

        public SymbolException(string message,
            Exception inner) : base(message, inner)
        {
        }

        protected SymbolException(SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }

    }

    [Serializable()]
    public class RuleException : System.Exception
    {

        public RuleException(string message) : base(message)
        {
        }

        public RuleException(string message,
                             Exception inner) : base(message, inner)
        {
        }

        protected RuleException(SerializationInfo info,
                                StreamingContext context) : base(info, context)
        {
        }

    }

    enum SymbolConstants : int
    {
        SYMBOL_EOF        =  0, // (EOF)
        SYMBOL_ERROR      =  1, // (Error)
        SYMBOL_WHITESPACE =  2, // Whitespace
        SYMBOL_MINUS      =  3, // '-'
        SYMBOL_LPAREN     =  4, // '('
        SYMBOL_RPAREN     =  5, // ')'
        SYMBOL_TIMES      =  6, // '*'
        SYMBOL_DIV        =  7, // '/'
        SYMBOL_CARET      =  8, // '^'
        SYMBOL_PLUS       =  9, // '+'
        SYMBOL_DECIMAL    = 10, // Decimal
        SYMBOL_ENTERO     = 11, // Entero
        SYMBOL_LOG        = 12, // log
        SYMBOL_SIN        = 13, // sin
        SYMBOL_E          = 14, // <E>
        SYMBOL_F          = 15, // <F>
        SYMBOL_T          = 16  // <T>
    };

    enum RuleConstants : int
    {
        RULE_E_PLUS              =  0, // <E> ::= <E> '+' <T>
        RULE_E_MINUS             =  1, // <E> ::= <E> '-' <T>
        RULE_E                   =  2, // <E> ::= <T>
        RULE_T_TIMES             =  3, // <T> ::= <T> '*' <F>
        RULE_T_DIV               =  4, // <T> ::= <T> '/' <F>
        RULE_T_CARET             =  5, // <T> ::= <T> '^' <F>
        RULE_T                   =  6, // <T> ::= <F>
        RULE_F_LPAREN_RPAREN     =  7, // <F> ::= '(' <E> ')'
        RULE_F_LOG_LPAREN_RPAREN =  8, // <F> ::= log '(' <E> ')'
        RULE_F_SIN_LPAREN_RPAREN =  9, // <F> ::= sin '(' <E> ')'
        RULE_F_ENTERO            = 10, // <F> ::= Entero
        RULE_F_DECIMAL           = 11  // <F> ::= Decimal
    };

    public class MyParser
    {
        private LALRParser parser;

        public MyParser(string filename)
        {
            FileStream stream = new FileStream(filename,
                                               FileMode.Open, 
                                               FileAccess.Read, 
                                               FileShare.Read);
            Init(stream);
            stream.Close();
        }

        public MyParser(string baseName, string resourceName)
        {
            byte[] buffer = ResourceUtil.GetByteArrayResource(
                System.Reflection.Assembly.GetExecutingAssembly(),
                baseName,
                resourceName);
            MemoryStream stream = new MemoryStream(buffer);
            Init(stream);
            stream.Close();
        }

        public MyParser(Stream stream)
        {
            Init(stream);
        }

        private void Init(Stream stream)
        {
            CGTReader reader = new CGTReader(stream);
            parser = reader.CreateNewParser();
            parser.TrimReductions = false;
            parser.StoreTokens = LALRParser.StoreTokensMode.NoUserObject;

            parser.OnReduce += new LALRParser.ReduceHandler(ReduceEvent);
            parser.OnTokenRead += new LALRParser.TokenReadHandler(TokenReadEvent);
            parser.OnAccept += new LALRParser.AcceptHandler(AcceptEvent);
            parser.OnTokenError += new LALRParser.TokenErrorHandler(TokenErrorEvent);
            parser.OnParseError += new LALRParser.ParseErrorHandler(ParseErrorEvent);
        }

        public void Parse(string source)
        {
            parser.Parse(source);

        }

        private void TokenReadEvent(LALRParser parser, TokenReadEventArgs args)
        {
            try
            {
                args.Token.UserObject = CreateObject(args.Token);
            }
            catch (Exception e)
            {
                args.Continue = false;
                //todo: Report message to UI?
            }
        }

        private Object CreateObject(TerminalToken token)
        {
            switch (token.Symbol.Id)
            {
                case (int)SymbolConstants.SYMBOL_EOF :
                //(EOF)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ERROR :
                //(Error)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_WHITESPACE :
                //Whitespace
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MINUS :
                //'-'
                //todo: Create a new object that corresponds to the symbol
                return token.Text;


                case (int)SymbolConstants.SYMBOL_LPAREN :
                //'('
                //todo: Create a new object that corresponds to the symbol
                return token.Text;


                case (int)SymbolConstants.SYMBOL_RPAREN :
                //')'
                //todo: Create a new object that corresponds to the symbol
                return token.Text;


                case (int)SymbolConstants.SYMBOL_TIMES :
                //'*'
                //todo: Create a new object that corresponds to the symbol
                return token.Text;


                case (int)SymbolConstants.SYMBOL_DIV :
                //'/'
                //todo: Create a new object that corresponds to the symbol
                return token.Text;


                case (int)SymbolConstants.SYMBOL_CARET :
                //'^'
                //todo: Create a new object that corresponds to the symbol
                return token.Text;


                case (int)SymbolConstants.SYMBOL_PLUS :
                //'+'
                //todo: Create a new object that corresponds to the symbol
                return token.Text;


                case (int)SymbolConstants.SYMBOL_DECIMAL :
                //Decimal
                //todo: Create a new object that corresponds to the symbol
                return token.Text;


                case (int)SymbolConstants.SYMBOL_ENTERO :
                //Entero
                //todo: Create a new object that corresponds to the symbol
                return token.Text;


                case (int)SymbolConstants.SYMBOL_LOG :
                //log
                //todo: Create a new object that corresponds to the symbol
                return token.Text;


                case (int)SymbolConstants.SYMBOL_SIN :
                //sin
                //todo: Create a new object that corresponds to the symbol
                return token.Text;


                case (int)SymbolConstants.SYMBOL_E :
                //<E>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_F :
                //<F>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_T :
                //<T>
                //todo: Create a new object that corresponds to the symbol
                return null;

            }
            throw new SymbolException("Unknown symbol");
        }

        private void ReduceEvent(LALRParser parser, ReduceEventArgs args)
        {
            try
            {
                args.Token.UserObject = CreateObject(args.Token);
            }
            catch (Exception e)
            {
                args.Continue = false;
                //todo: Report message to UI?
            }
        }

        public static Object CreateObject(NonterminalToken token)
        {
            switch (token.Rule.Id)
            {
                case (int)RuleConstants.RULE_E_PLUS :
                    //<E> ::= <E> '+' <T>
                    //todo: Create a new object using the stored user objects.
                    return Convert.ToDouble(token.Tokens[0].UserObject) + Convert.ToDouble(token.Tokens[2].UserObject);

                case (int)RuleConstants.RULE_E_MINUS :
                //<E> ::= <E> '-' <T>
                //todo: Create a new object using the stored user objects.
                return Convert.ToDouble(token.Tokens[0].UserObject) - Convert.ToDouble(token.Tokens[2].UserObject);

                case (int)RuleConstants.RULE_E :
                //<E> ::= <T>
                //todo: Create a new object using the stored user objects.
                return token.Tokens[0].UserObject;

                case (int)RuleConstants.RULE_T_TIMES :
                //<T> ::= <T> '*' <F>
                //todo: Create a new object using the stored user objects.
                return Convert.ToDouble(token.Tokens[0].UserObject) * Convert.ToDouble(token.Tokens[2].UserObject);

                case (int)RuleConstants.RULE_T_DIV :
                //<T> ::= <T> '/' <F>
                //todo: Create a new object using the stored user objects.
                return Convert.ToDouble(token.Tokens[0].UserObject) / Convert.ToDouble(token.Tokens[2].UserObject);


                case (int)RuleConstants.RULE_T_CARET :
                //<T> ::= <T> '^' <F>
                //todo: Create a new object using the stored user objects.
                return Math.Pow((Convert.ToDouble(token.Tokens[0].UserObject)), (Convert.ToDouble(token.Tokens[2].UserObject)));

                case (int)RuleConstants.RULE_T :
                //<T> ::= <F>
                //todo: Create a new object using the stored user objects.
                return token.Tokens[0].UserObject;

                case (int)RuleConstants.RULE_F_LPAREN_RPAREN :
                //<F> ::= '(' <E> ')'
                //todo: Create a new object using the stored user objects.
                return token.Tokens[1].UserObject;

                case (int)RuleConstants.RULE_F_LOG_LPAREN_RPAREN :
                //<F> ::= log '(' <E> ')'
                //todo: Create a new object using the stored user objects.
                return Math.Log(Convert.ToDouble(token.Tokens[2].UserObject));

                case (int)RuleConstants.RULE_F_SIN_LPAREN_RPAREN :
                    //<F> ::= sin '(' <E> ')'
                    //todo: Create a new object using the stored user objects.
                    double pi = 3.14159265358979;
                    double radianes = Convert.ToDouble(token.Tokens[2].UserObject) * (pi / 180);
                return Math.Sin(radianes);

                case (int)RuleConstants.RULE_F_ENTERO :
                //<F> ::= Entero
                //todo: Create a new object using the stored user objects.
                return token.Tokens[0].UserObject;

                case (int)RuleConstants.RULE_F_DECIMAL :
                //<F> ::= Decimal
                //todo: Create a new object using the stored user objects.
                return token.Tokens[0].UserObject;

            }
            throw new RuleException("Unknown rule");
        }
        public string resultado;


        private void AcceptEvent(LALRParser parser, AcceptEventArgs args)
        {
            try
            {
                resultado = Convert.ToString(args.Token.UserObject);
            }

            catch (Exception e)
            {
                resultado = "ERROR";
            }
        }

        private void TokenErrorEvent(LALRParser parser, TokenErrorEventArgs args)
        {
            string message = "Token error with input: '"+args.Token.ToString()+"'";
            resultado = "Error Léxico :" + args.Token.ToString();

        }

        private void ParseErrorEvent(LALRParser parser, ParseErrorEventArgs args)
        {
            string message = "Parse error caused by token: '"+args.UnexpectedToken.ToString()+"'";
            resultado = "Error Sintáctico :" + args.UnexpectedToken.ToString();
        }


    }
}
