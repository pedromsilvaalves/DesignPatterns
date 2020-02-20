using Builder.Criaturas.Builders;
using Builder.Utils.Enumeraveis;

namespace Builder.Criaturas
{
    public static class CriaturaDiretor
    {
        public static Criatura CriarCriaturaNorte(ICriaturaBuilder builder, TipoRaridade raridade)
        {
            CriarCriatura(builder, raridade, TipoAfiliacao.Norte);
            return builder.ObterCriatura();
        }

        public static Criatura CriarCriaturaLeste(ICriaturaBuilder builder, TipoRaridade raridade)
        {
            CriarCriatura(builder, raridade, TipoAfiliacao.Leste);
            return builder.ObterCriatura();
        }

        public static Criatura CriarCriaturaSul(ICriaturaBuilder builder, TipoRaridade raridade)
        {
            CriarCriatura(builder, raridade, TipoAfiliacao.Sul);
            return builder.ObterCriatura();
        }

        public static Criatura CriarCriaturaOeste(ICriaturaBuilder builder, TipoRaridade raridade)
        {
            CriarCriatura(builder, raridade, TipoAfiliacao.Oeste);
            return builder.ObterCriatura();
        }

        private static void CriarCriatura(ICriaturaBuilder builder, TipoRaridade raridade, TipoAfiliacao afiliacao)
        {
            builder.Reset();
            builder.CriarBase();
            builder.DefinirAtributos();
            builder.DefinirRaridade(raridade);
            builder.DefinirAfiliacao(afiliacao);
        }
    }
}
