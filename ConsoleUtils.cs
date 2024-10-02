using System.ComponentModel.DataAnnotations;

namespace Biblioteca
{
    public class ConsoleUtils
    {
        /// <summary>
        /// Escreve um texto destacado e centralizado
        /// </summary>
        /// <param name="text"> O texto a ser escrito </param>
        public static void WriteTitle(string text) 
        {
            string formatedText = text;
            while (formatedText.Length < 120) 
            {
                formatedText = " " + formatedText;
                if (formatedText.Length == 120) break;
                formatedText = formatedText + " ";
            }

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(formatedText);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Cria no console um componente visual semelhante a um campo de texto editavel do windows
        /// </summary>
        /// <param name="fieldName">O nome do campo a ser preenchido.</param>
        /// <param name="fieldSize">O tamanho (em caracteres) da àrea destacada como editavel para digitação.</param>
        /// <returns>Retorna o texto digitado pelo usuário</returns>
        public static string textField(string fieldName, int fieldSize = 30) 
        {
            Console.Write(fieldName);
            Console.Write(": ");
            (int left, int top) = Console.GetCursorPosition();
            Console.BackgroundColor= ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = 0; i < fieldSize; i++) { Console.Write(" "); }
            Console.SetCursorPosition(left, top);
            string? result = Console.ReadLine();
            if (result == null) result = string.Empty;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\n");
            return result;
        }

        /// <summary>
        /// Cria no console um componente visual semelhante a um campo numérico rolável
        /// garante que o retorno seja sempre um numero inteiro
        /// quando o usuário usar as setas horizontais ← → ele altera o valor de 1 em 1
        /// quando o usuário usar as setas verticais ↑ ↓ Ele altera o valor de 10 em 10
        /// </summary>
        /// <param name="fieldName">O nome do campo a ser preenchido</param>
        /// <param name="fieldSize">O tamanho da área destacada como editavel</param>
        /// <param name="startValue">O valor inicial a ser apresentado pelo campo</param>
        /// <returns>Retorna um valor inteiro escolhido pelo usuário</returns>
        public static int numericField(string fieldName, int fieldSize = 30, int startValue = 1900) 
        {
            int value = startValue;
            (int left, int top) = Console.GetCursorPosition();

            while (true)
            {
                Console.SetCursorPosition((int)left, (int)top);
                Console.Write(fieldName);
                Console.Write(": < ");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                string stringValue = value.ToString();
                Console.Write(stringValue);
                for (int i = 0; i < fieldSize - stringValue.Length; i++) { Console.Write(" "); }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" >");
                var input = Console.ReadKey(true);

                if (input.Key == ConsoleKey.UpArrow) value+=10;
                if (input.Key == ConsoleKey.RightArrow) value++;
                if (input.Key == ConsoleKey.LeftArrow) value--;
                if (input.Key == ConsoleKey.DownArrow) value-=10;
                if (input.Key == ConsoleKey.Enter) break;
            }
            Console.Write("\n\n");
            return value;
        }

        /// <summary>
        /// Cria no console um componente visual semelhante a um campo numérico rolável com parte decimal
        /// garante que o retorno seja sempre um numero com casas decimais
        /// quando o usuário usar as setas horizontais ← → ele altera a parte decimal
        /// quando o usuário usar as setas verticais ↑ ↓ Ele altera a parte inteira
        /// </summary>
        /// <param name="fieldName">O nome do campo a ser preenchido</param>
        /// <param name="fieldSize">O tamanho da área destacada como editavel</param>
        /// <param name="startValue">O valor inicial a ser apresentado pelo campo</param>
        /// <returns>Retorna um valor com casas decimais escolhido pelo usuário</returns>
        public static float decimalField(string fieldName, int fieldSize = 30, float startValue = 0) 
        {
            float value = startValue;
            (int left, int top) = Console.GetCursorPosition();

            while (true)
            {
                Console.SetCursorPosition((int)left, (int)top);
                Console.Write(fieldName);
                Console.Write(": < ");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                string stringValue = value.ToString("N");
                Console.Write(stringValue);
                for (int i = 0; i < fieldSize - stringValue.Length; i++) { Console.Write(" "); }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" >");
                var input = Console.ReadKey(true);

                if (input.Key == ConsoleKey.UpArrow)    value += 1;
                if (input.Key == ConsoleKey.RightArrow) value += 0.01f;
                if (input.Key == ConsoleKey.LeftArrow)  value -= 0.01f;
                if (input.Key == ConsoleKey.DownArrow)  value -= 1;
                if (input.Key == ConsoleKey.Enter)      break;
            }
            Console.Write("\n\n");
            return value;
        }
    }
}
