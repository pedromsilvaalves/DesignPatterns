using Builder.Utils.Enumeraveis;

namespace Builder.Criaturas.Builders
{
    public interface ICriaturaBuilder
    {
        void Reset();
        void CriarBase();
        void DefinirAfiliacao(TipoAfiliacao afiliacao);
        void DefinirRaridade(TipoRaridade raridade);
        void DefinirAtributos();
        Criatura ObterCriatura();
    }
}
