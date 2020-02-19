using Builder.Utils.Enumeraveis;

namespace Builder.Criaturas.Builders.Implementacoes
{
    public class BandidoBuilder : ICriaturaBuilder
    {
        private Criatura criatura;
        public void CriarBase()
        {
            this.criatura.nome = "Bandido";
            this.criatura.tipoCriatura = TipoCriatura.Bandido;
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
                Valor = "Stealth"
            });
            this.criatura.atributos.Add(new Componentes.Atributo
            {
                Nome = TipoAtributo.Vulnerabilidade,
                Valor = "Justiça"
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
