using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
{
    internal class Indirizzo
    {

        private string nome;
        private string cognome;
        private string via;
        private string città;
        private string provincia;
        private string codicepostale;

        public Indirizzo(string nome, string cognome, string via, string città, string provincia, string codicepostale)
        {
            this.nome=nome:
                this.cognome = cognome;
            this.via = via;
            this.città = città;
            this.provincia = provincia;
            this.codicepostale = codicepostale;
        }

        public string GetNome()
        {
            return nome;
        }

        public string GetCognome()
        {
            return cognome;
        }

        public string GetVia()
        {
            return via;
        }

        public string GetCittà()
        {
            return città;
        }

        public string GetProvincia()
        {
            return provincia;

        }

        public string GetCodicePostale()
        {
            return codicepostale;
        }

        public override string ToString()
        {
            return "Nome: " + this.nome + "\tCognome: " + this.cognome + "\tVia: " + this.via + "\tCittà" + this.città + "\tProvincia" + this.provincia + "\tCodicePostale" + this.codicepostale;
        }

    }
}

