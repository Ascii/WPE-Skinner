# WPE Skinner
*Windows Phone Emulator Skin Picker*

----------

**What It Currently Does And Doesn't.**

- Has to be run as Administrator for it to copy the .xml file over.
- Doesn't Come With Any Skins.
- Doesn't Create The Folders For You.
- Does Selects The Correct WM7_Skin.XML File So You Can You Different Skins On Your Emulator.
- Does: rewrite the Microsoft XDE\1.0\WM7_Skin.xml file with the one the skin folder that is picked

**Version: ALPHA!**



## File Structure ##

----------


Microsoft XDE\1.0\skin\Default

Microsoft XDE\1.0\skin\Default\WM7_Skin.xml

Microsoft XDE\1.0\skin\NokiaLumia800Cyan

Microsoft XDE\1.0\skin\NukiaLumia800Cyan\WM7_Skin.xml


**Note:** In the .xml files the path to the images have to be mapped like this (so it points to the relative path to the skin correctly).

> 		mappingImage="skin\NokiaLumiaCyan\Nokia_Lumia_800_Cyan_Mask.png"
> 		normalImage="skin\NokiaLumiaCyan\Nokia_Lumia_800_Cyan_Up.png"
> 		downImage="skin\NokiaLumiaCyan\Nokia_Lumia_800_Cyan_Down.png">



