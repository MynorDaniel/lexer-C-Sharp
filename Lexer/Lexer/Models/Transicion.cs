

namespace Lexer.Models
{
    public class Transicion
    {
        public char Caracter {get; private set;}
        public Estado EstadoSalida {get; private set;}
        public TipoToken Tipo {get; private set;}

        public Transicion(char caracter, Estado estadoSalida, TipoToken tipo = TipoToken.Error){
            this.Caracter = caracter;
            this.EstadoSalida = estadoSalida;
            this.Tipo = tipo;
        }
    }
}