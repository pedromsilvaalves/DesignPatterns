using AbstractFactory.ArvoreHabilidades;
using AbstractFactory.ArvoreHabilidades.Implementacoes;
using AbstractFactory.Personagens.Factories.Abstract;
using AbstractFactory.Talentos;
using AbstractFactory.Talentos.Implementacoes;

namespace AbstractFactory.Personagens.Factories
{
    public class MongeFactory : PersonagemAbstractFactory
    {
        public override ArvoreHabilidadesAbstrato CriarArvoreHabilidades()
        {
            return new ArvoreHabilidadesMonge();
        }

        public override TalentosAbstrato CriarTalentos()
        {
            return new TalentosMago();
        }
    }
}
