using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelCarro.Servicos
{
    public interface IEmail
    {
        Task EnviarEmail(string email, string assunto, string mensagem);
    }
}
