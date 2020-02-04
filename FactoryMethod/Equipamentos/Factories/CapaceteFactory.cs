using FactoryMethod.Equipamentos.Abstratos;
using FactoryMethod.Equipamentos.Implementacoes;
using FactoryMethod.Util.Enumeraveis;

namespace FactoryMethod.Equipamentos.Factories
{
    public class CapaceteFactory : EquipamentoFactory
    {
        public override EquipamentoAbstrato CriarEquipamento(RaridadeEquipamento raridadeEquipamento)
        {
            return new Capacete(raridadeEquipamento, 100);
        }
    }
}
