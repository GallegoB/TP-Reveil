using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Rappel
    {
        //--- propriétés ---
        private string libelle;
        private DateTime date;
        private int frequence;

        //--- constructeur ---
        public Rappel(string libelle, DateTime date, int frequence)
        {
            this.libelle = libelle;
            this.date = date;
            this.frequence = frequence;
        }

        //-- Getters ---
        public string getLibelle() { return this.libelle; }
        public DateTime getDate() { return this.date; }
        public int getFrequence() { return this.frequence; }

        //--- Modification de la date suivant la fréquence ---
        public void suivant()
        {
            switch (this.frequence)
            {
                case 1: // journalier
                    this.date = this.date.AddDays(1);
                    break;
                case 2: // hebdomadaire
                    this.date = this.date.AddDays(7);
                    break;
                case 3: // mensuel
                    this.date = this.date.AddMonths(1);
                    break;
                case 4: // annuel
                    this.date = this.date.AddYears(1);
                    break;
            }

        }
    }
}