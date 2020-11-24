namespace Exercicios.domain
{
    public class MinhaClasse
    {
        protected void MeuMetodo()
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
