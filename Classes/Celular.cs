using System;

namespace Atividade_Celular.Classes
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado;

        public bool desligado;
        public bool mensagens;
        public bool ligacoes;

        public void Mensagem(bool mensagem){

            if(mensagem == true){

                Console.WriteLine("Escreva a mensagem: ");
                string mensagens = Console.ReadLine();

                Console.WriteLine("Você enviou um Bom Dia para sua Tia Favorita!");

            }else{

                Console.WriteLine("Você pode voltar sempre que quiser para ver suas mensagens!");

            }

        }

        public void FazerLigacao(bool ligacao){

            if(ligacao == true){
                
            Console.WriteLine("Para quem?");
            string quem = Console.ReadLine();

            Console.WriteLine("Discando...");

            Console.WriteLine($"A(O) {quem} Atendeu e te desejou um Bom Dia :D");

            }else{

                Console.WriteLine("Outro dia vc liga!");

            }

        }
    }
}