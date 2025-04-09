namespace Lexer.Models
{
    public enum TipoToken
    {
        Identificador,
        Comentario_Linea,
        Error,
        Entero,
        Decimal,
        Palabra_Reservada,
        Literal,
        Puntuacion,
        Aritmetico,
        Relacional,
        Logico,
        Asignacion,
        Agrupacion,
        Comentario_Bloque
    }
}