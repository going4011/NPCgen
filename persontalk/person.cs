using System;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persontalk
{
    class person
    {
        private string npcName = "Not Specified";
        private int npcAge = 0;
        private string npcOccupation = "Not Specified";
        private string npcPersonality = "Not Specified";
        private string npcTemperment = "Not Specified";

        //========================================================================================
        //PROPERTY GET AND SET
        //
        //NAME get and set
        public string Name
        {
            get
            {
                return npcName;
            }

            set
            {
                npcName = value;
            }
        }

        //AGE get and set
        public int Age
        {
            get
            {
                return npcAge;
            }

            set
            {
                npcAge = value;
            }
        }

        //OCCUPATION get and set
        public string Occupation
        {
            get
            {
                return npcOccupation;
            }

            set
            {
                npcOccupation = value;
            }
        }

        //PERSONALITY get and set
        public string Personality
        {
            get
            {
                return npcPersonality;
            }

            set
            {
                npcPersonality = value;
            }
        }

        //========================================================================================
        //RandomFromList: Takes filename of embedded resource and returns a random line from within
        //EX: Returns a random name to be assigned to an NPC
        private string RandomFromList(string fileName)
        {
            Assembly _assembly;
            StreamReader _textStreamReader;

            try
            {
                //open communication with specified text file
                _assembly = Assembly.GetExecutingAssembly();
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream(fileName));
                //choose a random item from the list
                string chosen = null;
                string line = null;
                int numberSeen = 0;
                var rng = new Random();
                while ((line = _textStreamReader.ReadLine()) != null)
                {
                    if (rng.Next(++numberSeen) == 0)
                    {
                        chosen = line;
                    }
                }

                //return the chosen item
                return chosen;
            }

            //return an error if file can't be accessed
            catch
            {
                return "error";
            }
        }

        //========================================================================================
        //Initialize: Generates a new NPC with a random name, age, occupation and personality
        public void initialize()
        {
            var rng = new Random();
            this.Name = RandomFromList("persontalk.names.txt");
            this.Age = rng.Next(14, 106);
            this.Occupation = RandomFromList("persontalk.occupations.txt");
            this.Personality = RandomFromList("persontalk.personalities.txt");

        }
    }
}
