using AbstractFactory.Util.Enumeraveis;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Personagens.Factories.Abstract
{
    public class PersonagemFactory
    {
        public static Personagem CriarPersonagem(TipoPersonagens tipoPersonagem)
        {
            PersonagemAbstractFactory personagemFactory = new GuerreiroFactory();
            switch(tipoPersonagem)
            {
                case TipoPersonagens.Guerreiro:
                    personagemFactory = new GuerreiroFactory();
                    break;
                case TipoPersonagens.Ladino:
                    personagemFactory = new LadinoFactory();
                    break;
                case TipoPersonagens.Mago:
                    personagemFactory = new MagoFactory();
                    break;
                case TipoPersonagens.Monge:
                    personagemFactory = new MongeFactory();
                    break;
            }

            return new Personagem(personagemFactory.CriarTalentos(), personagemFactory.CriarArvoreHabilidades());
        }
    }
}
