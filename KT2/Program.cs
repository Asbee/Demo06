using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT2
{
    class Program
    {
        static void Main(string[] args)
        {
            CDList songs = new CDList();

            CD songs1 = new CD { SName = "Shudder Before the Beautiful", Time = "6:29" };
            CD songs2 = new CD { SName = "Weak Fantasy", Time = "5:23" };
            CD songs3 = new CD { SName = "Elan", Time = "4:45" };
            CD songs4 = new CD { SName = "Yours Is an Empty Hope", Time = "5:34" };
            CD songs5 = new CD { SName = "My Walden", Time = "6:37" };
            CD songs6 = new CD { SName = "Shudder Before the Beautiful", Time = "4:38" };

            songs.AddSongs(songs1);
            songs.AddSongs(songs2);
            songs.AddSongs(songs3);
            songs.AddSongs(songs4);
            songs.AddSongs(songs5);
            songs.AddSongs(songs6);

            songs.PrintCollection();

        }
    }
}
