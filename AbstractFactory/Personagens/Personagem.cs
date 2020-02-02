using AbstractFactory.ArvoreHabilidades;
using AbstractFactory.Talentos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Personagens
{
    public class Personagem
    {
        protected TalentosAbstrato talentos;
        protected ArvoreHabilidadesAbstrato arvoreHabilidades;

        public Personagem(TalentosAbstrato talentos, ArvoreHabilidadesAbstrato arvoreHabilidades)
        {
            this.arvoreHabilidades = arvoreHabilidades;
            this.talentos = talentos;
        }
    }
}
