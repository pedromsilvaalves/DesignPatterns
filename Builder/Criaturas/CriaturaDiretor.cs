using Builder.Criaturas.Builders;
using Builder.Utils.Enumeraveis;

namespace Builder.Criaturas
{
    public static class CriaturaDiretor
    {
        public static Criatura CriarCriaturaNorte(ICriaturaBuilder builder, TipoRaridade raridade)
        {
            builder.Reset();
            builder.CriarBase();
            builder.DefinirAtributos();
            builder.DefinirRaridade(raridade);
            builder.DefinirAfiliacao(TipoAfiliacao.Norte);

            return builder.ObterCriatura();
        }

        public static Criatura CriarCriaturaLeste(ICriaturaBuilder builder, TipoRaridade raridade)
        {
            builder.Reset();
            builder.CriarBase();
            builder.DefinirAtributos();
            builder.DefinirRaridade(raridade);
            builder.DefinirAfiliacao(TipoAfiliacao.Leste);

            return builder.ObterCriatura();
        }

        public static Criatura CriarCriaturaSul(ICriaturaBuilder builder, TipoRaridade raridade)
        {
            builder.Reset();
            builder.CriarBase();
            builder.DefinirAtributos();
            builder.DefinirRaridade(raridade);
            builder.DefinirAfiliacao(TipoAfiliacao.Sul);

            return builder.ObterCriatura();
        }

        public static Criatura CriarCriaturaOeste(ICriaturaBuilder builder, TipoRaridade raridade)
        {
            builder.Reset();
            builder.CriarBase();
            builder.DefinirAtributos();
            builder.DefinirRaridade(raridade);
            builder.DefinirAfiliacao(TipoAfiliacao.Oeste);

            return builder.ObterCriatura();
        }
    }
}
