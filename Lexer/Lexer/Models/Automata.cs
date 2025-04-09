using System.Collections.Generic;
using Lexer.Models;
using System;
using System.Text;

namespace Lexer.Models
{
    public class Automata
    {

        public List<Token> tokens = null!;
        public Estado EstadoInicial {get; private set;} = null!;
        public Estado q0 {get; private set;} = null!;
        public Estado q1 {get; private set;} = null!;
        public Estado q2 {get; private set;} = null!;
        public Estado q3 {get; private set;} = null!;
        public Estado q4 {get; private set;} = null!;
        public Estado q5 {get; private set;} = null!;
        public Estado q6 {get; private set;} = null!;
        public Estado q7 {get; private set;} = null!;
        public Estado q8 {get; private set;} = null!;
        public Estado q9 {get; private set;} = null!;
        public Estado q10 {get; private set;} = null!;
        public Estado q11 {get; private set;} = null!;
        public Estado q12 {get; private set;} = null!;
        public Estado q13 {get; private set;} = null!;
        public Estado q14 {get; private set;} = null!;
        public Estado q15 {get; private set;} = null!;
        public Estado q16 {get; private set;} = null!;
        public Estado q17 {get; private set;} = null!;
        public Estado q18 {get; private set;} = null!;
        public Estado q19 {get; private set;} = null!;
        public Estado q20 {get; private set;} = null!;
        public Estado q21 {get; private set;} = null!;
        public Estado q22 {get; private set;} = null!;
        public Estado q23 {get; private set;} = null!;
        public Estado q24 {get; private set;} = null!;
        public Estado q25 {get; private set;} = null!;
        public Estado q26 {get; private set;} = null!;
        public Estado q27 {get; private set;} = null!;
        public Estado q28 {get; private set;} = null!;
        public Estado q29 {get; private set;} = null!;
        public Estado q30 {get; private set;} = null!;
        public Estado q31 {get; private set;} = null!;
        public Estado q32 { get; private set; } = null!;
        public Estado q33 { get; private set; } = null!;
        public Estado q34 { get; private set; } = null!;
        public Estado q35 { get; private set; } = null!;
        public Estado q36 { get; private set; } = null!;
        public Estado q37 { get; private set; } = null!;
        public Estado q38 { get; private set; } = null!;
        public Estado q39 { get; private set; } = null!;
        public Estado q40 { get; private set; } = null!;
        public Estado q41 { get; private set; } = null!;
        public Estado q42 { get; private set; } = null!;
        public Estado q43 { get; private set; } = null!;
        public Estado q44 { get; private set; } = null!;
        public Estado q45 { get; private set; } = null!;
        public Estado q46 { get; private set; } = null!;
        public Estado q47 { get; private set; } = null!;
        public Estado q48 { get; private set; } = null!;

        public Estado q49 { get; private set; } = null!;
        public Estado q50 { get; private set; } = null!;
        public Estado q51 { get; private set; } = null!;
        public Estado q52 { get; private set; } = null!;
        public Estado q53 { get; private set; } = null!;
        public Estado q54 { get; private set; } = null!;
        public Estado q55 { get; private set; } = null!;
        public Estado q56 { get; private set; } = null!;
        public Estado q57 { get; private set; } = null!;
        public Estado q58 { get; private set; } = null!;
        public Estado q59 { get; private set; } = null!;
        public Estado q60 { get; private set; } = null!;
        public Estado q61 { get; private set; } = null!;
        public Estado q62 { get; private set; } = null!;
        public Estado q63 { get; private set; } = null!;

        public Estado q64 { get; private set; } = null!;
        public Estado q65 { get; private set; } = null!;
        public Estado q66 { get; private set; } = null!;
        public Estado q67 { get; private set; } = null!;
        public Estado q68 { get; private set; } = null!;
        public Estado q69 { get; private set; } = null!;
        public Estado q70 { get; private set; } = null!;
        public Estado q71 { get; private set; } = null!;

        public Estado q72 { get; private set; } = null!;
        public Estado q73 { get; private set; } = null!;
        public Estado q74 { get; private set; } = null!;
        public Estado q75 { get; private set; } = null!;
        public Estado q76 { get; private set; } = null!;
        public Estado q77 { get; private set; } = null!;
        public Estado q78 { get; private set; } = null!;
        public Estado q79 { get; private set; } = null!;
        public Estado q80 { get; private set; } = null!;
        public Estado q81 { get; private set; } = null!;
        public Estado q82 { get; private set; } = null!;
        public Estado q83 { get; private set; } = null!;
        public Estado q84 { get; private set; } = null!;
        public Estado q85 { get; private set; } = null!;
        public Estado q86 { get; private set; } = null!;
        public Estado q87 { get; private set; } = null!;
        public Estado q88 { get; private set; } = null!;
        public Estado q89 { get; private set; } = null!;
        public Estado q90 { get; private set; } = null!;
        public Estado q91 { get; private set; } = null!;
        public Estado q92 { get; private set; } = null!;
        public Estado q93 { get; private set; } = null!;

        public Estado q94 { get; private set; } = null!;
        public Estado q95 { get; private set; } = null!;
        public Estado q96 { get; private set; } = null!;
        public Estado q97 { get; private set; } = null!;
        public Estado q98 { get; private set; } = null!;
        public Estado q99 { get; private set; } = null!;
        public Estado q100 { get; private set; } = null!;
        public Estado q101 { get; private set; } = null!;
        public Estado q102 { get; private set; } = null!;
        public Estado q103 { get; private set; } = null!;
        public Estado q104 { get; private set; } = null!;
        public Estado q105 { get; private set; } = null!;
        public Estado q106 { get; private set; } = null!;
        public Estado q107 { get; private set; } = null!;
        public Estado q108 { get; private set; } = null!;
        public Estado q109 { get; private set; } = null!;
        public Estado q110 { get; private set; } = null!;
        public Estado q111 { get; private set; } = null!;
        public Estado q112 { get; private set; } = null!;
        public Estado q113 { get; private set; } = null!;
        public Estado q114 { get; private set; } = null!;
        public Estado q115 { get; private set; } = null!;
        public Estado q116 { get; private set; } = null!;
        public Estado q117 { get; private set; } = null!;
        public Estado q118 { get; private set; } = null!;

        public Estado q119 { get; private set; } = null!;
        public Estado q120 { get; private set; } = null!;
        public Estado q121 { get; private set; } = null!;
        public Estado q122 { get; private set; } = null!;
        public Estado q123 { get; private set; } = null!;
        public Estado q124 { get; private set; } = null!;
        public Estado q125 { get; private set; } = null!;
        public Estado q126 { get; private set; } = null!;
        public Estado q127 { get; private set; } = null!;
        public Estado q128 { get; private set; } = null!;

        public Estado q129 { get; private set; } = null!;
        public Estado q130 { get; private set; } = null!;
        public Estado q131 { get; private set; } = null!;
        public Estado q132 { get; private set; } = null!;

        public Estado q133 { get; private set; } = null!;
        public Estado q134 { get; private set; } = null!;
        public Estado q135 { get; private set; } = null!;
        public Estado q136 { get; private set; } = null!;
        public Estado q137 { get; private set; } = null!;

        public Estado q138 { get; private set; } = null!;
        public Estado q139 { get; private set; } = null!;
        public Estado q140 { get; private set; } = null!;
        public Estado q141 { get; private set; } = null!;
        public Estado q142 { get; private set; } = null!;
        public Estado q143 { get; private set; } = null!;

        public Estado q144 { get; private set; } = null!;
        public Estado q145 { get; private set; } = null!;
        public Estado q146 { get; private set; } = null!;
        public Estado q147 { get; private set; } = null!;
        public Estado q148 { get; private set; } = null!;
        public Estado q149 { get; private set; } = null!;
        public Estado q150 { get; private set; } = null!;

        public Estado q999 {get; private set;} = null!;

        public Automata()
        {
            CrearEstados();
            DefinirTransiciones();

            EstadoInicial = q0;
            tokens = new List<Token>();
        }

        public List<Token> Tokenizar(string input) // '. .'
        {
            tokens.Clear();
            input = input + " \n";
            input = input.Replace("\t", "    ");
            input = input.Replace(" ", "  ");

            Estado estadoActual = EstadoInicial; // q3
            StringBuilder lexema = new StringBuilder(); // '.'

            int linea = 1;
            int columna = 1;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i]; // ' '

                Estado nuevoEstado = estadoActual.CambiarEstado(c); // q0

                // Revisar si se debe guardar el token antes de cambiar de estado
                if ((estadoActual.EsFinal && nuevoEstado == q0) || nuevoEstado == null)
                {

                    if (estadoActual.EsFinal && lexema.Length > 0 && nuevoEstado != null)
                    {
                        GuardarToken(estadoActual, lexema.ToString().Trim(), linea, columna-1);
                        i--;
                        lexema.Clear();
                        estadoActual = EstadoInicial;
                    }

                    if(nuevoEstado == null)
                    {
                        nuevoEstado = q999;
                    }
                }

                lexema.Append(c);

                estadoActual = nuevoEstado;

                // Linea y columna
                if (c == '\n')
                {
                    columna = 1;
                    linea++; 
                }else
                {
                    columna++;
                }
            }

            // Literal no cerrado
            if (estadoActual == q11 || estadoActual == q12 || estadoActual == q29 || estadoActual == q30) {
                GuardarToken(q999, lexema.ToString().Trim(), linea, columna);
            }


            return tokens;
        }
        public void GuardarToken(Estado estado, string lexema, int linea, int columna)
        {
            TipoToken tipo;

            if (estado == q8)
                tipo = TipoToken.Identificador;
            else if (estado == q26)
                tipo = TipoToken.Comentario_Linea;
            else if (estado == q999)
                tipo = TipoToken.Error;
            else if (estado == q4 || estado == q2 || estado == q3)
                tipo = TipoToken.Entero;
            else if (estado == q6)
                tipo = TipoToken.Decimal;
            else if (estado == q13)
                tipo = TipoToken.Literal;
            else if (estado == q14)
                tipo = TipoToken.Puntuacion;
            else if (estado == q16 || estado == q17)
                tipo = TipoToken.Relacional;
            else if (estado == q15 || estado == q1 || estado == q27)
                tipo = TipoToken.Aritmetico;
            else if (estado == q31)
                tipo = TipoToken.Comentario_Bloque;
            else if (estado == q24)
                tipo = TipoToken.Asignacion;
            else if (estado == q23)
                tipo = TipoToken.Logico;
            else if (estado == q25)
                tipo = TipoToken.Agrupacion;
            else if (estado == q32 || estado == q41 || estado == q45 || estado == q48 || estado == q63 || estado == q59 || estado == q57 || estado == q53 || estado == q71 || estado == q67 || estado == q79 || estado == q84 || estado == q72 || estado == q92 || estado == q86 || estado == q150 || estado == q143 || estado == q137 || estado == q132 || estado == q124 || estado == q128 || estado == q99 || estado == q105 || estado == q112 || estado == q118)
                tipo = TipoToken.Palabra_Reservada;
            else 
                tipo = TipoToken.Error;

            tokens.Add(new Token(tipo, lexema, linea, columna));
        }
        private void CrearEstados()
        {
            // Estado inicial
            q0 = new Estado(0);

            // Identificador
            q7 = new Estado(7);
            q8 = new Estado(8, true);

            // Comentario de linea
            q26 = new Estado(26, true);

            // Error
            q999 = new Estado(999, true);

            // Entero y Decimal
            q1 = new Estado(1, true);
            q2 = new Estado(2, true);
            q3 = new Estado(3, true);
            q4 = new Estado(4, true);
            q5 = new Estado(5);
            q6 = new Estado(6, true);

            // Literal
            q9 = new Estado(9);
            q10 = new Estado(10);
            q11 = new Estado(11);
            q12 = new Estado(12);
            q13 = new Estado(13, true);

            // Puntuacion
            q14 = new Estado(14, true);

            // Relacional
            q16 = new Estado(16, true);
            q17 = new Estado(17, true);

            // Aritmetico
            q15 = new Estado(15, true);

            // Comentario de bloque
            q27 = new Estado(27, true);
            q28 = new Estado(28);
            q29 = new Estado(29);
            q30 = new Estado(30);
            q31 = new Estado(31, true);

            // Asinacion
            q24 = new Estado(24, true);

            // Agrupacion
            q25 = new Estado(25, true);

            // Logico
            q18 = new Estado(18);
            q19 = new Estado(19);
            q20 = new Estado(20);
            q21 = new Estado(21);
            q22 = new Estado(22);
            q23 = new Estado(23, true);

            // Palabras reservadas

            q32 = new Estado(32, true);
            q33 = new Estado(33);
            q34 = new Estado(34);
            q35 = new Estado(35);
            q36 = new Estado(36);
            q37 = new Estado(37);
            q38 = new Estado(38);
            q39 = new Estado(39);
            q40 = new Estado(40);
            q41 = new Estado(41, true);

            q42 = new Estado(42, true);
            q43 = new Estado(43);
            q44 = new Estado(44);
            q45 = new Estado(45, true);
            q46 = new Estado(46);
            q47 = new Estado(47);
            q48 = new Estado(48, true);

            q49 = new Estado(49);
            q50 = new Estado(50);
            q51 = new Estado(51);
            q52 = new Estado(52);
            q53 = new Estado(53, true);
            q54 = new Estado(54);
            q55 = new Estado(55);
            q56 = new Estado(56);
            q57 = new Estado(57, true);
            q58 = new Estado(58);
            q59 = new Estado(59, true);
            q60 = new Estado(60);
            q61 = new Estado(61);
            q62 = new Estado(62);
            q63 = new Estado(63, true);

            q64 = new Estado(64);
            q65 = new Estado(65);
            q66 = new Estado(66);
            q67 = new Estado(67, true);
            q68 = new Estado(68);
            q69 = new Estado(69);
            q70 = new Estado(70);
            q71 = new Estado(71, true);

            q72 = new Estado(72, true);
            q73 = new Estado(73);
            q74 = new Estado(74);
            q75 = new Estado(75);
            q76 = new Estado(76);
            q77 = new Estado(77);
            q78 = new Estado(78);
            q79 = new Estado(79, true);
            q80 = new Estado(80);
            q81 = new Estado(81);
            q82 = new Estado(82);
            q83 = new Estado(83);
            q84 = new Estado(84, true);
            q85 = new Estado(85);
            q86 = new Estado(86, true);
            q87 = new Estado(87);
            q88 = new Estado(88);
            q89 = new Estado(89);
            q90 = new Estado(90);
            q91 = new Estado(91);
            q92 = new Estado(92, true);

            q93 = new Estado(93);
            q94 = new Estado(94);
            q95 = new Estado(95);
            q96 = new Estado(96);
            q97 = new Estado(97);
            q98 = new Estado(98);
            q99 = new Estado(99, true);
            q100 = new Estado(100);
            q101 = new Estado(101);
            q102 = new Estado(102);
            q103 = new Estado(103);
            q104 = new Estado(104);
            q105 = new Estado(105, true);
            q106 = new Estado(106);
            q107 = new Estado(107);
            q108 = new Estado(108);
            q109 = new Estado(109);
            q110 = new Estado(110);
            q111 = new Estado(111);
            q112 = new Estado(112, true);
            q113 = new Estado(113);
            q114 = new Estado(114);
            q115 = new Estado(115);
            q116 = new Estado(116);
            q117 = new Estado(117);
            q118 = new Estado(118, true);

            q119 = new Estado(119);
            q120 = new Estado(120);
            q121 = new Estado(121);
            q122 = new Estado(122);
            q123 = new Estado(123);
            q124 = new Estado(124, true);
            q125 = new Estado(125);
            q126 = new Estado(126);
            q127 = new Estado(127);
            q128 = new Estado(128, true);

            q129 = new Estado(129);
            q130 = new Estado(130);
            q131 = new Estado(131);
            q132 = new Estado(132, true);

            q133 = new Estado(133);
            q134 = new Estado(134);
            q135 = new Estado(135);
            q136 = new Estado(136);
            q137 = new Estado(137, true);

            q138 = new Estado(138);
            q139 = new Estado(139);
            q140 = new Estado(140);
            q141 = new Estado(141);
            q142 = new Estado(142);
            q143 = new Estado(143, true);

            q144 = new Estado(144);
            q145 = new Estado(145);
            q146 = new Estado(146);
            q147 = new Estado(147);
            q148 = new Estado(148);
            q149 = new Estado(149);
            q150 = new Estado(150, true);



        }
        private void DefinirTransiciones()
        {
            // q0, q1
            q0.AgregarTransicion('$', q7);
            q0.AgregarTransicion('#', q26);
            q0.AgregarTransicion(' ', q0);
            q0.AgregarTransicion('\n', q0);
            q0.AgregarTransicion('+', q1);
            q0.AgregarTransicion('-', q1);
            q0.AgregarTransicion('0', q4);
            for (char c = '1'; c <= '9'; c++)
            {
                q0.AgregarTransicion(c, q2);
                q1.AgregarTransicion(c, q2);
            }
            q0.AgregarTransicion('"', q9);
            q0.AgregarTransicion('\'', q10);
            q0.AgregarTransicion('.', q14);
            q0.AgregarTransicion(',', q14);
            q0.AgregarTransicion(';', q14);
            q0.AgregarTransicion(':', q14);
            q0.AgregarTransicion('>', q16);
            q0.AgregarTransicion('<', q16);
            q0.AgregarTransicion('^', q15);
            q0.AgregarTransicion('*', q15);
            q0.AgregarTransicion('/', q27);
            q0.AgregarTransicion('=', q24);
            q0.AgregarTransicion('(', q25);
            q0.AgregarTransicion(')', q25);
            q0.AgregarTransicion('[', q25);
            q0.AgregarTransicion(']', q25);
            q0.AgregarTransicion('{', q25);
            q0.AgregarTransicion('}', q25);
            q0.AgregarTransicion('A', q18);
            q0.AgregarTransicion('O', q21);
            q0.AgregarTransicion('|', q19);
            q0.AgregarTransicion('&', q20);
            q0.AgregarTransicion('e', q33);

            // q1
            q1.AgregarTransicion('0', q4);
            q1.AgregarTransicion(' ', q0);
            q1.AgregarTransicion('\n', q0);

            // q2
            q2.AgregarTransicion('.', q5);
            q2.AgregarTransicion(' ', q0);
            q2.AgregarTransicion('\n', q0);

            // q3
            q3.AgregarTransicion('.', q5);
            q3.AgregarTransicion(' ', q0);
            q3.AgregarTransicion('\n', q0);

            // q4
            q4.AgregarTransicion(' ', q0);
            q4.AgregarTransicion('\n', q0);
            q4.AgregarTransicion('.', q5);

            // q6
            q6.AgregarTransicion('\n', q0);
            q6.AgregarTransicion(' ', q0);

            // q8
            q8.AgregarTransicion('\n', q0);
            q8.AgregarTransicion(' ', q0);
            
            // q7, q8, q2
            for (char c = 'a'; c <= 'z'; c++)
            {
                q7.AgregarTransicion(c, q8);
                q8.AgregarTransicion(c, q8);
            }
            for (char c = 'A'; c <= 'Z'; c++)
            {
                q7.AgregarTransicion(c, q8);
                q8.AgregarTransicion(c, q8);
            }
            for (char c = '0'; c <= '9'; c++)
            {
                q7.AgregarTransicion(c, q8);
                q8.AgregarTransicion(c, q8);
                q2.AgregarTransicion(c, q3);
                q3.AgregarTransicion(c, q3);
                q5.AgregarTransicion(c, q6);
                q6.AgregarTransicion(c, q6);
            }
            q7.AgregarTransicion('_', q8);
            q7.AgregarTransicion('-', q8);
            q7.AgregarTransicion(' ', q999);
            q8.AgregarTransicion('_', q8);
            q8.AgregarTransicion('-', q8);
            q8.AgregarTransicion(' ', q0);
            q8.AgregarTransicion('\n', q0);

            // q9
            q9.AgregarTransicion(' ', q11);
            q9.AgregarTransicion('\n', q11);
            q9.AgregarTransicion('"', q13);

            // q10
            q10.AgregarTransicion(' ', q12);
            q10.AgregarTransicion('\n', q12);
            q10.AgregarTransicion('\'', q13);

            // q11
            q11.AgregarTransicion('"', q13);
            q11.AgregarTransicion(' ', q11);
            q11.AgregarTransicion('\n', q11);

            // q12
            q12.AgregarTransicion('\'', q13);
            q12.AgregarTransicion(' ', q12);
            q12.AgregarTransicion('\n', q12);

            // q13
            q13.AgregarTransicion(' ', q0);
            q13.AgregarTransicion('\n', q0);

            // q14
            q14.AgregarTransicion(' ', q0);
            q14.AgregarTransicion('\n', q0);

            // q5
            q15.AgregarTransicion(' ', q0);
            q15.AgregarTransicion('\n', q0);

            // q16
            q16.AgregarTransicion('=', q17);
            q16.AgregarTransicion(' ', q0);
            q16.AgregarTransicion('\n', q0);

            // q17
            q17.AgregarTransicion(' ', q0);
            q17.AgregarTransicion('\n', q0);

            // q18
            q18.AgregarTransicion('N', q22);

            // q19
            q19.AgregarTransicion('|', q23);

            // q20
            q20.AgregarTransicion('&', q23);

            // q21
            q21.AgregarTransicion('R', q23);

            // q22
            q22.AgregarTransicion('D', q23);

            // q23
            q23.AgregarTransicion(' ', q0);
            q23.AgregarTransicion('\n', q0);

            // q24
            q24.AgregarTransicion(' ', q0);
            q24.AgregarTransicion('\n', q0);

            // q25
            q25.AgregarTransicion(' ', q0);
            q25.AgregarTransicion('\n', q0);

            // q26, q9, q10, q11, q12, q28, q29
            for (int i = 0x00E0; i <= 0x017F; i++)
            {
                char c = (char)i;
                if (!char.IsControl(c) && c != '\n' && c != '\r' || c == '\t')
                {
                    q26.AgregarTransicion(c, q26);
                    q9.AgregarTransicion(c, q11);
                    q11.AgregarTransicion(c, q11);
                    q10.AgregarTransicion(c, q12);
                    q12.AgregarTransicion(c, q12);
                    if(c != '*'){
                        q28.AgregarTransicion(c, q29);
                        q29.AgregarTransicion(c, q29);  
                    }
                    
                }
            }
            for (char c = (char)32; c <= (char)126; c++)
            {
                if ((!char.IsControl(c) && c != '\n' && c != '\r') || c == '\t') 
                {
                    q26.AgregarTransicion(c, q26);
                    q9.AgregarTransicion(c, q11);
                    q11.AgregarTransicion(c, q11);
                    q10.AgregarTransicion(c, q12);
                    q12.AgregarTransicion(c, q12);
                    if(c != '*'){
                        q28.AgregarTransicion(c, q29);
                        q29.AgregarTransicion(c, q29);  
                    }
                }
            }
            q26.AgregarTransicion('\n', q0);

            //q27
            q27.AgregarTransicion('*', q28);
            q27.AgregarTransicion(' ', q0);
            q27.AgregarTransicion('\n', q0);

            // q28
            q28.AgregarTransicion(' ', q29);
            q28.AgregarTransicion('\n', q29);

            // q29
            q29.AgregarTransicion(' ', q29);
            q29.AgregarTransicion('\n', q29);
            q29.AgregarTransicion('*', q30);

            // q30
            q30.AgregarTransicion('/', q31);

            // q31
            q31.AgregarTransicion(' ', q0);
            q31.AgregarTransicion('\n', q0);

            // Error
            q999.AgregarTransicion(' ', q0);
            q999.AgregarTransicion('\n', q0);
            for (int i = 0x00E0; i <= 0x017F; i++)
            {
                char c = (char)i;
                if (!char.IsControl(c) && c != '\r')
                {
                    q999.AgregarTransicion(c, q999);
                }
            }
            for (char c = (char)32; c <= (char)126; c++)
            {
                if ((!char.IsControl(c) && c != '\r')) 
                {
                    q999.AgregarTransicion(c, q999);
                }
            }

            // Palabras reservadas
            q33.AgregarTransicion('x', q34);
            q34.AgregarTransicion('t', q35);
            q35.AgregarTransicion('e', q36);
            q36.AgregarTransicion('n', q37);
            q37.AgregarTransicion('d', q38);
            q38.AgregarTransicion('s', q32);
            q33.AgregarTransicion('l', q39);
            q39.AgregarTransicion('s', q40);
            q40.AgregarTransicion('e', q41);
            q32.AgregarTransicion(' ', q0);
            q32.AgregarTransicion('\n', q0);
            q41.AgregarTransicion(' ', q0);
            q41.AgregarTransicion('\n', q0);
            q0.AgregarTransicion('t', q42);
            q42.AgregarTransicion('h', q43);
            q43.AgregarTransicion('e', q44);
            q44.AgregarTransicion('n', q45);
            q42.AgregarTransicion('r', q46);
            q46.AgregarTransicion('u', q47);
            q47.AgregarTransicion('e', q48);
            q0.AgregarTransicion('f', q49);
            q49.AgregarTransicion('i', q50);
            q50.AgregarTransicion('n', q51);
            q51.AgregarTransicion('a', q52);
            q52.AgregarTransicion('l', q53);
            q49.AgregarTransicion('l', q54);
            q54.AgregarTransicion('o', q55);
            q55.AgregarTransicion('a', q56);
            q56.AgregarTransicion('t', q57);
            q49.AgregarTransicion('o', q58);
            q58.AgregarTransicion('r', q59);
            q49.AgregarTransicion('a', q60);
            q60.AgregarTransicion('l', q61);
            q61.AgregarTransicion('s', q62);
            q62.AgregarTransicion('e', q63);
            q0.AgregarTransicion('c', q64);
            q64.AgregarTransicion('a', q65);
            q65.AgregarTransicion('s', q66);
            q66.AgregarTransicion('e', q67);
            q64.AgregarTransicion('l', q68);
            q68.AgregarTransicion('a', q69);
            q69.AgregarTransicion('s', q70);
            q70.AgregarTransicion('s', q71);
            q0.AgregarTransicion('i', q93);
            q93.AgregarTransicion('f', q72);
            q93.AgregarTransicion('n', q85);
            q85.AgregarTransicion('t', q86);
            q86.AgregarTransicion('e', q87);
            q87.AgregarTransicion('r', q88);
            q88.AgregarTransicion('f', q89);
            q89.AgregarTransicion('a', q90);
            q90.AgregarTransicion('c', q91);
            q91.AgregarTransicion('e', q92);
            q93.AgregarTransicion('m', q80);
            q80.AgregarTransicion('p', q81);
            q81.AgregarTransicion('o', q82);
            q82.AgregarTransicion('r', q83);
            q83.AgregarTransicion('t', q84);
            q81.AgregarTransicion('l', q73);
            q73.AgregarTransicion('e', q74);
            q74.AgregarTransicion('m', q75);
            q75.AgregarTransicion('e', q76);
            q76.AgregarTransicion('n', q77);
            q77.AgregarTransicion('t', q78);
            q78.AgregarTransicion('s', q79);
            q0.AgregarTransicion('b', q144);
            q144.AgregarTransicion('o', q145);
            q145.AgregarTransicion('o', q146);
            q146.AgregarTransicion('l', q147);
            q147.AgregarTransicion('e', q148);
            q148.AgregarTransicion('a', q149);
            q149.AgregarTransicion('n', q150);
            q0.AgregarTransicion('r', q138);
            q138.AgregarTransicion('e', q139);
            q139.AgregarTransicion('t', q140);
            q140.AgregarTransicion('u', q141);
            q141.AgregarTransicion('r', q142);
            q142.AgregarTransicion('n', q143);
            q0.AgregarTransicion('w', q133);
            q133.AgregarTransicion('h', q134);
            q134.AgregarTransicion('i', q135);
            q135.AgregarTransicion('l', q136);
            q136.AgregarTransicion('e', q137);
            q0.AgregarTransicion('v', q129);
            q129.AgregarTransicion('o', q130);
            q130.AgregarTransicion('i', q131);
            q131.AgregarTransicion('d', q132);
            q0.AgregarTransicion('s', q119);
            q119.AgregarTransicion('t', q120);
            q120.AgregarTransicion('a', q121);
            q121.AgregarTransicion('t', q122);
            q122.AgregarTransicion('i', q123);
            q123.AgregarTransicion('c', q124);
            q119.AgregarTransicion('h', q125);
            q125.AgregarTransicion('o', q126);
            q126.AgregarTransicion('r', q127);
            q127.AgregarTransicion('t', q128);
            q0.AgregarTransicion('p', q94);
            q94.AgregarTransicion('u', q95);
            q95.AgregarTransicion('b', q96);
            q96.AgregarTransicion('l', q97);
            q97.AgregarTransicion('i', q98);
            q98.AgregarTransicion('c', q99);
            q94.AgregarTransicion('r', q100);
            q100.AgregarTransicion('i', q101);
            q101.AgregarTransicion('v', q102);
            q102.AgregarTransicion('a', q103);
            q103.AgregarTransicion('t', q104);
            q104.AgregarTransicion('e', q105);
            q100.AgregarTransicion('o', q106);
            q106.AgregarTransicion('t', q107);
            q107.AgregarTransicion('e', q108);
            q108.AgregarTransicion('c', q109);
            q109.AgregarTransicion('t', q110);
            q110.AgregarTransicion('e', q111);
            q111.AgregarTransicion('d', q112);
            q94.AgregarTransicion('a', q113);
            q113.AgregarTransicion('c', q114);
            q114.AgregarTransicion('k', q115);
            q115.AgregarTransicion('a', q116);
            q116.AgregarTransicion('g', q117);
            q117.AgregarTransicion('e', q118);

            q32.AgregarTransicion(' ', q0);
            q32.AgregarTransicion('\n', q0);
            q41.AgregarTransicion(' ', q0);
            q41.AgregarTransicion('\n', q0);
            q45.AgregarTransicion(' ', q0);
            q45.AgregarTransicion('\n', q0);
            q48.AgregarTransicion(' ', q0);
            q48.AgregarTransicion('\n', q0);
            q63.AgregarTransicion(' ', q0);
            q63.AgregarTransicion('\n', q0);
            q59.AgregarTransicion(' ', q0);
            q59.AgregarTransicion('\n', q0);
            q57.AgregarTransicion(' ', q0);
            q57.AgregarTransicion('\n', q0);
            q53.AgregarTransicion(' ', q0);
            q53.AgregarTransicion('\n', q0);
            q71.AgregarTransicion(' ', q0);
            q71.AgregarTransicion('\n', q0);
            q67.AgregarTransicion(' ', q0);
            q67.AgregarTransicion('\n', q0);
            q79.AgregarTransicion(' ', q0);
            q79.AgregarTransicion('\n', q0);
            q84.AgregarTransicion(' ', q0);
            q84.AgregarTransicion('\n', q0);
            q72.AgregarTransicion(' ', q0);
            q72.AgregarTransicion('\n', q0);
            q92.AgregarTransicion(' ', q0);
            q92.AgregarTransicion('\n', q0);
            q86.AgregarTransicion(' ', q0);
            q86.AgregarTransicion('\n', q0);
            q150.AgregarTransicion(' ', q0);
            q150.AgregarTransicion('\n', q0);
            q143.AgregarTransicion(' ', q0);
            q143.AgregarTransicion('\n', q0);
            q137.AgregarTransicion(' ', q0);
            q137.AgregarTransicion('\n', q0);
            q132.AgregarTransicion(' ', q0);
            q132.AgregarTransicion('\n', q0);
            q124.AgregarTransicion(' ', q0);
            q124.AgregarTransicion('\n', q0);
            q128.AgregarTransicion(' ', q0);
            q128.AgregarTransicion('\n', q0);
            q99.AgregarTransicion(' ', q0);
            q99.AgregarTransicion('\n', q0);
            q105.AgregarTransicion(' ', q0);
            q105.AgregarTransicion('\n', q0);
            q112.AgregarTransicion(' ', q0);
            q112.AgregarTransicion('\n', q0);
            q118.AgregarTransicion(' ', q0);
            q118.AgregarTransicion('\n', q0);


        }

    }
}
