using Builder.Componentes;
using Builder.Utils.Enumeraveis;
using System.Collections.Generic;

namespace Builder.Criaturas.Builders.Implementacoes
{
    public class GoblinBuilder : ICriaturaBuilder
    {
        private Criatura criatura;
        public void CriarBase()
        {
            this.criatura.nome = "Goblin";
            this.criatura.tipoCriatura = TipoCriatura.Goblin;
            this.criatura.atributos = new List<Atributo>();
        }

        public void DefinirAfiliacao(TipoAfiliacao afiliacao)
        {
            this.criatura.afiliacao = afiliacao;
        }

        public void DefinirAtributos()
        {
            this.criatura.atributos.Add(new Componentes.Atributo
            {
                Nome = TipoAtributo.Vantagem,
                Valor = "Fertilidade"
            });
            this.criatura.atributos.Add(new Componentes.Atributo
            {
                Nome = TipoAtributo.Vulnerabilidade,
                Valor = "Fogo"
            });
        }

        public void DefinirRaridade(TipoRaridade raridade)
        {
            this.criatura.raridade = raridade;
        }

        public Criatura ObterCriatura()
        {
            return this.criatura;
        }

        public void Reset()
        {
            this.criatura = new Criatura();
        }
    }
}
