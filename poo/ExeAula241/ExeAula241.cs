using System;
using System.IO;
using System.Globalization;
using ExeAula241.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ExeAula241
{
    class ExeAula241
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full path of input file: ");
            string path = Console.ReadLine();

            List<Product> productList = new List<Product>(); //criar lista de produtos, instanciar nova lista apos receber o conteudo do arquivo no path

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] productData = sr.ReadLine().Split(","); //criar vetor separando aonde existe ,
                    string name = productData[0];
                    double price = double.Parse(productData[1], CultureInfo.InvariantCulture);
                    productList.Add(new Product(name, price)); //adiciona na lista com os parametros que recebeu (name, price)
                }
            }

            var avg = productList.Select(p => p.ProductPrice).DefaultIfEmpty(0.0).Average(); //cria variavel avg, seleciona os preços e executa a função Average()
            Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = productList.Where(p => p.ProductPrice < avg).OrderByDescending(p => p.ProductName).Select(p => p.ProductName); //cria variavel names, restricao preço menor que a media e ordena pelo nome do maior pro menor
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
