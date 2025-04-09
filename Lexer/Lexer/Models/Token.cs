namespace Lexer.Models
{
    public class Token
    {
        public string Lexema { get; private set;}
        public TipoToken Tipo { get; private set;}
        public int Columna { get; private set;}
        public int Linea { get; private set;}

        public Token(TipoToken tipo, string lexema, int ln, int col)
        {
            Lexema = lexema;
            Tipo = tipo;
            Columna = col;
            Linea = ln;
        }

        public override string ToString()
        {
            return $"Token: {Lexema}, {Tipo.ToString()}, {Linea}, {Columna}";
        }
    }
}
