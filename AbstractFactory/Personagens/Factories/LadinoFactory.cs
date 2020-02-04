using AbstractFactory.ArvoreHabilidades;
using AbstractFactory.ArvoreHabilidades.Implementacoes;
using AbstractFactory.Personagens.Factories.Abstract;
using AbstractFactory.Talentos;
using AbstractFactory.Talentos.Implementacoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Personagens.Factories
{
    public class LadinoFactory : PersonagemAbstractFactory
    {
        public override ArvoreHabilidadesAbstrato CriarArvoreHabilidades()
        {
            return new ArvoreHabilidadesLadino();
        }

        public override TalentosAbstrato CriarTalentos()
        {
            return new TalentosLadino();
        }
    }
}
