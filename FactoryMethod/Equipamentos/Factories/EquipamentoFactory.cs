using FactoryMethod.Equipamentos.Abstratos;
using FactoryMethod.Equipamentos.Implementacoes;
using FactoryMethod.Util.Enumeraveis;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Equipamentos.Factories
{
    public abstract class EquipamentoFactory
    {
        public static EquipamentoAbstrato ObterEquipamento(TipoEquipamento tipoEquipamento, RaridadeEquipamento raridadeEquipamento)
        {
            EquipamentoFactory equipamentoFactory;
            switch(tipoEquipamento)
            {
                case TipoEquipamento.Armadura:
                    equipamentoFactory = new ArmaduraFactory();
                    break;
                case TipoEquipamento.Bota:
                    equipamentoFactory = new BotaFactory();
                    break;
                case TipoEquipamento.Capacete:
                    equipamentoFactory = new CapaceteFactory();
                    break;
                default:
                    return null;
            }

            return equipamentoFactory.CriarEquipamento(raridadeEquipamento);
        }

        public abstract EquipamentoAbstrato CriarEquipamento(RaridadeEquipamento raridadeEquipamento);
    }
}
