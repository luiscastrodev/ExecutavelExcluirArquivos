using System;

namespace ExclusaoArquivosPorExtensao
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputUsuario;
            do
            {
                inputUsuario = MostaMenu();

                if (inputUsuario == 1)
                {
                    bool extensaoValida = false;

                    while (!extensaoValida)
                    {
                        Console.WriteLine("informe a Extensão do arquivo ex: mp3(Caso tenha muitos informe separado por virgula mp3, jpg, png)");

                        string extensao = Console.ReadLine();

                        if (string.IsNullOrEmpty(extensao))
                        {
                            Console.Clear();

                            Console.WriteLine("#############################");
                            Console.WriteLine("informe um formato valido!!!");
                            Console.WriteLine("#############################");
                        }
                        else
                        {
                            extensaoValida = true;

                            bool diretorioValido = false;

                            while (!diretorioValido)
                            {
                                Console.Clear();

                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("##############################################################");
                                Console.WriteLine("#####ATENÇÃO EXCLUIRA TODOS ARQUIVOS INCLUINDO SUBPASTAS######");
                                Console.WriteLine("###############################################################");
                                Console.WriteLine(@"Ex: D:\Arquivos");
                                Console.WriteLine("Informe o diretorio para exluir os arquivos:");

                                string diretorio = Console.ReadLine();

                                if (string.IsNullOrEmpty(diretorio))
                                {
                                    Console.WriteLine("#############################");
                                    Console.WriteLine("informe um diretorio valido!!!");
                                    Console.WriteLine("#############################");

                                }
                                else
                                {
                                    diretorioValido = true;

                                }
                            }


                        }
                    }
                }
                else
                {
                    Console.WriteLine("Selecione uma opção Valida! 1 ou 5");
                }

            } while (inputUsuario != 5);



        }

        static public int MostaMenu()
        {
            try
            {
                Console.WriteLine("Arquivo Manager");
                Console.WriteLine();
                Console.WriteLine("1. Iniciar");
                Console.WriteLine("5. Exit");
                var result = Console.ReadLine();
                return Convert.ToInt32(result);
            }
            catch
            {
                return 0;
            }

        }
    }
}
