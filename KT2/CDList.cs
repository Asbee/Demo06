using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT2
{
    class CDList
    {
        private List<CD> cd;

        public CDList()
        {
            cd = new List<CD>();
        }

        public void AddSongs(CD songs)
        {
            cd.Add(songs);
        }
        
        public void PrintCollection()
        {
            Console.WriteLine("CD Data: ");
            Console.WriteLine("- name: Endless Forms Most Beautiful");
            Console.WriteLine("- artist: Nightwish\n");
            Console.WriteLine("- Songs:");
            foreach (CD songs in cd)
            {
                Console.WriteLine(songs.ToString());
            }
        }
    }
}
