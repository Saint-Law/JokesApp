using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesApp.Models
{
    public class Jokes
    {
        public int Id { get; set; }
        public string jokeQuestion { get; set; }
        public string jokesAnswer { get; set; }

        public Jokes()
        {

        }
    }
}
