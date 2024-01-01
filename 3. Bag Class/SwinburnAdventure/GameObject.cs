

namespace SwinburnAdventure
{
    public abstract class GameObject : IdentifiableObject

    // inheriting  IdentifiableObject so now this class willhave accesss to all the method and public fields of the parent class
    {
        private string _name;
        private string _description;

        public string Name 
        { 
            get { return _name; }
        }

        public string ShortDescription
        {
            get 
            {

                // building the string 
                string processedName = Name + " (" ;
                string processedDesc = FirstId + ")";
                string result = processedName + processedDesc;
                return result ;
            }
        }

        public virtual string FullDescription 
        {
            get { return _description; }
        }


        public GameObject(string[] ids, string name, string desc) : base(ids)
        {
            _name = name;
            _description = desc;
        }
    }
}
