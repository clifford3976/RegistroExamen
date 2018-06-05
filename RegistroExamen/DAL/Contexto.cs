using RegistroExamen.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RegistroExamen.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Grupos> Grupo { get; set; }
        public Contexto() : base("ConStr")
        {    }
    }
}
