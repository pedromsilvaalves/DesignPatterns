using AbstractFactory.ArvoreHabilidades;
using AbstractFactory.ArvoreHabilidades.Implementacoes;
using AbstractFactory.Personagens.Factories.Abstract;
using AbstractFactory.Talentos;
using AbstractFactory.Talentos.Implementacoes;

namespace AbstractFactory.Personagens.Factories
{
    public class MagoFactory : PersonagemAbstractFactory
    {
        public override ArvoreHabilidadesAbstrato CriarArvoreHabilidades()
        {
            return new ArvoreHabilidadesMago();
        }

        public override TalentosAbstrato CriarTalentos()
        {
            return new TalentosMago();
        }
    }
}
