using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СделкаИлиНе
{
    public class Player
    {
        public string Name { get; private set; }
        public decimal Prize { get;  set; }
        public Player(string name, decimal prize)
        {
            this.Name = name;
            this.Prize = prize;
        }
        public override string ToString()
        {
            return $"{this.Name} - {this.Prize:f2}";
        }
    }
}
