using CursoCHsharp.atv;
using CursoCHsharp.Fundamentos;
using CursoCSharp.Fundamentos;
using System;
using System.Collections.Generic;

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

                {"CadastroTorcedores - atv ", CadastroTorcedores.Executar }

            });


            central.SelecionarEExecutar();

        }

    }

}