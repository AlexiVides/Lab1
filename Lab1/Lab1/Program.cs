using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            string municipio;
            string departamento;
            int longitud = 100, indice = 0, opc;
            

            string[] RegPersona = new string[longitud];

            Console.WriteLine("Bienvenido al sistema");

            

            int x = 0;
            while (x == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("---------------Menu---------------");
                Console.WriteLine("1- Ingresar usuario");
                Console.WriteLine("2- Mostrar usuario registrados");
                Console.WriteLine("3- Salir");
                opc = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (opc == 1)
                {
                    Console.WriteLine("Digita tus nombres: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Digita tu edad: ");
                    edad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digita nombre del departamento: ");
                    Console.WriteLine("1- Ahuachapan");
                    Console.WriteLine("2- Chalatenango");
                    Console.WriteLine("3- Cabañas");
                    Console.WriteLine("4- Cusclatlan");
                    Console.WriteLine("5- La Libertad");
                    Console.WriteLine("6- San Miguel");
                    departamento = Console.ReadLine();
                    Console.WriteLine("");

                    if (departamento == "Ahuachapan")
                    {
                        
                        Console.WriteLine("Digite el nombre del municipio");
                        Console.WriteLine("- Ahuachapan");
                        Console.WriteLine("- Apaneca");
                        Console.WriteLine("- Atiquizaya");
                        Console.WriteLine("- Concepcion de Ataco");
                        Console.WriteLine("- El refugio");
                        Console.WriteLine("- Jujutla");
                        Console.WriteLine("- San lorenzo");
                        Console.WriteLine("- Turin");
                        municipio = Console.ReadLine();
                        Console.WriteLine("");

                        if (indice < RegPersona.Length)
                        {
                            RegPersona[indice] = nombre;
                            RegPersona[indice + 1] = Convert.ToString(edad);
                            RegPersona[indice + 2] = departamento;
                            RegPersona[indice + 3] = municipio;
                            indice += 4;
                        }
                        else
                        {
                            Console.WriteLine("Almacemiento lleno!!");
                        }

                    }
                    else if (departamento == "Chalatenango")
                    {
                        
                        Console.WriteLine("Digite el nombre del municipio");
                        Console.WriteLine("- Agua Caliente");
                        Console.WriteLine("- Ojos de Agua");
                        Console.WriteLine("- Arcatao");
                        Console.WriteLine("- Chalatenango");
                        Console.WriteLine("- Tejutla");
                        Console.WriteLine("- Las Vueltas");
                        Console.WriteLine("- La Laguna");
                        Console.WriteLine("- El Carrizal");
                        municipio = Console.ReadLine();
                        Console.WriteLine("");

                        if (indice < RegPersona.Length)
                        {
                            RegPersona[indice] = nombre;
                            RegPersona[indice + 1] = Convert.ToString(edad);
                            RegPersona[indice + 2] = departamento;
                            RegPersona[indice + 3] = municipio;
                            indice += 4;
                        }
                        else
                        {
                            Console.WriteLine("Almacemiento lleno!!");
                        }

                    }
                    else if (departamento == "Cabañas")
                    {
                        
                        Console.WriteLine("Digite el nombre del municipio");
                        Console.WriteLine("- Cinquera");
                        Console.WriteLine("- Dolores");
                        Console.WriteLine("- Ilobasco");
                        Console.WriteLine("- Jutiapa");
                        Console.WriteLine("- San Isidro");
                        Console.WriteLine("- Sensuntepeque");
                        Console.WriteLine("- Tejutepeque");
                        Console.WriteLine("- Victoria");
                        municipio = Console.ReadLine();
                        Console.WriteLine("");

                        if (indice < RegPersona.Length)
                        {
                            RegPersona[indice] = nombre;
                            RegPersona[indice + 1] = Convert.ToString(edad);
                            RegPersona[indice + 2] = departamento;
                            RegPersona[indice + 3] = municipio;
                            indice += 4;
                        }
                        else
                        {
                            Console.WriteLine("Almacemiento lleno!!");
                        }

                    }
                    else if (departamento == "Cusclatlan")
                    {
                        
                        Console.WriteLine("Digite el nombre del municipio");
                        Console.WriteLine("- Candelaria");
                        Console.WriteLine("- Cojutepeque");
                        Console.WriteLine("- El Carmen");
                        Console.WriteLine("- El Rosario");
                        Console.WriteLine("- San Cristobal");
                        Console.WriteLine("- San Ramon");
                        Console.WriteLine("- Suchitoto");
                        Console.WriteLine("- Tenancinago");
                        municipio = Console.ReadLine();
                        Console.WriteLine("");

                        if (indice < RegPersona.Length)
                        {
                            RegPersona[indice] = nombre;
                            RegPersona[indice + 1] = Convert.ToString(edad);
                            RegPersona[indice + 2] = departamento;
                            RegPersona[indice + 3] = municipio;
                            indice += 4;
                        }
                        else
                        {
                            Console.WriteLine("Almacemiento lleno!!");
                        }

                    }
                    else if (departamento == "La Libertad")
                    {
                        
                        Console.WriteLine("Digite el nombre del municipio");
                        Console.WriteLine("- Antiguo Cuscatlan");
                        Console.WriteLine("- Cuidad Arce");
                        Console.WriteLine("- Colon");
                        Console.WriteLine("- Comasagua");
                        Console.WriteLine("- Huizucar");
                        Console.WriteLine("- Jayaqe");
                        Console.WriteLine("- Jicalapa");
                        Console.WriteLine("- La Libertad");
                        municipio = Console.ReadLine();
                        Console.WriteLine("");

                        if (indice < RegPersona.Length)
                        {
                            RegPersona[indice] = nombre;
                            RegPersona[indice + 1] = Convert.ToString(edad);
                            RegPersona[indice + 2] = departamento;
                            RegPersona[indice + 3] = municipio;
                            indice += 4;
                        }
                        else
                        {
                            Console.WriteLine("Almacemiento lleno!!");
                        }

                    }
                    else if (departamento == "San Miguel")
                    {
                       
                        Console.WriteLine("Digite el nombre del municipio");
                        Console.WriteLine("- Carolina");
                        Console.WriteLine("- Chinameca");
                        Console.WriteLine("- Ciudad Barrios");
                        Console.WriteLine("- El transito");
                        Console.WriteLine("- Lolotique");
                        Console.WriteLine("- Moncagua");
                        Console.WriteLine("- Quelepa");
                        Console.WriteLine("- San Jorge");
                        municipio = Console.ReadLine();
                        Console.WriteLine("");

                        if (indice < RegPersona.Length)
                        {
                            RegPersona[indice] = nombre;
                            RegPersona[indice + 1] = Convert.ToString(edad);
                            RegPersona[indice + 2] = departamento;
                            RegPersona[indice + 3] = municipio;
                            indice += 4;
                        }
                        else
                        {
                            Console.WriteLine("Almacemiento lleno!!");
                        }


                    }
                    else
                    {
                        Console.WriteLine("No existe ese Municipío");
                    }

                    
                }
                else if (opc == 2)
                {
                    Console.WriteLine("Datos");

                    for (int i = 0; i < indice; i += 4)
                    {
                        Console.WriteLine(RegPersona[i + 1] + " " + RegPersona[i + 2] + " " + RegPersona[i + 3]);
                    }

                }
                else if (opc == 3)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("No existe esa opcion");
                }
            }
        }
    }
}
