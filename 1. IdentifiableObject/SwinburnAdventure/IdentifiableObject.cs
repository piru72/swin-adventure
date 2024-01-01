using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinburnAdventure
{
    public class IdentifiableObject
    {
        private List<string> _identifiers;

        public string FirstId
        {
            get
            {
                if (_identifiers.Count == 0)
                {
                    return "";
                }
                else
                {
                    return _identifiers[0];
                }
            }
            
        }

        public IdentifiableObject(string[] idents)
        {
            _identifiers = new List<string>();

            foreach(string id in idents)
            {
                AddIdentifier(id);
            }

        }

        public bool AreYou(string id)
        {
              /*
            if (_identifiers.Contains(id.ToLower()))
               return true;
            else
                return false;

            */
            return _identifiers.Contains(id.ToLower());
        }

        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }


    }
}
