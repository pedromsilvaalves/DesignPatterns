using FactoryMethod.Equipamentos.Abstratos;
using FactoryMethod.Equipamentos.Implementacoes;
using FactoryMethod.Util.Enumeraveis;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Equipamentos.Factories
{
    public static class EquipamentoFactory
    {
        public static EquipamentoAbstrato ObterEquipamento(TipoEquipamento tipoEquipamento, RaridadeEquipamento raridadeEquipamento)
        {
            switch(tipoEquipamento)
            {
                case TipoEquipamento.Armadura:
                    return new Armadura(raridadeEquipamento, 100);
                case TipoEquipamento.Bota:
                    return new Bota(raridadeEquipamento, 100);
                case TipoEquipamento.Capacete: 
                    return new Capacete(raridadeEquipamento, 100);
                default:
                    return null;
            }
        }
    }
}
