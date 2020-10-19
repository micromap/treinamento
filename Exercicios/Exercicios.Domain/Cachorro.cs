using System;

namespace Exercicios.Domain
{   

    //Classe Cachorro
    public class Cachorro
    {
        //Atributos privados da classe, com os gets e sets de cada atributos... todos dentro da região de codigos de cada um.
        #region _nome
        private string _nome;
        public void SetNome(string nome)
        {
            _nome = nome;
        }
        public string GetNome()
        {
            return _nome;
        }
        #endregion

        #region _sexo
        private string _sexo;
        public string GetSexo()
        {
            return _sexo;
        }

        public void SetSexo(string sexo)
        {
            _sexo = sexo;
        }
        #endregion

        #region _raca
        private string _raca;
        public string GetRaca()
        {
            return _raca;
        }

        public void SetRaca(string raca)
        {
            _raca = raca;
        }
        #endregion

        #region _porte
        private string _porte;
        public void SetPorte(string porte)
        {
            _porte = porte;
        }
        public string GetPorte()
        {
            return _porte;
        }
        #endregion

        #region _idade
        private int _idade;
        public void SetIdade(int idade)
        {
            _idade = idade;
        }

        public int GetIdade()
        {
            return _idade;
        }
        #endregion

        #region _pesoKg
        private double? _pesoKg;
        public void SetPesoKg(double? pesoKg)
        {
            if (pesoKg < 0)
            {
                _pesoKg = null;
            }
            else
            {
                _pesoKg = pesoKg;
            }
        }
        public double? GetPesoKg()
        {
            return _pesoKg;
        }
        #endregion

        #region _vacinado
        private bool _vacinado;
        public void SetVacinado(bool vacinado)
        {
            _vacinado = vacinado;
        }

        public bool GetVacinado()
        {
            return _vacinado;
        }
        #endregion

        //Metodo da classe, Latir(), QuantoDevoComer()
        public string Latir(short quantidadeLatidos)
        {
            var latidos = "";

            for(var i = 1; i <= quantidadeLatidos; i++) // Caso dentro do for so tenha uma linha de comando, pode deixar sem as {}.       
                latidos += "Au! "; //Atribuição composta, substitui latidos = latidos + "Au! "

            return latidos.TrimEnd(); // Comando TrimEnd() tira o espaço em branco no final da string
        }

        public string QuantoDevoComer(int peso)
        {
            return $"Como tenho {peso}kg, devo comer {(peso*1000)*0.05}g por dia";
        }
    }
}