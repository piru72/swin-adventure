## 1. Identifiable Object

- Create an Identifiable Object 
- This will become a foundation for many of 
the objects in the Swin-Adventure.
- Identifiable objects have a list of identifiers, and know ifthey are identified by a certain identifier

## 2 Player , Item and Inventory

- Create the Player, Item, and Inventory classes 
- the ability to locate things within these objects. 
- It should be possible to add items into the Player's inventory and then get the player to locate the item for us.

## 3. Bag Class
The **Bag** abstraction is a special kind of item, one that contains other items in its own Inventory. This is a version of the **composite pattern**, which allows flexible arrangements of bags and 
items, for example a bag to contain another bag.


## 4. Looking Command

As there will be a number of Commands, an abstract Command class has also been added.

- This class inherits from Identifiable Object, as each of the commands needs to be identifiable. 
- When data is entered by the user, each Command object will be asked “Are You” and the 
first work of the command.

- For example, with “look at pen” each Command would be asked 
“Are You ‘look’ ” to locate the Command to process the text. As a result the Look Command 
should be identified by “look”.

## 5. All of them Together

It compiles the steps above into a single program to be run from the command line.

##
The final project has not been extensively tested.