namespace Flyweight
{
    class Person
    {
        public string job;
        public string gender;

        public Person(string job, string gender)
        {
            this.gender = gender;
            this.job = job;
        }
    }

    class MovingPerson
    {
        private int x;
        private int y;
        private int speed;
        private int destinationX;
        private int destinationY;

        private Person uniquePersonData;

        public MovingPerson(int x, int y, int speed, int destinationX, int destinationY, Person uniquePersonData)
        {
            this.x = x;
            this.y = y;
            this.speed = speed;
            this.destinationX = destinationX;
            this.destinationY = destinationY;
            this.uniquePersonData = uniquePersonData;
        }
    }

    class PersonFactory
    {
        private static List<Person> cache;

        static public Person getMovingPerson(string job, string gender)
        {
            if (PersonFactory.cache.Exists(person => PersonFactory.personMatch(person, job, gender)))
            {
                return PersonFactory.cache.Find(personMatch => PersonFactory.personMatch(personMatch, job, gender));
            }
            else
            {
                Person newPerson = new Person(job, gender);
                PersonFactory.cache.Add(newPerson);
                return newPerson;
            }
        }

        private static bool personMatch(Person person, string job, string gender)
        {
            if (person.job == job && person.gender == gender)
            {
                return true;
            }
            return false;
        }
    }

    class GtaGame
    {
        private List<MovingPerson> people;

        public void addPeopleToGame(string job, string gender, int x, int y, int destinationX, int destinationY, int speed)
        {
            Person personType = PersonFactory.getMovingPerson(job, gender);
            MovingPerson person = new MovingPerson(x, y, speed, destinationX, destinationY, personType);

            this.people.Add(person);
        }
    }
}