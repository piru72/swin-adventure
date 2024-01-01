using System;
using System.Collections.Generic;


namespace SwinburnAdventure
{
    public class IdentifiableObject
    {
        private List<string> _identifiers;
        public string FirstId
        {
            get
            {
                // checking identifiers count
                int count = _identifiers.Count;
                if (count == 0)
                    return "";
                else
                    return _identifiers[0];
            }  
        }

        public IdentifiableObject(string[] idents)
        {
            // adding each identifier
            _identifiers = new List<string>();
            foreach(string id in idents)
                AddIdentifier(id);
        }

        public void AddIdentifier(string id)
        {
            // lowering the string for matching
            string processedString = id.ToLower();
            _identifiers.Add(processedString);
        }

        public bool AreYou(string id)
        {

            // lowering the string for matching
            string processedString = id.ToLower();
            return _identifiers.Contains(processedString);
        }

       


    }
}
