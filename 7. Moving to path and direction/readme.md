## 7. Path Direction and Move Command

Notes:
- Have the Path objects move the player to the new location. This will allow for flexibility 
like lockable paths etc.
- Make Path's identifiable. The identifiers indicate the direction, and can be used to locate 
the path from the location.
- The Move Command is identified by the words "move", "go", "head", "leave", ...
Here are some hints for things you will need to test for:
- Path can move player to the Path’s destination
- You can get a Path from a Location given one of the path's identifiers
- Players can leave a location, when given a valid path identifier
- Players remain in the same location when they leave with an invalid path identifier