using Builder.Componentes;
using Builder.Utils.Enumeraveis;
using System.Collections.Generic;

namespace Builder.Criaturas.Builders.Implementacoes
{
    public class OgroBuilder : ICriaturaBuilder
    {
        private Criatura criatura;
        public void CriarBase()
        {
            this.criatura.nome = "Ogro";
            this.criatura.tipoCriatura = TipoCriatura.Ogro;
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
                Valor = "Força"
            });
            this.criatura.atributos.Add(new Componentes.Atributo
            {
                Nome = TipoAtributo.Vulnerabilidade,
                Valor = "Confusão"
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
