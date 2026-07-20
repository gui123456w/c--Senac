using CursoCHsharp.atv;
using CursoCHsharp.ClassesEMetodos;
using CursoCHsharp.Fundamentos;
using CursoCSharp.Fundamentos;
using CursoCHsharp.OO;

using System;
using System.Collections.Generic;
using static CursoCHsharp.ClassesEMetodos.VendaCelular;
using CursoCHsharp.Colecoes;


namespace CursoCSharp {

    class Program {

        static void Main(string[] args) {

            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},

                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},

                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},

                {"Lendo Dados - Fundamentos", LendoDados.Executar },

                {"Exercicio1 - Fundamentos", Exercicio1.Executar},


                {"CamisaTme - atv", CamisaTime.Executar},

                {"Chuteaogol - atv",ChuteaoGol.Executar},

                {"Convocao - atv", Convocao.Executar},

                {"CopadoMundo - atv", CopaDoMundo.Executar},

                {"FaseCompeticao - atv", FaseCompeticao.Executar},

                {"Ingresso - atv", Ingresso.Executar},

                {"Lenda - atv", LendaCopa.Executar},

                {"SelecaoPontos - atv", SelecaoPontos.Executar},

                {"EstruturaDRCopado - atv", EstruturaDRCopado.Executar},

                {"MediaDeGol - atv ", MediaDeGol.Executar },

                {"ArtilheiroGols - atv ", ArtilheiroGols.Executar  },

                {"CadastroTorcedores - atv ", CadastroTorcedores.Executar },
                //class
                {"ClassesSelecao - atv ", ClassesSelecao.Executar },
                // atv-array
                {"ArrayMercado - atv ", ArrayMercado.Executar },



                //Membros - Classes e Metodos
                {"Membros - ClassesEMetodos", Membros.Executar },

                //atividade de jogadores

                {"Reciptor - ClassesEMetodos", Reciptor.Executar  },
                {"Animais - ClassesEMetodos", Animais.Executar },
                {"Construtores - ClassesEMetodos ", Construtoress.Executar },
                //calculadora
                {"ConversorTemperatura - ClassesEMetodos", ConversosTemperatura.Executar },
                //MetodosEstatico

                {"MetodosEstatico - ClassesEMetodos", MetodosEstatico.Executar },
                {"CalcularDesconto - ClassesEMetodos ", CalcularDesconto.Executar },
                {"Oficina Mecânica - Classes e Métodos", OficinaMecanica.Executar },

                {"Loja de Celulares - Classes e Métodos", LojaCelulares.Executar },
                {"Params - Classes e Métodos", Params.Executar  },

                {"Soma Params - ClassesEMetodos", Soma.Executar },

                {"Lanchonete - ClassesEMetodos ", Lanchonete.Executar },
                {"PIzaria - ClassesEMetodos ", Pizzaria.Executar },

                {"GetSet- ClassesEMetodos ", GetSet.Executar },
                {"Produto 1 - ClassesEMetodos ", Produto1.Executar },
                //
                {"Jogo - ClassesEMetodos ", Jogo.Executar },

                {"Ivone - ClassesEMetodos ", Ivone.Executar },

                // coleções 
                {"Arrays   - Colecoes", Arrays.Executar},

                {"Coleções Queueu - Colecoes", ColecoesQueue.Executar },

                {"Coleções Stack - Colecoes", ColecoesStack.Executar },

                //OO

                {"Herança   - OO", Heranca.Executar }

            });


            central.SelecionarEExecutar();

        }

    }

}