using NUnit.Framework;
using Juego;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IfIsDied1()
        {
            int celulasVecinas = 1;
            bool EstadoInicial = false;
            bool ChangeEstado;

            ChangeEstado = Normas.IsAlive(EstadoInicial, celulasVecinas);

            Assert.IsFalse(ChangeEstado);
        }

        [Test]
        public void IfIsDied2()
        {
            int celulasVecinas = 2;
            bool EstadoInicial = false;
            bool ChangeEstado;

            ChangeEstado = Normas.IsAlive(EstadoInicial, celulasVecinas);

            Assert.IsFalse(ChangeEstado);
        }

        [Test]
        public void IfIsDied3()
        {
            int celulasVecinas = 3;
            bool EstadoInicial = false;
            bool ChangeEstado;

            ChangeEstado = Normas.IsAlive(EstadoInicial, celulasVecinas);

            Assert.IsTrue(ChangeEstado);
        }

        [Test]
        public void IfIsDied4()
        {
            int celulasVecinas = 4;
            bool EstadoInicial = false;
            bool ChangeEstado;

            ChangeEstado = Normas.IsAlive(EstadoInicial, celulasVecinas);

            Assert.IsFalse(ChangeEstado);
        }

        [Test]
        public void IfIsAlive1()
        {
            int celulasVecinas = 1;
            bool EstadoInicial = true;
            bool ChangeEstado;

            ChangeEstado = Normas.IsAlive(EstadoInicial, celulasVecinas);

            Assert.IsTrue(ChangeEstado);
        }

        [Test]
        public void IfIsAlive2()
        {
            int celulasVecinas = 2;
            bool EstadoInicial = true;
            bool ChangeEstado;

            ChangeEstado = Normas.IsAlive(EstadoInicial, celulasVecinas);

            Assert.IsFalse(ChangeEstado);
        }

        public void IfIsAlive3()
        {
            int celulasVecinas = 3;
            bool EstadoInicial = true;
            bool ChangeEstado;

            ChangeEstado = Normas.IsAlive(EstadoInicial, celulasVecinas);

            Assert.IsFalse(ChangeEstado);
        }

        [Test]
        public void IfIsAlive4()
        {
            int celulasVecinas = 4;
            bool EstadoInicial = true;
            bool ChangeEstado;

            ChangeEstado = Normas.IsAlive(EstadoInicial, celulasVecinas);

            Assert.IsTrue(ChangeEstado);
        }
    }
}