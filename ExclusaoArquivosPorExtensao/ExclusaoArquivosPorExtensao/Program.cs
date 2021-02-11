using System;
using System.IO;

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
                        Console.WriteLine("informe a Extensão do arquivo ex: .mp3");

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
                                    Console.WriteLine();
                                    Console.WriteLine("Prcessando..............");
                                    Console.WriteLine();

                                    try
                                    {
                                        System.IO.DirectoryInfo di = new DirectoryInfo(diretorio);

                                        foreach (FileInfo file in di.GetFiles())
                                        {
                                            if(file.Extension.ToLower() == extensao.ToLower())
                                            {
                                                file.Delete();
                                                Console.WriteLine("Pasta " + di.FullName);
                                                Console.WriteLine(file.Name);
                                                Console.WriteLine("#############################");
                                            }
                                          
                                        }
                                        foreach (DirectoryInfo dir in di.GetDirectories())
                                        {
                                            foreach (FileInfo fileDir in dir.GetFiles())
                                            {
                                                if (fileDir.Extension.ToLower() == extensao.ToLower())
                                                {
                                                    fileDir.Delete();
                                                    Console.WriteLine("Pasta " + di.FullName);
                                                    Console.WriteLine(fileDir.Name);
                                                    Console.WriteLine("#############################");
                                                }
                                                   
                                            }
                                        }

                                        Console.WriteLine("#############################");
                                        Console.WriteLine("Arquivos excluidos com SUCESSO!!!");
                                        Console.WriteLine("#############################");

                                        diretorioValido = true;
                                    }
                                    catch(Exception e)
                                    {
                                        Console.WriteLine("#############################");
                                        Console.WriteLine("HOUVE UM ERRO !!!" + e.Message);
                                        Console.WriteLine("#############################");
                                    }
                                    

                                }
                            }


                        }
                    }
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
