using System;
using System.Collections.Generic;

namespace Lexer.Models

{
    public class Estado
    {
        public int Id { get; private set;}
        public bool EsFinal { get; private set;}
        public List<Transicion> Transiciones { get; private set;}

        public Estado(int id, bool esFinal = false)
        {
            Id = id;
            EsFinal = esFinal;
            Transiciones = new List<Transicion>();
        }

        public Estado CambiarEstado(char c)
        {
            foreach (var transicion in Transiciones)
            {
                if (transicion.Caracter == c)
                {
                    return transicion.EstadoSalida;
                }
            }

            return null;
        }

        public void AgregarTransicion(char simbolo, Estado estado)
        {
            Transiciones.Add(new Transicion(simbolo, estado));
        }
    }
}