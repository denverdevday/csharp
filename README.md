# CIS-230-01-SP23-W04

In your `/.vscode/launch.json` file, replace `"console"` configuration line with these two lines.

````json
"console": "externalTerminal",
"internalConsoleOptions": "neverOpen",
````
---

## What'll it do?

The **Program class** in this code is an example of a console-based user interface, it has several methods that work together to achieve this. Here is an explanation of each method:

**Main Method**: This is the entry point of the application. It starts by clearing the console screen and hiding the cursor. Then it defines an array of `items` and calls the `Menu.Draw()` method with the `items` array as an argument. The `Menu.Draw()` method returns the selected item which is then written to the console. After that, the method animates a loading bar by calling the `Progress.Draw()` method. Finally, the method prompts the user to press any key to continue.

**Box.Draw() Method**: This method is used to draw a box on the console screen. It takes four arguments: `x`, `y`, `height`, and `width` which represent the position and size of the box. It also has an optional `fill` argument which specifies the character to fill the inside of the box with. This method uses `foreach` loop to go through the `Build` method and write each line of the box to the console.

**Progress.Draw() Method**: This method is used to show a progress bar on the console screen. It takes four arguments: `x`, `y`, `percentage`, and `size` which represent the position and size of the bar. It uses the `Box` method to draw the box and then calculates the percentage to fill the bar with a character. The method then uses the `Write` method to write the bar to the console screen.

**Menu.Draw() Method**: This method is used to display a menu on the console screen and to get the user's selection. It takes three arguments: `x`, `y`, and `items` which represent the position and the items to display in the menu. The method uses the `Box.Draw()` method to draw the box and the `Screen.WriteAt()` method to write the items to the console screen. The method listens to the user's key inputs and updates the selected item in the menu. The method returns the selected item.

**Screen.WriteAt() Method**: This method is used to write text to the console screen. It takes four arguments: `x`, `y`, `highlight`, and `text` which represent the position and the text to write. The method uses the `Console.SetCursorPosition()` method to set the cursor's position and then writes the text to the console. If the `highlight` argument is true, the method changes the text's foreground and background colors.

**Screen.Listen() Method**: This method is used to listen to the user's key inputs. It takes two arguments: `key` and `allowed` which represent the user's key press and the allowed keys. The method uses the `Console.ReadKey()` method to read the key input and then checks if the key is one of the allowed keys using the `Contains()` method. If the key is not allowed, the method loops and continues to listen.