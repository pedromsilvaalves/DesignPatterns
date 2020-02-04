namespace Builder
{
    public class IphoneBuilder : ICelular
    {
        readonly Celular celular;
        public IphoneBuilder()
        {
            this.celular = new Celular("Iphone");
        }

        public Celular Celular
        {
            get { return this.celular; }
        }

        public void BuildBateria()
        {
            this.celular.bateria = "M_250";
        }

        public void BuildCamera()
        {
            this.celular.camera = "16 MP";
        }

        public void BuildSistema()
        {
            this.celular.sistema = "IOS 11";
        }

        public void BuildTela()
        {
            this.celular.tela = "9";
        }
    }
}
