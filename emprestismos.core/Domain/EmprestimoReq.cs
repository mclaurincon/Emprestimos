﻿namespace Emprestimos.core.Domain
{
    public class EmprestimoReq
    {
        public EmprestimoReq()
        {
        }

        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public object Data { get; set; }
    }
}