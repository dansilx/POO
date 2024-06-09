﻿using System;
using System.Collections.Generic;

namespace TrabalhoVendaFinal
{
    public class Program
    {
        static List<Produto> produtos = new List<Produto>();
        static List<Venda> vendas = new List<Venda>();
        static List<Pagamento> pagamentos = new List<Pagamento>();



        static void Main()
        {
            while (true)
            {
                System.Console.WriteLine("--------------------------------------------------");
                System.Console.WriteLine("1. Adicionar Produto");
                System.Console.WriteLine("2. Listar Produtos");
                System.Console.WriteLine("3. Registrar Venda");
                System.Console.WriteLine("4. Listar Vendas");
                System.Console.WriteLine("5. Listar Pagamentos");
                System.Console.WriteLine("6. Sair");
                System.Console.WriteLine("--------------------------------------------------");
                System.Console.Write("Escolha uma opção: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        AdicionarProduto();
                        break;
                    case "2":
                        ListarProdutos();
                        break;
                    case "3":
                        RegistrarVenda();
                        break;
                    case "4":
                        ListarVendas();
                        break;
                    case "5":
                        ListarPagamentos();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void AdicionarProduto()
        {
            System.Console.WriteLine("\nAdicionar Produto");
            System.Console.Write("\nCódigo: ");
            long codigo = long.Parse(Console.ReadLine());
            System.Console.Write("\nNome: ");
            string nome = Console.ReadLine();
            System.Console.Write("\nPreço: ");
            double preco = double.Parse(Console.ReadLine());
            System.Console.Write("\nEstoque: ");
            int estoque = int.Parse(Console.ReadLine());

            produtos.Add(new Produto(codigo, nome, preco, estoque));
            System.Console.WriteLine("\nProduto adicionado com sucesso!");
        }

        static void ListarProdutos()
        {
            System.Console.WriteLine("\nProdutos:");
            foreach (var produto in produtos)
            {
                produto.MostrarProduto();
            }
        }

        static void RegistrarVenda()
        {
            Venda venda = new Venda(DateTime.Now);
            while (true)
            {
                System.Console.Write("\nDigite o código do produto (ou 0 para finalizar a venda): ");
                long codigo = long.Parse(Console.ReadLine());
                if (codigo == 0) break;

                Produto produto = produtos.Find(p => p.Codigo == codigo);
                if (produto == null)
                {
                    System.Console.WriteLine("\nProduto não encontrado. Tente novamente.");
                    continue;
                }

                System.Console.Write("\nQuantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                if (quantidade > produto.Estoque)
                {
                    System.Console.WriteLine("\nQuantidade em estoque insuficiente. Tente novamente.");
                    continue;
                }

                ItemVenda item = new ItemVenda(produto, quantidade);
                venda.AdicionarItem(item);
                produto.RemoveEstoque(quantidade);

                System.Console.WriteLine("\nItem adicionado à venda.");
            }

            if (venda.ItensVenda.Count > 0)
            {
                vendas.Add(venda);
                System.Console.WriteLine($"\nVenda registrada com sucesso! Total a Pagar: {venda.Total}");

                System.Console.WriteLine("\nEscolha o método de pagamento:");
                System.Console.WriteLine("\n1. Espécie");
                System.Console.WriteLine("\n2. Cartão");
                System.Console.WriteLine("\n3. Cheque");
                string opcaoPagamento = Console.ReadLine();

                Pagamento pagamento = null;
                switch (opcaoPagamento)
                {
                    case "1":
                        System.Console.Write("\nQuantia recebida: ");
                        double quantia = 0;
                        while (quantia < venda.Total)
                        {
                            quantia = double.Parse(Console.ReadLine());
                            if (quantia < venda.Total)
                            {
                                System.Console.WriteLine("\nQuantia insuficiente. Tente novamente.");
                                System.Console.Write("\nSystem.Quantia recebida: ");
                            }
                        }
                        pagamento = new Especie(quantia, venda);
                        pagamentos.Add(pagamento);
                        break;
                    case "2":
                        System.Console.Write("\nDados da Transação: ");
                        string dadosTransacao = Console.ReadLine();
                        System.Console.Write("\nResultado da Transação: ");
                        int resultadoTransacao = int.Parse(Console.ReadLine());
                        pagamento = new Cartao(dadosTransacao, resultadoTransacao, venda);
                        pagamentos.Add(pagamento);
                        break;
                    case "3":
                        System.Console.Write("\nNúmero do Cheque: ");
                        long numeroCheque = long.Parse(Console.ReadLine());
                        bool validaData = false;
                        DateTime dataDeposito = DateTime.Now;
                        while (!validaData)
                        {
                            try
                            {
                                System.Console.Write("\nData de Depósito (dd/MM/yyyy): ");
                                dataDeposito = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                                validaData = true;
                            }
                            catch (Exception ex)
                            {
                                System.Console.WriteLine("\nData inválida. Tente novamente.");
                            }
                        }

                        System.Console.Write("\nSituação: ");
                        int situacao = int.Parse(Console.ReadLine());
                        pagamento = new Cheque(numeroCheque, dataDeposito, situacao, venda);
                        pagamentos.Add(pagamento);
                        break;
                    default:
                        System.Console.WriteLine("\nOpção de pagamento inválida.");
                        break;
                }

                if (pagamento != null)
                {
                    System.Console.WriteLine($"\nPagamento registrado com sucesso! Total pago: {pagamento.Total}");
                }System.
            } else {
                System.Console.WriteLine("\nNenhum item foi adicionado à venda.");
            }
        }

        static void ListarVendas()
        {
            System.Console.WriteLine("\nVendas:");
            foreach (Venda venda in vendas)
            {
                venda.exibirVenda();
            }
        }

        static void ListarPagamentos()
        {
            System.Console.WriteLine("\nPagamentos:");
            foreach (Pagamento pagto in pagamentos)
            {
                pagto.MostrarPagamento();
            }
        }
    }
}