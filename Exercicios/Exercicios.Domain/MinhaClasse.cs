namespace Exercicios.Domain
{
    public class MinhaClasse
    {
        protected internal void MeuMetodo()
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
