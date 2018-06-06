using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroExamen.BLL;
using RegistroExamen.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegistroExamen.BLL.Tests
{
    [TestClass()]
    public class GruposBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Grupos Grupo = new Grupos();
            Grupo.GrupoId = 0;
            Grupo.Fecha = DateTime.Now;
            Grupo.Descripcion = "20150959";
            Grupo.Cantidad = 0;
            Grupo.grupos = 0;
            Grupo.Integrantes = "4";
            paso = GruposBLL.Guardar(Grupo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Grupos Grupo = new Grupos();
            Grupo.GrupoId = 4;
            Grupo.Fecha = DateTime.Now;
            Grupo.Descripcion = "0949";
            Grupo.Cantidad = 12;
            Grupo.grupos = 2;
            Grupo.Integrantes = "6";
            paso = GruposBLL.Modificar(Grupo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            paso = GruposBLL.Eliminar(12);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Grupos Grupo = new Grupos();
            Grupo = GruposBLL.Buscar(12);
            Assert.IsNotNull(Grupo);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var Lista = GruposBLL.GetList(x => true);
            Assert.IsNotNull(Lista);
        }
    }
}