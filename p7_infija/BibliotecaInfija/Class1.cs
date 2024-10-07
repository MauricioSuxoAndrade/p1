namespace BibliotecaInfija
{
    public class Infija
    {
        // Precedencia de operadores
        static int Precedencia(char operador)
        {
            switch (operador)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                default:
                    return 0;
            }
        }

        // Verifica si es un operador
        static bool EsOperador(char c)
        {
            return (c == '+' || c == '-' || c == '*' || c == '/');
        }

        // Convertir expresión infija a postfija
        public string Infijo(string expresion)
        {
            Stack<char> pila = new Stack<char>();
            string resultado = "";

            for (int i = 0; i < expresion.Length; i++)
            {
                char c = expresion[i];

                // Si es un dígito, lo agregamos al resultado
                if (char.IsDigit(c))
                {
                    resultado += c;
                }
                // Si es un operador
                else if (EsOperador(c))
                {
                    // Desapilamos todos los operadores con mayor o igual precedencia
                    while (pila.Count > 0 && Precedencia(pila.Peek()) >= Precedencia(c))
                    {
                        resultado += pila.Pop();
                    }
                    // Apilamos el operador actual
                    pila.Push(c);
                }
            }

            // Desapilar los operadores restantes
            while (pila.Count > 0)
            {
                resultado += pila.Pop();
            }

            return resultado;
        }

        // Evaluar expresión postfija
        public int Evaluar(string expresionPostfija)
        {
            Stack<int> pila = new Stack<int>();

            for (int i = 0; i < expresionPostfija.Length; i++)
            {
                char c = expresionPostfija[i];

                // Si es un dígito, lo apilamos
                if (char.IsDigit(c))
                {
                    pila.Push(int.Parse(c.ToString()));
                }
                // Si es un operador, desapilamos dos operandos y aplicamos el operador
                else if (EsOperador(c))
                {
                    int op2 = pila.Pop();
                    int op1 = pila.Pop();

                    switch (c)
                    {
                        case '+':
                            pila.Push(op1 + op2);
                            break;
                        case '-':
                            pila.Push(op1 - op2);
                            break;
                        case '*':
                            pila.Push(op1 * op2);
                            break;
                        case '/':
                            pila.Push(op1 / op2);
                            break;
                    }
                }
            }

            // El último valor en la pila es el resultado final
            return pila.Pop();
        }
    }
}
