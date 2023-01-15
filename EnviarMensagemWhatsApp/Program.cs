using System;
using System.Threading;
using WindowsInput;

namespace EnviarMensagemWhatsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mensagem = "";
            int quantidadeMensagem = 0;
            int contador = 10;

            var inputSimulator = new InputSimulator();

            Console.WriteLine("Qual mensagem deseja enviar ?");
            mensagem = Console.ReadLine();

            Console.WriteLine("Quantas vezes deseja enviar essa mensagem ?");
            quantidadeMensagem = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("------------------> " + (contador - i));
                Thread.Sleep(1000);
            }

            Console.WriteLine("Já!!!!!!!!!!");

            for (int i = 0; i < quantidadeMensagem; i++)
            {
                inputSimulator.Keyboard.TextEntry(mensagem);
                inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.RETURN);
                Thread.Sleep(250);

                Console.WriteLine("MENSAGEM ENVIADA COM SUCESSO!");
            }
        }
    }
}
