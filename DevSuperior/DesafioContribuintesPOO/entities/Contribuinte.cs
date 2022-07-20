namespace DesafioContribuintes.entities
{
    public class Contribuinte
    {
        private double rendaAnualSalario;
        private double rendaAnualServicos;
        private double rendaAnualCapital;
        private double gastosMedicos;
        private double gastosEducacionais;

        private double impostoSalario;
        private double impostoServico;
        private double impostoCapital;
        private double brutoImpostos;
        private double abatimento;
        private double liquidoImpostos;

        public Contribuinte(double rendaAnualSalario, double rendaAnualServicos, double rendaAnualCapital, double gastosMedicos, double gastosEducacionais)
        {
            this.rendaAnualSalario = rendaAnualSalario;
            this.rendaAnualServicos = rendaAnualServicos;
            this.rendaAnualCapital = rendaAnualCapital;
            this.gastosMedicos = gastosMedicos;
            this.gastosEducacionais = gastosEducacionais;
        }

        public double getImpostoSalario()
        {
            if (rendaAnualSalario < 36000)
            {
                return impostoSalario = 0.0;
            }
            else if (rendaAnualSalario >= 36000 && rendaAnualSalario <= 60000)
            {
                return impostoSalario = rendaAnualSalario * 0.10;
            }
            else
            {
                impostoSalario = rendaAnualSalario * 0.20;
            }

            return impostoSalario;
        }

        public double getImpostoServico()
        {
            return impostoServico = rendaAnualServicos * 0.15;
        }

        public double getImpostoCapital()
        {
            return impostoCapital = rendaAnualCapital * 0.20;
        }

        public double getBrutoImpostos()
        {
            return brutoImpostos = getImpostoSalario() + getImpostoServico() + getImpostoCapital();
        }

        public double getAbatimento()
        {
            double porcentagem = brutoImpostos * 0.3;
            if (gastosMedicos + gastosEducacionais <= porcentagem)
            {
                return abatimento = gastosEducacionais + gastosMedicos;
            }
            else if (gastosMedicos + gastosEducacionais > porcentagem)
            {
                return abatimento = porcentagem;
            }

            return abatimento;
        }

        public double getLiquidoImpostos()
        {
            return liquidoImpostos = getBrutoImpostos() - getAbatimento();
        }
    }
}
