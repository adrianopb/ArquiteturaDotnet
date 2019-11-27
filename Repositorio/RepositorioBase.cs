using Dados;
using System;

namespace Repositorio
{
    public class RepositorioBase
    {
        public BancoEntities Contexto
        {
            get
            {
                return this._contexto;
            }
            set
            {
                this._contexto = value;
            }
        }

        private BancoEntities _contexto;

        public RepositorioBase()
        {
            _contexto = new BancoEntities();
        }
    }
}
