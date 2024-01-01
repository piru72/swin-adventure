## 1. Identifiable Object

- Create an Identifiable Object 
- This will become a foundation for many of 
the objects in the Swin-Adventure.
- Identifiable objects have a list of identifiers, and know ifthey are identified by a certain identifier


The player needs to be able to "identify" a number of things in the game. This includes commands the user will perform, items they will interact with, locations, paths, etc. The Identifiable 

Object role was created to encapsulate this functionality.

- Identifiable Object

    - The **constructor** adds identifiers to the Identifiable Object from the passed in array.

    -  **Are You** checks if the passed in identifier is in the _identifiers

    -  **First Id** returns the first identifier from _identifiers, or an empty string if the object has 
    no identifiers

    - **Add Identifier** converts the identifier to lower case and stores it in _identifiers