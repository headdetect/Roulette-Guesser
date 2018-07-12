using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteGuesser
{
    class Guesser
    {
        public const string FileName = "brain.txt";

        public List<Spin> Spins { get; set; } = new List<Spin>();

        public Guesser()
        {
            LoadBrain();
        }

        public void LoadBrain()
        {

        }

        public void SaveBrain()
        {

        }
    }
}
