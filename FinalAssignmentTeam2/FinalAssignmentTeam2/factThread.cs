using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FinalAssignmentTeam2
{
    class FactThread
    {
        // Thread for random number generator
        private static readonly ThreadLocal<Random> ranFactNumber = new ThreadLocal<Random>(() => new Random());

        // Array list for the list of cat facts
        private readonly List<String> catFacts = new List<String>
        {
            "If your cat's eyes are closed, it's not necessarily because it’s tired. A sign of closed eyes means your cat is happy or pleased.",
            "Rather than nine months, cat’s pregnancies last about nine weeks.",
            "Despite appearing like a wild cat, Ocicat does not have an ounce of wild blood.",
            "Want to call a hairball by its scientific name? Next time, say the word \"bezoar.\"",
            "Most cats don’t have eyelashes.",
            "According to the Guinness World Records, the largest domestic cat litter totals at 19 kittens, four of them stillborn.",
            "Cat have a string aversion to anything citrus.",
            "Some cats can survive falls from as high as 65 feet or more.",
            "In one litter of kittens, there could be multiple \"father\" cats.",
            "Landing on all fours is something typical to cats thinks to the help their eyes and special balance organs in their inner ear. These tools help them straighten themselves in the air and land upright on the ground.",
            "Cats can pick up on your tone of voice, so sweet-talking to your cat has more of an impact than you think.",
            "A cat’s meow is usually not directed at another cat, but at a human. To communicate with other cats, they will usually hiss, purr, and spit.",
            "As temperatures rise, so do the number of cats. Cats are known to breed in warm weather.",
            "In North America, cats are a more popular pet than dogs. Nearly 73 million cats and 63 million dogs are kept as household pets.",
            "Cats prefer their food at room temperature – not too hot, not to cold.",
            "Today, cats are living twice as long as they did just 50 years ago.",
            "Cats are unable to detect sweetness in anything they taste.",
            "It has been said that the Ukrainian Levkoy has the appearance of a dog, due to the angles of its face.",
            "Because of widespread cat smuggling in ancient Egypt, the exportation of cats was a crime punishable by death.",
            "A third of a cats’ time spent awake is usually spent cleaning themselves.",
            "Caution during Christmas: poinsettias may be festive, but they’re poisonous to cats.",
            "Ancient Egyptians first adored cats for their finesse in killing rodents – as far back as 4,000 years ago.",
            "Blue-eyed cats have a high tendency to be deaf, but not all cats with blue eyes are deaf.",
            "Most kittens are born with blue eyes, which then turn color with age.",
            "A kitten with green fur was discovered in Denmark in 1995. Originally thought to be a genetic mutation, scientists later determined it was due to the high copper levels in the water supply.",
            "Perhaps the oldest cat breed on record is the Egyptian Mau, which is also the Egyptian language’s word for cat.",
            "Genetically, cats’ brains are more similar to that of a human than a dog’s brain.",
            "The world’s most fertile cat whose name was Dusty, gave birth to 420 kittens in her lifetime.",
            "If you killed a cat in the ages of Pharaoh, you could’ve been put to death.",
            "A group of kittens is called a \"kindle\", and \"clowder\" is a term that refers to a group of adult cats.",
            "Outdoor cat’s lifespan averages at about 3 to 5 years; indoors cats have lives that last 16 years or more.",
            "Cats greet one another by rubbing their noses together.",
            "A cat’s heart beats almost double the rate of a human heart, from 110 to 140 beats per minute."
        };

        // The min is inclusive and max is exclusive
        // in a normal arraylist the min is 0 and max is arraylist size
        public static int GetFactNumber(int min, int max)
        {
            lock (ranFactNumber) // synchronize
            {
                return ranFactNumber.Value.Next(min, max);
            }
        }

        public string CatFact(List<String> factList)
        {
            // getting the randomly generated number for the list
            int factNumber = GetFactNumber(0, catFacts.Count + 1);

            // getting the fact from the list using the randomly generated number
            string fact = catFacts[factNumber];

            return fact;
            
        }


    }
}
