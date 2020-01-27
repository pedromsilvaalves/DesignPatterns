using FactoryMethod.Equipamentos.Abstratos;
using FactoryMethod.Util.Enumeraveis;

namespace FactoryMethod.Equipamentos.Implementacoes
{
    public class Capacete : EquipamentoAbstrato
    {
        public Capacete(RaridadeEquipamento raridadeEquipamento, double durabilidadeMaxima) : 
            base(raridadeEquipamento, durabilidadeMaxima, TipoEquipamento.Capacete)
        {
        }
        public override double ObterValorEquipamento()
        {
            return 10 * (int)RaridadeEquipamento;
        }
    }
}
