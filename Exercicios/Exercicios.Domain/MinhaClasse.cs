
namespace Exercicios.Domain
{
    public class MinhaClasse
    {
        public void MeuMetodo()
        {
        }
        public void OutroMetodo()
        {
            this.MeuMetodo();
        }
    }

    public class ClasseFilha : MinhaClasse
    {
        public void MetodoFilho()
        {
            this.MeuMetodo();
        }
    }

}
