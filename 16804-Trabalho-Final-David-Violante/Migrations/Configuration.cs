namespace _16804_Trabalho_Final_David_Violante.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_16804_Trabalho_Final_David_Violante.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(_16804_Trabalho_Final_David_Violante.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //#############################################################
            // criação das classes Equipamento, Modalidade, Fornecedor e NovosProdutos
            //#############################################################

            // Configuration --- SEED
            //=============================================================

            // ############################################################################################
            // adiciona Equipamento
            var equipamento = new List<Equipamento> {
            new Equipamento  {EquipamentoID=1,EquipamentoFK=1 },
            new Equipamento  {EquipamentoID=2, EquipamentoFK=1 },
            new Equipamento  {EquipamentoID=3, EquipamentoFK=1 },
            new Equipamento  {EquipamentoID=4, EquipamentoFK=2 },
            new Equipamento  {EquipamentoID=5, EquipamentoFK=2 },
            new Equipamento  {EquipamentoID=6, EquipamentoFK=2 },
            new Equipamento  {EquipamentoID=7,  EquipamentoFK=3},
            new Equipamento  {EquipamentoID=8, EquipamentoFK=3 },
            new Equipamento  {EquipamentoID=9, EquipamentoFK=3 },
            new Equipamento  {EquipamentoID=10, EquipamentoFK=3 },
            new Equipamento  {EquipamentoID=11, EquipamentoFK=3 },
            new Equipamento  {EquipamentoID=12, EquipamentoFK=5 },
            new Equipamento  {EquipamentoID=13, EquipamentoFK=5 },
            new Equipamento  {EquipamentoID=14, EquipamentoFK=6 },
            new Equipamento  {EquipamentoID=15, EquipamentoFK=6 },
            new Equipamento  {EquipamentoID=16, EquipamentoFK=9 },
            new Equipamento  {EquipamentoID=1, EquipamentoFK=9 },
            new Equipamento  {EquipamentoID=18, EquipamentoFK=9 },
            new Equipamento  {EquipamentoID=19, EquipamentoFK=10 },
            new Equipamento  {EquipamentoID=20, EquipamentoFK=10 },
         };

            equipamento.ForEach(dd => context.Equipamento.AddOrUpdate(d => d.Nome, dd));
            context.SaveChanges();

            // ############################################################################################
            // adiciona Modalidade
            var modalidade = new List<Modalidade> {
   new Modalidade  {ModaID=1, Nome = "Aikido",EquipamentoFK=1},
   new Modalidade  {ModaID=2, Nome = "Boxe", EquipamentoFK=3},
   new Modalidade  {ModaID=3, Nome = "Judo", EquipamentoFK=2},
   new Modalidade  {ModaID=4, Nome = "Muay Thai", EquipamentoFK=5},
   new Modalidade  {ModaID=5, Nome = "MMA", EquipamentoFK=6},
   new Modalidade  {ModaID=6, Nome = "Karate", EquipamentoFK=9},
   new Modalidade  {ModaID=7, Nome = "Tae Kwon Do", EquipamentoFK=10},
   
};

            modalidade.ForEach(aa => context.Modalidade.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();


            // ############################################################################################
            // adiciona Fornecedor
            var fornecedor = new List<Fornecedor> {
   new Fornecedor  {FornecID=1, Nome = "Maria Pinto", NumFornec ="A01234" },
   new Fornecedor  {FornecID=2, Nome = "Luís Santos", NumFornec ="A01234" },
   new Fornecedor  {FornecID=3, Nome = "João  Pinto", NumFornec ="A01234" },
   new Fornecedor  {FornecID=4, Nome = "Paula Fernandes", NumFornec ="A01234" } ,
};

            fornecedor.ForEach(vv => context.Fornecedor.AddOrUpdate(v => v.Nome, vv));
            context.SaveChanges();


            // ############################################################################################
            // adiciona NovosProdutos
            var novosProdutos = new List<NovosProdutos> {
   new NovosProdutos  {NovosProdID = 1, DataProduto =  new DateTime(2015,2,8), FornecedorFK = 1, EquipamentoFK = 2 },
   new NovosProdutos  {NovosProdID = 2, DataProduto =  new DateTime(2015,5,8), FornecedorFK = 1, EquipamentoFK = 19 },
   new NovosProdutos  {NovosProdID = 3, DataProduto =  new DateTime(2015,6,8), FornecedorFK = 1, EquipamentoFK = 13 },
   new NovosProdutos  {NovosProdID = 4, DataProduto =  new DateTime(2015,7,8), FornecedorFK = 1, EquipamentoFK = 11 },
   new NovosProdutos  {NovosProdID = 5, DataProduto =  new DateTime(2015,8,8), FornecedorFK = 1, EquipamentoFK = 4 },
   new NovosProdutos  {NovosProdID = 6, DataProduto =  new DateTime(2015,9,8), FornecedorFK = 1, EquipamentoFK = 22 },
   new NovosProdutos  {NovosProdID = 7, DataProduto =  new DateTime(2015,10,8), FornecedorFK = 1, EquipamentoFK = 22 },
   new NovosProdutos  {NovosProdID = 8, DataProduto =  new DateTime(2015,11,8), FornecedorFK = 1, EquipamentoFK = 19 },
   new NovosProdutos  {NovosProdID = 9, DataProduto =  new DateTime(2015,11,8), FornecedorFK = 1, EquipamentoFK = 23 },
   new NovosProdutos  {NovosProdID = 10, DataProduto =  new DateTime(2015,12,8), FornecedorFK = 1, EquipamentoFK = 1 },
   new NovosProdutos  {NovosProdID = 11, DataProduto =  new DateTime(2013,3,8), FornecedorFK = 1, EquipamentoFK = 21 },
   new NovosProdutos  {NovosProdID = 12, DataProduto =  new DateTime(2013,3,8), FornecedorFK = 1, EquipamentoFK = 24 },
   new NovosProdutos  {NovosProdID = 13, DataProduto =  new DateTime(2013,3,8), FornecedorFK = 1, EquipamentoFK = 4 },
   new NovosProdutos  {NovosProdID = 14, DataProduto =  new DateTime(2013,3,8), FornecedorFK = 1, EquipamentoFK = 5 },
   new NovosProdutos  {NovosProdID = 15, DataProduto =  new DateTime(2013,3,8), FornecedorFK = 1, EquipamentoFK = 5 },
   new NovosProdutos  {NovosProdID = 16, DataProduto =  new DateTime(2013,4,8), FornecedorFK = 1, EquipamentoFK = 2 },
   new NovosProdutos  {NovosProdID = 17, DataProduto =  new DateTime(2013,5,8), FornecedorFK = 1, EquipamentoFK = 25 },
   new NovosProdutos  {NovosProdID = 18, DataProduto =  new DateTime(2013,5,8), FornecedorFK = 1, EquipamentoFK = 26 },
   new NovosProdutos  {NovosProdID = 19, DataProduto =  new DateTime(2013,5,8), FornecedorFK = 1, EquipamentoFK = 25 },
   new NovosProdutos  {NovosProdID = 20, DataProduto =  new DateTime(2013,5,8), FornecedorFK = 1, EquipamentoFK = 22 },
   new NovosProdutos  {NovosProdID = 21, DataProduto =  new DateTime(2013,6,8), FornecedorFK = 1, EquipamentoFK = 15 },
   new NovosProdutos  {NovosProdID = 22, DataProduto =  new DateTime(2013,6,8), FornecedorFK = 1, EquipamentoFK = 23 },
   new NovosProdutos  {NovosProdID = 23, DataProduto =  new DateTime(2013,6,8), FornecedorFK = 1, EquipamentoFK = 13 },
   new NovosProdutos  {NovosProdID = 24, DataProduto =  new DateTime(2013,7,8), FornecedorFK = 1, EquipamentoFK = 23 },
   new NovosProdutos  {NovosProdID = 25, DataProduto =  new DateTime(2013,7,8), FornecedorFK = 2, EquipamentoFK = 27 },
   new NovosProdutos  {NovosProdID = 26, DataProduto =  new DateTime(2013,7,8), FornecedorFK = 2, EquipamentoFK = 11 },
   new NovosProdutos  {NovosProdID = 27, DataProduto =  new DateTime(2013,8,8), FornecedorFK = 2, EquipamentoFK = 9 },
   new NovosProdutos  {NovosProdID = 28, DataProduto =  new DateTime(2013,9,8), FornecedorFK = 2, EquipamentoFK = 9 },
   new NovosProdutos  {NovosProdID = 29, DataProduto =  new DateTime(2013,9,8), FornecedorFK = 2, EquipamentoFK = 15 },
   new NovosProdutos  {NovosProdID = 30, DataProduto =  new DateTime(2013,10,8), FornecedorFK = 1, EquipamentoFK = 17 },
   new NovosProdutos  {NovosProdID = 31, DataProduto =  new DateTime(2013,11,8), FornecedorFK = 1, EquipamentoFK = 2 },
   new NovosProdutos  {NovosProdID = 32, DataProduto =  new DateTime(2014,2,8), FornecedorFK = 2, EquipamentoFK = 9 },
   new NovosProdutos  {NovosProdID = 33, DataProduto =  new DateTime(2014,2,8), FornecedorFK = 2, EquipamentoFK = 9 },
   new NovosProdutos  {NovosProdID = 34, DataProduto =  new DateTime(2014,3,8), FornecedorFK = 1, EquipamentoFK = 14 },
   new NovosProdutos  {NovosProdID = 35, DataProduto =  new DateTime(2014,5,8), FornecedorFK = 2, EquipamentoFK = 6 },
   new NovosProdutos  {NovosProdID = 36, DataProduto =  new DateTime(2014,5,8), FornecedorFK = 1, EquipamentoFK = 15 },
   new NovosProdutos  {NovosProdID = 37, DataProduto =  new DateTime(2014,7,8), FornecedorFK = 1, EquipamentoFK = 5 },
   new NovosProdutos  {NovosProdID = 38, DataProduto =  new DateTime(2014,8,8), FornecedorFK = 2, EquipamentoFK = 21 },
   new NovosProdutos  {NovosProdID = 39, DataProduto =  new DateTime(2014,8,8), FornecedorFK = 2, EquipamentoFK = 21 },
   new NovosProdutos  {NovosProdID = 40, DataProduto =  new DateTime(2014,9,8), FornecedorFK = 2, EquipamentoFK = 25 },
   new NovosProdutos  {NovosProdID = 41, DataProduto =  new DateTime(2014,9,8), FornecedorFK = 1, EquipamentoFK = 7 },
   new NovosProdutos  {NovosProdID = 42, DataProduto =  new DateTime(2014,10,8), FornecedorFK = 1, EquipamentoFK = 24 },
   new NovosProdutos  {NovosProdID = 43, DataProduto =  new DateTime(2014,10,8), FornecedorFK = 1, EquipamentoFK = 2 },
   new NovosProdutos  {NovosProdID = 44, DataProduto =  new DateTime(2014,11,8), FornecedorFK = 2, EquipamentoFK = 12 },
   new NovosProdutos  {NovosProdID = 45, DataProduto =  new DateTime(2014,1,8), FornecedorFK = 2, EquipamentoFK = 8 },
   new NovosProdutos  {NovosProdID = 46, DataProduto =  new DateTime(2014,3,8), FornecedorFK = 2, EquipamentoFK = 13 },
   new NovosProdutos  {NovosProdID = 47, DataProduto =  new DateTime(2014,4,8), FornecedorFK = 1, EquipamentoFK = 13 },
   new NovosProdutos  {NovosProdID = 48, DataProduto =  new DateTime(2014,4,8), FornecedorFK = 2, EquipamentoFK = 22 },
   new NovosProdutos  {NovosProdID = 49, DataProduto =  new DateTime(2014,5,8), FornecedorFK = 1, EquipamentoFK = 19 },
   new NovosProdutos  {NovosProdID = 50, DataProduto =  new DateTime(2014,7,8), FornecedorFK = 1, EquipamentoFK = 16 },
   new NovosProdutos  {NovosProdID = 51, DataProduto =  new DateTime(2014,8,8), FornecedorFK = 3, EquipamentoFK = 1 },
   new NovosProdutos  {NovosProdID = 52, DataProduto =  new DateTime(2014,8,8), FornecedorFK = 3, EquipamentoFK = 12 },
   new NovosProdutos  {NovosProdID = 53, DataProduto =  new DateTime(2014,8,8), FornecedorFK = 2, EquipamentoFK = 12 },
   new NovosProdutos  {NovosProdID = 54, DataProduto =  new DateTime(2014,8,8), FornecedorFK = 1, EquipamentoFK = 6 },
   new NovosProdutos  {NovosProdID = 55, DataProduto =  new DateTime(2014,8,8), FornecedorFK = 1, EquipamentoFK = 26 },
   new NovosProdutos  {NovosProdID = 56, DataProduto =  new DateTime(2014,8,8), FornecedorFK = 2, EquipamentoFK = 24 },
   new NovosProdutos  {NovosProdID = 57, DataProduto =  new DateTime(2014,8,8), FornecedorFK = 2, EquipamentoFK = 12 },
   new NovosProdutos  {NovosProdID = 58, DataProduto =  new DateTime(2014,8,8), FornecedorFK = 3, EquipamentoFK = 22 },
   new NovosProdutos  {NovosProdID = 59, DataProduto =  new DateTime(2014,9,8), FornecedorFK = 3, EquipamentoFK = 10 },
   new NovosProdutos  {NovosProdID = 60, DataProduto =  new DateTime(2014,9,8), FornecedorFK = 3, EquipamentoFK = 15 },
   new NovosProdutos  {NovosProdID = 61, DataProduto =  new DateTime(2014,10,8), FornecedorFK = 1, EquipamentoFK = 6 },
   new NovosProdutos  {NovosProdID = 62, DataProduto =  new DateTime(2014,10,8), FornecedorFK = 2, EquipamentoFK = 26 },
   new NovosProdutos  {NovosProdID = 63, DataProduto =  new DateTime(2014,11,8), FornecedorFK = 3, EquipamentoFK = 16 },
   new NovosProdutos  {NovosProdID = 64, DataProduto =  new DateTime(2014,11,8), FornecedorFK = 3, EquipamentoFK = 2 },
   new NovosProdutos  {NovosProdID = 65, DataProduto =  new DateTime(2015,1,8), FornecedorFK = 3, EquipamentoFK = 26 },
   new NovosProdutos  {NovosProdID = 66, DataProduto =  new DateTime(2015,2,8), FornecedorFK = 1, EquipamentoFK = 24 },
   new NovosProdutos  {NovosProdID = 67, DataProduto =  new DateTime(2015,2,8), FornecedorFK = 1, EquipamentoFK = 21 },
   new NovosProdutos  {NovosProdID = 68, DataProduto =  new DateTime(2015,2,8), FornecedorFK = 2, EquipamentoFK = 6 },
   new NovosProdutos  {NovosProdID = 69, DataProduto =  new DateTime(2015,3,8), FornecedorFK = 2, EquipamentoFK = 14 },
   new NovosProdutos  {NovosProdID = 70, DataProduto =  new DateTime(2015,3,8), FornecedorFK = 2, EquipamentoFK = 19 },
   new NovosProdutos  {NovosProdID = 71, DataProduto =  new DateTime(2015,4,8), FornecedorFK = 1, EquipamentoFK = 14 },
   new NovosProdutos  {NovosProdID = 72, DataProduto =  new DateTime(2015,4,8), FornecedorFK = 2, EquipamentoFK = 22 },
   new NovosProdutos  {NovosProdID = 73, DataProduto =  new DateTime(2015,5,8), FornecedorFK = 2, EquipamentoFK = 24 },
   new NovosProdutos  {NovosProdID = 74, DataProduto =  new DateTime(2015,5,8), FornecedorFK = 3, EquipamentoFK = 6 },
   new NovosProdutos  {NovosProdID = 75, DataProduto =  new DateTime(2015,6,8), FornecedorFK = 3, EquipamentoFK = 26 },
   new NovosProdutos  {NovosProdID = 76, DataProduto =  new DateTime(2015,6,8), FornecedorFK = 3, EquipamentoFK = 12 },
   new NovosProdutos  {NovosProdID = 77, DataProduto =  new DateTime(2015,7,8), FornecedorFK = 3, EquipamentoFK = 4 },
   new NovosProdutos  {NovosProdID = 78, DataProduto =  new DateTime(2015,9,8), FornecedorFK = 4, EquipamentoFK = 25 },
   new NovosProdutos  {NovosProdID = 79, DataProduto =  new DateTime(2015,9,8), FornecedorFK = 4, EquipamentoFK = 27 },
   new NovosProdutos  {NovosProdID = 80, DataProduto =  new DateTime(2015,9,8), FornecedorFK = 4, EquipamentoFK = 16 },
   new NovosProdutos  {NovosProdID = 81, DataProduto =  new DateTime(2015,9,8), FornecedorFK = 4, EquipamentoFK = 2 },
   new NovosProdutos  {NovosProdID = 82, DataProduto =  new DateTime(2015,10,8), FornecedorFK = 4, EquipamentoFK = 19 },
   new NovosProdutos  {NovosProdID = 83, DataProduto =  new DateTime(2015,12,8), FornecedorFK = 3, EquipamentoFK = 16 },
   new NovosProdutos  {NovosProdID = 84, DataProduto =  new DateTime(2015,12,8), FornecedorFK = 4, EquipamentoFK = 16 },
   new NovosProdutos  {NovosProdID = 85, DataProduto =  new DateTime(2015,12,8), FornecedorFK = 4, EquipamentoFK = 7 },
   new NovosProdutos  {NovosProdID = 86, DataProduto =  new DateTime(2015,12,8), FornecedorFK = 2, EquipamentoFK = 16 },
   new NovosProdutos  {NovosProdID = 87, DataProduto =  new DateTime(2015,12,8), FornecedorFK = 3, EquipamentoFK = 2 },
   new NovosProdutos  {NovosProdID = 88, DataProduto =  new DateTime(2015,12,8), FornecedorFK = 4, EquipamentoFK = 27 },
   new NovosProdutos  {NovosProdID = 89, DataProduto =  new DateTime(2016,4,8), FornecedorFK = 4, EquipamentoFK = 17 },
   new NovosProdutos  {NovosProdID = 90, DataProduto =  new DateTime(2016,5,8), FornecedorFK = 4, EquipamentoFK = 22 },
   new NovosProdutos  {NovosProdID = 91, DataProduto =  new DateTime(2016,6,8), FornecedorFK = 4, EquipamentoFK = 21 },
   new NovosProdutos  {NovosProdID = 92, DataProduto =  new DateTime(2016,7,8), FornecedorFK = 2, EquipamentoFK = 24 },
   new NovosProdutos  {NovosProdID = 93, DataProduto =  new DateTime(2016,8,8), FornecedorFK = 3, EquipamentoFK = 4 },
   new NovosProdutos  {NovosProdID = 94, DataProduto =  new DateTime(2016,8,8), FornecedorFK = 3, EquipamentoFK = 7 },
   new NovosProdutos  {NovosProdID = 95, DataProduto =  new DateTime(2016,9,8), FornecedorFK = 2, EquipamentoFK = 11 },
   new NovosProdutos  {NovosProdID = 96, DataProduto =  new DateTime(2016,9,8), FornecedorFK = 2, EquipamentoFK = 26 },
   new NovosProdutos  {NovosProdID = 97, DataProduto =  new DateTime(2016,10,8), FornecedorFK = 2, EquipamentoFK = 27 },
   new NovosProdutos  {NovosProdID = 98, DataProduto =  new DateTime(2016,10,8), FornecedorFK = 1, EquipamentoFK = 14 },
   new NovosProdutos  {NovosProdID = 99, DataProduto =  new DateTime(2016,10,8), FornecedorFK = 4, EquipamentoFK = 19 },
   new NovosProdutos  {NovosProdID = 100, DataProduto =  new DateTime(2016,10,8), FornecedorFK = 4, EquipamentoFK = 11 },
};

            novosProdutos.ForEach(cc => context.NovosProdutos.Add(cc));
            context.SaveChanges();





        }
    }

}
