using FactoryMethod.Equipamentos.Abstratos;
using FactoryMethod.Util.Enumeraveis;

namespace FactoryMethod.Equipamentos.Implementacoes
{
    public class Bota : EquipamentoAbstrato
    {
        public Bota(RaridadeEquipamento raridadeEquipamento, double durabilidadeMaxima) : 
            base(raridadeEquipamento, durabilidadeMaxima, TipoEquipamento.Bota)
        {
        }
        public override double ObterValorEquipamento()
        {
            return 20 * (int)RaridadeEquipamento;
        }
    }
}
