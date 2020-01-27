using FactoryMethod.Util.Enumeraveis;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Equipamentos.Abstratos
{
    public abstract class EquipamentoAbstrato
    {
        private readonly RaridadeEquipamento raridadeEquipamento;
        private readonly double durabilidadeMaxima;
        private readonly TipoEquipamento tipoEquipamento;
        public RaridadeEquipamento RaridadeEquipamento { 
            get
            {
                return raridadeEquipamento;
            } 
        }
        public double DurabilidadeMaxima
        {
            get
            {
                return durabilidadeMaxima;
            }
        }
        public TipoEquipamento TipoEquipamento
        {
            get
            {
                return tipoEquipamento;
            }
        }

        protected EquipamentoAbstrato(RaridadeEquipamento raridadeEquipamento, double durabilidadeMaxima, TipoEquipamento tipoEquipamento)
        {
            this.tipoEquipamento = tipoEquipamento;
            this.raridadeEquipamento = raridadeEquipamento;
            this.durabilidadeMaxima = durabilidadeMaxima;
        }

        public abstract double ObterValorEquipamento();
    }
}
