using AbstractFactory.ArvoreHabilidades;
using AbstractFactory.Talentos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Personagens.Factories.Abstract
{
    public abstract class PersonagemAbstractFactory
    {
        public abstract ArvoreHabilidadesAbstrato CriarArvoreHabilidades();
        public abstract TalentosAbstrato CriarTalentos();
    }
}
