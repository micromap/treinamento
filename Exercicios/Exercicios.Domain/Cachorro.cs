namespace Exercicios.Domain
{
    public class Cachorro
    {
        #region Nome
        public void SetNome(string nome)
        {
            _nome = nome;
        }
        public string GetNome()
        {
            return _nome;
        }
        private string _nome;
        #endregion

        #region Sexo
        public void SetSexo(string sexo)
        {
            _sexo = sexo;
        }
        public string GetSexo()
        {
            return _sexo;
        }
        private string _sexo;
        #endregion

        #region Raça
        public void SetRaca(string raca)
        {
            _raca = raca;
        }
        public string GetRaca()
        {
            return _raca;
        }
        private string _raca;
        #endregion

        #region Porte
        public void SetPorte(string porte)
        {
            _porte = porte;
        }
        public string GetPorte()
        {
            return _porte;
        }
        private string _porte;
        #endregion

        #region Idade
        public void SetIdade(int idade)
        {
            _idade = idade;
        }
        public int GetIdade()
        {
            return _idade;
        }
        private int _idade;
        #endregion

        #region Peso
        public void SetPeso(double peso)
        {
            if (peso < 0)
            {
                _pesoKg = 0;
            }
            else
            {
                _pesoKg = peso;
            }
        }

        public double GetPeso()
        {
            return _pesoKg;
        }
        private double _pesoKg;
        #endregion

        #region Vacinado
        public void SetVacinado(bool vacinado)
        {
            _vacinado = vacinado;
        }
        public bool GetVacinado()
        {
            return _vacinado;
        }
        private bool _vacinado;
        #endregion

        public string Latir(short qtdeLatidos)
        {
            var latidos = "";

            for(short i = 1; i <= qtdeLatidos; i++)
                latidos += "Au! ";

            return latidos.TrimEnd();
        }

        // Método para calcular 5% do Peso(Kg) do cachorro em Gramas de Ração
        public string QuantoDevoComer(int pesoKg)
        {
            return $"Como tenho {pesoKg}kg, devo comer {pesoKg * 50}g por dia";
        }
    }
}