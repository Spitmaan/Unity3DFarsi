# Unity3DFarsi
Farsi support script for Unity3D

//##############################################################################
//#                                                                            #
//#   Unity Farsi                                                              #
//#                                                                            #
//#   @Copyright (C) 2014 By Mehran M. Spitmaan                                #
//#         from Azdaa (mehran.m.spitman@gmail.com)                             #
//#                                                                            #
//# 	                                                                         #
//#   This program is free software: you can redistribute it and/or modify     #
//#   it under the terms of the GNU General Public License as published by     #
//#   the Free Software Foundation, either version 3 of the License, or        #
//#   (at your option) any later version.                                      #
//# 	                                                                         #
//#   This program is distributed in the hope that it will be useful,          #
//#   but WITHOUT ANY WARRANTY; without even the implied warranty of           #
//#   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the            #
//#   GNU General Public License for more details.                             #
//#                                                                            #
//##############################################################################


You can download unity package and import it to your unity editor (Assets-> Import Package-> Custom Package)
open UnityFarsi.unity scene it click play! Enjoy!

Hierarchy:
/AssetStoreTools    => tools for editor
/Fonts    => needed fonts (you can add your font)
/Scripts
  ./Fa.cs     => Main Script (do not alter if you do not know how does it work!)
  ./Samples.cs    => you can see you script works
/UnityFarsi.unity     => sample unity scene

# Examples
Here is Some Example of usage.
Do not need to use any othe namespace. System.Collections is enough!!

string sample = "این یک نمونه است!";
string faSample = sample.faConvert ();
Debug.Log (sample.faConvert ());
Debug.Log(Fa.faConvert(sample));
Debug.Log ("این یک نمونه است!".faConvert ());
Debug.Log(Fa.faConvert("این یک نمونه است!"));

Debug.Log (faSample.faConvert ()); // DO NOT CONVERT A CONVERTED STRING!!!!!!!!

faSample = "این یک نمونه حاوی کلمات English است! همراه با پشتیبانی از حروف عربی - ي - ئ - ؤ - إ - أ - ة - ك";
faSample = "ك بك كب بكب - ة مة - ؤ مؤ - أذان - إذن - ي بي يب بيب - ئ بئ ئب بئب";

Debug.Log (faSample.faConvert ());
