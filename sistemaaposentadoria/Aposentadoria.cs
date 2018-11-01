using System;
namespace sistemaaposentadoria
{
    public class Aposentadoria
    {
        public string Nome { set; get; }
        public double Idade { set; get; }
        public double anosTrabalhados { set; get; }

        public string respostaAposentadoria(){
            if (Idade >= 65 || anosTrabalhados >= 30)
            {
                return "apto";
            }
            else if (Idade >= 60 & anosTrabalhados >= 25){
                return "apto";
            }else{
                return "inapto";
            }
        }

    }

}
