using FactoryMethod.Equipamentos.Abstratos;
using FactoryMethod.Equipamentos.Implementacoes;
using FactoryMethod.Util.Enumeraveis;

namespace FactoryMethod.Equipamentos.Factories
{
    public class ArmaduraFactory : EquipamentoFactory
    {
        public override EquipamentoAbstrato CriarEquipamento(RaridadeEquipamento raridadeEquipamento)
        {
            return new Armadura(raridadeEquipamento, 100);
        }
    }
}
