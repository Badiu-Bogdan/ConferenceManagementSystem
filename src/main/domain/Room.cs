
namespace ConferenceManagementSystem.src.main.domain
{
    public class Room
    {
        private int id;
        private string name;
        private int capacity;

        public Room(int id, string name, int capacity)
        {
            this.id = id;
            this.name = name;
            this.capacity = capacity;
        }
        public Room(string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
        }

        // Getters and Setters
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
    }
}
