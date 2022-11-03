using Emprestimos.core.Domain;
using Emprestimos.core.Processor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Emprestimos.core.tests.Processor
{
    public class Emprestimostests
    {
        EmprestimoProcessor _processor;
        //usa void pq é teste
        [Fact]
        public void DeveRetornarDadosEmprestimosComValoresdaRequisicao()
        {
            //organizar requesicao do usuario
            var req = new EmprestimoReq()
            {
                PrimeiroNome = "Claudia",
                UltimoNome = "Rincon",
                Email = "clau@claurincon.com.br",
                Data = DateTime.Now
            };
            //processar a requisição e retornar o resultado
            EmprestimoProcessor processor = new EmprestimoProcessor();
            EmprestimoResult result = processor.LerDados(req);

            //Afirmação
            Assert.NotNull(result);
            Assert.Equal(req.PrimeiroNome, result.PrimeiroNome);
            Assert.Equal(req.UltimoNome, result.UltimoNome);
            Assert.Equal(req.Email, result.Email);
            Assert.Equal(req.Data, result.Data);
        }

        [Fact]
        public void DeveRetornarUmaExceptionReqForNula()
        {
            _processor = new EmprestimoProcessor();
            var exception = Assert.Throws<ArgumentNullException>(() => _processor.LerDados(null));
            Assert.Equal("req", exception.ParamName);
        }
    
    }

}
