using FactoryMethod.Equipamentos.Abstratos;
using FactoryMethod.Util.Enumeraveis;

namespace FactoryMethod.Equipamentos.Implementacoes
{
    public class Armadura : EquipamentoAbstrato
    {
        public Armadura(RaridadeEquipamento raridadeEquipamento, double durabilidadeMaxima) : 
            base(raridadeEquipamento, durabilidadeMaxima, TipoEquipamento.Armadura)
        {
        }
        public override double ObterValorEquipamento()
        {
            return 50 * (int)RaridadeEquipamento;
        }
    }
}
