using Emprestimos.core.Domain;

namespace Emprestimos.core.Processor
{
    public class EmprestimoProcessor
    {
        
        public EmprestimoResult LerDados(EmprestimoReq req)
        {

            if (req == null)
            {
                throw new ArgumentNullException(nameof(req));
            }

            return new EmprestimoResult
           {
               Data = req.Data,
               PrimeiroNome = req.PrimeiroNome,
               UltimoNome = req.UltimoNome,
               Email = req.Email,
           };
        }
    }
}