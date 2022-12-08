using ER3.Interfaces;

namespace ER3.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string ?cpf { get; set; }
        public string ?dataNascimento { get; set; }
        public bool ValidarDataNascimento(string dataNasc)
        {   
            DateTime dataConvertida;
            if(DateTime.TryParse(dataNasc, out dataConvertida)){
                DateTime dataAtual = DateTime.Today;
                double anos = (dataAtual - dataConvertida).TotalDays / 365;
                if (anos >= 18){
                    return true;
                }
                return false;  
            } 
            return false; 

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}