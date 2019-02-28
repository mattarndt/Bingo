using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArndtBingo
{
    class Player
    {
        private String playerName;

        public void setName(String name)
        {
            this.playerName = name;
        }

        public String getName()
        {
            return playerName;
        }
    }
}
