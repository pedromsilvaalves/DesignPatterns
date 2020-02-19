using Builder.Componentes;
using Builder.Utils.Enumeraveis;
using System.Collections.Generic;

namespace Builder.Criaturas
{
    public class Criatura
    {
        public string nome { get; set; }
        public List<Atributo> atributos { get; set; }
        public TipoRaridade raridade { get; set; }
        public TipoAfiliacao afiliacao { get; set; }
        public TipoCriatura tipoCriatura { get; set; }
    }
}
