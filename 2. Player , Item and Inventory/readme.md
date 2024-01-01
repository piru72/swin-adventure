## 2. Player , Item and Inventory

- Create the Player, Item, and Inventory classes 
- the ability to locate things within these objects. 
- It should be possible to add items into the Player's inventory and then get the player to locate the item for us.


The **Game Object** class will be used to represent anything that the player can interact with. 

- **Game Object** - "anything" the player can interact with
- **Name** - this is a short textual description of the game object
- **Description** - a longer textual description of the game object
- **Short Description** - returns a short description made up of the name and the first id of 
the game object. This is used when referring to an object, rather than directly examining the object.
- **Long Description** - By default this is just the description, but it will be changed by child 
classes to include related items.

**Player** is also a kind of Game Object. This will be a object through which the player will interact with the game world. 
- **Player** - the players avatar in the game world
- An **Inventory object** is used to manage the Player's items
- **Full Description** is overridden to include the player’s name, description, and details of 
the items in the player's inventory.
- **Locate** "finds" a GameObject somewhere around the player. At this stage that includes 
the player themselves, or an item the player has in their inventory

A number of GameObjects will need to contain Items. This functionality is encapsulated in the 
**Inventory** class. This provides a managed list of items.
- **Inventory** - a managed collection of items
- Items can be added using **Put**, or removed by id using **Take**
- **Fetch** locates an item by id (using AreYou) and returns it