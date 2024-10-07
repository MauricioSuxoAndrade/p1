namespace operaciones
{
    public class Operaciones
    {
        public double Sumar(double a, double b)
        {
            return a + b;
        }

        public double Restar(double a, double b)
        {
            return a - b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public double Dividir(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Division entre cero.");
            return a / b;
        }
    }

    public class NotacionPrefija
    {
        private Operaciones operaciones;

        public NotacionPrefija()
        {
            operaciones = new Operaciones();
        }

        public double Evaluar(string expresion)
        {
            // Separar la expresión en tokens
            Stack<double> stack = new Stack<double>();
            string[] tokens = expresion.Split(' ');

            // Procesar los tokens en orden inverso (notación prefija)
            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                string token = tokens[i];

                if (EsOperador(token))
                {
                    // Extraer los operandos del stack
                    double op1 = stack.Pop();
                    double op2 = stack.Pop();

                    // Aplicar la operación correspondiente
                    double resultado = AplicarOperacion(token, op1, op2);

                    // Almacenar el resultado en el stack
                    stack.Push(resultado);
                }
                else
                {
                    // Si es un número, agregarlo al stack
                    stack.Push(Convert.ToDouble(token));
                }
            }

            // El resultado final estará en el stack
            return stack.Pop();
        }

        private bool EsOperador(string token)
        {
            return token == "+" || token == "-" || token == "*" || token == "/";
        }

        private double AplicarOperacion(string operador, double op1, double op2)
        {
            switch (operador)
            {
                case "+":
                    return operaciones.Sumar(op1, op2);
                case "-":
                    return operaciones.Restar(op1, op2);
                case "*":
                    return operaciones.Multiplicar(op1, op2);
                case "/":
                    return operaciones.Dividir(op1, op2);
                default:
                    throw new ArgumentException("Operador no válido: " + operador);
            }
        }
    }
}
