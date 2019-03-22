using AuthorizationToken.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthorizationToken.Service
{
    public class FuncionariosSeguranca
    {
        public static bool Login(string login, string senha)
        {
            using (FuncionarioDBContext entities = new FuncionarioDBContext())
            {
                return entities.Usuarios.Any(user => user.Login.Equals(login, StringComparison.OrdinalIgnoreCase)
                                && user.Senha == senha);
            }
        }
    }
}