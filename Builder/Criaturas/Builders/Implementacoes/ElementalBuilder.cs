using Builder.Componentes;
using Builder.Utils.Enumeraveis;
using System.Collections.Generic;

namespace Builder.Criaturas.Builders.Implementacoes
{
    public class ElementalBuilder : ICriaturaBuilder
    {
        private Criatura criatura;
        public void CriarBase()
        {
            this.criatura.nome = "Elemental";
            this.criatura.tipoCriatura = TipoCriatura.Elemental;
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
                Valor = "Resistência Física"
            });
            this.criatura.atributos.Add(new Componentes.Atributo
            {
                Nome = TipoAtributo.Vulnerabilidade,
                Valor = "Magia"
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
