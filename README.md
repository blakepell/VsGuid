# VsGuid
VsGuid is a simple Visual Studio Extension (VSIX) that inserts a guid into the code window when a specified hot key is pressed.

## Supported Versions:
  - Visual Studio 2015
  - Visual Studio 2013
  - Visual Studio 2012

## Notes

This does not yet install with a hot key.  In order to map this command to a hot key you will want to 
follow these steps and map it to a key of your choice.

1. Click the Tools menu
2. Click the Options menu
3. Under Environment, select Keyboard.
4. In the commands, search for InsertGuid and then select Tools.InsertGuid
5. In the bottom of that box select your shortcut key, you will put your mouse in the "Press shortcut keys" box and then press the key combination you want.  Visual Studio will tell you if combination you selected it already in use and what is using it.