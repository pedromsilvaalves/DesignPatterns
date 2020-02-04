using FactoryMethod.Equipamentos.Abstratos;
using FactoryMethod.Equipamentos.Implementacoes;
using FactoryMethod.Util.Enumeraveis;

namespace FactoryMethod.Equipamentos.Factories
{
    public class BotaFactory : EquipamentoFactory
    {
        public override EquipamentoAbstrato CriarEquipamento(RaridadeEquipamento raridadeEquipamento)
        {
            return new Bota(raridadeEquipamento, 100);
        }
    }
}
