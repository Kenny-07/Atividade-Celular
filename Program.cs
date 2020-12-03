using System;
using Atividade_Celular.Classes;

namespace Atividade_Celular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular1 = new Celular();
            int escolha;

            Console.Write("Insira a Cor do Celular: ");
            celular1.cor = Console.ReadLine();

            Console.Write("Insira o Modelo do Celular: ");
            celular1.modelo = Console.ReadLine();

            Console.Write("Insira o Tamanho do Celular (cm): ");
            celular1.tamanho = float.Parse(Console.ReadLine());

            Console.Write("O celular está ligado ?? ( S/N ) : ");
            string resposta = Console.ReadLine();

            do 
            {
                Console.WriteLine("=======================================================");
                Console.WriteLine("Bem-Vindo ao Celular do Back, escolha uma das opções : ");
                Console.WriteLine("[1] Realizar Ligação");
                Console.WriteLine("[2] Enviar Mensagem");
                Console.WriteLine("[3] Desligar");
                Console.WriteLine("[4] Informações do Celular");
                Console.WriteLine("=======================================================");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:

                        // Console.WriteLine("=======================================================");
                        // Console.WriteLine("Realizando Ligação para (Contato Especial)...");
                        // Console.WriteLine("Caiu na Caixa Postal");

                        Console.Write("Deseja fazer alguma ligação? S/N ");
                        string resposta2 = Console.ReadLine();

                        if(resposta2.ToLower() == "s"){

                        celular1.ligacoes = true;
                        celular1.FazerLigacao(celular1.ligacoes);

                        }else{
                            
                        celular1.ligacoes = false;
                        celular1.FazerLigacao(celular1.ligacoes);

                    }

                        break;

                    case 2:

                        // Console.WriteLine("=======================================================");
                        // Console.WriteLine("Enviando Mensagem para Grupo da Família...");
                        // Console.WriteLine("Você recebeu um 'BOM DIA' da sua Tia Favorita");

                        Console.Write("Deseja enviar alguma mensagem? S/N ");
                        string resp = Console.ReadLine();
                    
                        if(resp.ToLower() == "s"){

                        celular1.mensagens = true;
                        celular1.Mensagem(celular1.mensagens);

                        }else{

                        celular1.mensagens = false;
                        celular1.Mensagem(celular1.mensagens);

                    }

                        break;

                    case 3:

                        Console.WriteLine("=======================================================");
                        Console.WriteLine("Desligando Sistema Operacional");
                        Console.WriteLine("=======================================================");

                        break;

                    case 4:

                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("-----INFORMAÇÕES SOBRE O CELULAR-----");
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("COR: " + celular1.cor);
                        Console.WriteLine("MODELO: " + celular1.modelo);
                        Console.WriteLine("TAMANHO: " + celular1.tamanho);

                        break;
                    
                    default:

                        Console.WriteLine("=======================================================");
                        Console.WriteLine("Opção Invalida, tente novamente");
                        Console.WriteLine("=======================================================");

                        break;
                }
                
            } while (escolha != 3);
     
        }
    }
}
