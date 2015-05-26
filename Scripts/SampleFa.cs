//##############################################################################
//#                                                                            #
//#   Unity Farsi                                                              #
//#                                                                            #
//#   @Copyright (C) 2014 By Mehran M. Spitmaan                                #
//#         from Azdaa (mehran.m.spitman@gmail.com)                            #
//#                                                                            #
//# 	                                                                       #
//#   This program is free software: you can redistribute it and/or modify     #
//#   it under the terms of the GNU General Public License as published by     #
//#   the Free Software Foundation, either version 3 of the License, or        #
//#   (at your option) any later version.                                      #
//# 	                                                                       #
//#   This program is distributed in the hope that it will be useful,          #
//#   but WITHOUT ANY WARRANTY; without even the implied warranty of           #
//#   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the            #
//#   GNU General Public License for more details.                             #
//#                                                                            #
//##############################################################################

using UnityEngine;
using System.Collections;

public class SampleFa : MonoBehaviour {

	public GUIText gTEXT;
	public string test;
	public GUISkin guiskinn;
	//
	void Awake()
	{
		gTEXT = GameObject.Find("GUI Text").GetComponent<GUIText> ();
	}
	void OnGUI() {
		test = GUI.TextField(new Rect(10, 10, 200, 20), test, 25);
	}
	public string sample;


	// Here is Some Example of usage
	// Do not need to use any othe namespace. System.Collections is enough!!
	// در اینجا مثال هایی از نحوه استفاده را مشاهده خواهید کرد
	// نیاز به افزودن namespace جدید نمی باشد.
	void Update () {

		if (Input.inputString != "")
		{
			int asciiCode = System.Convert.ToInt32(Input.inputString[0]);
			Debug.Log(asciiCode);
		}

//		string sample = "این یک نمونه است!";
//		string faSample = sample.faConvert ();
//		Debug.Log (sample.faConvert ());
//		Debug.Log(Fa.faConvert(sample));
//		Debug.Log ("این یک نمونه است!".faConvert ());
//		Debug.Log(Fa.faConvert("این یک نمونه است!"));
//
////		Debug.Log (faSample.faConvert ()); // DO NOT CONVERT A CONVERTED STRING!!!!!!!!
//
//		faSample = "این یک نمونه حاوی کلمات English است! همراه با پشتیبانی از حروف عربی - ي - ئ - ؤ - إ - أ - ة - ك";
//		//faSample = "ك بك كب بكب - ة مة - ؤ مؤ - أذان - إذن - ي بي يب بيب - ئ بئ ئب بئب";
//
//		Debug.Log (faSample.faConvert ());
//
//		gTEXT.text = faSample.faConvert();

		sample = test.faConvert();
		gTEXT.text = ""+sample;
	}
}
