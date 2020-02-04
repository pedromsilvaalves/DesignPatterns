using AbstractFactory.ArvoreHabilidades;
using AbstractFactory.ArvoreHabilidades.Implementacoes;
using AbstractFactory.Personagens.Factories.Abstract;
using AbstractFactory.Talentos;
using AbstractFactory.Talentos.Implementacoes;

namespace AbstractFactory.Personagens.Factories
{
    public class GuerreiroFactory : PersonagemAbstractFactory
    {
        public override ArvoreHabilidadesAbstrato CriarArvoreHabilidades()
        {
            return new ArvoreHabilidadesGuerreiro();
        }

        public override TalentosAbstrato CriarTalentos()
        {
            return new TalentosGuerreiro();
        }
    }
}
