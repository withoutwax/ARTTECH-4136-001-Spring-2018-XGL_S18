﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// XGL Homework 2. This will test your skills with string manipulation functions.
// You'll need to write if-else statements as well.

public class XGLHW2 : MonoBehaviour {

	/*
	 * String Equality. Getting a character. Turning a character to a string.
	 * Concatenation. IndexOf(). Length. Substring.
	 * */

	// Return true if the input string is equal to "cool".
	// "cool" -> true
	// "not cool" -> false
	// "COOL" -> false
	static public bool _01_isItCool(string input) {

		if (input == "cool") {
			return true;
		} else {
			return false;
		}
	}

	// Given two strings, a and b, 
	// if the pattern ID is 1, return the strings combined in the form a + b,
	// if the pattern ID is 2, return the strings combined in the form b + a.
	// otherwise, return "invalid pattern".
	// You'll need to use string concatenation - combining strings - which requires using the "+" symbol like you would
	// for adding two numbers.

	// apple,banana,1 -> "applebanana"
	// apple,banana,2 -> "bananaapple"
	// apple,banana,3 -> "invalid pattern"
	static public string _02_stitcher(string a, string b, int patternID) {

		if (patternID == 1) {
			return a + b;
		} else if (patternID == 2) {
			return b + a;
		} else {
			return "invalid pattern";
		}

	}


	/* Given an input string, return the input string but with its first character
	 Repeated before and after the original string.
	 horse -> hhorseh
	 banana -> bbananab */
	static public string _03_front1(string input) {
		var firstString = input [0];

		return firstString + input + firstString;
	}

	/* Return true if the input string starts with the letter 'a' or 'A'.
	 You can get a character in a string using array notation: input[i] where 'i' is the index of the character you want
	 Note that to convert a single character from a string, you need to use .ToString() , e.g.:
				input[4].ToString() ...

	 "apple" -> true
	 "Arkansas" -> true
	 "banana" -> false */
	static public bool _04_startsWithA(string input) {

		var singleChar = input [0].ToString ();

		if (singleChar == "a" || singleChar == "A") {
			return true;
		} else {
			return false;
		}
	}


	/*Given a string, return a new string where "not " has been added to the front. 
	However, if the string already begins with "not", return the string unchanged. 
	Hint: use IndexOf to find if a string contains some other string.
	Hint: IndexOf returns an integer, which represents the index in the string in which the search string was found.

	("candy") → "not candy"
	("x") → "not x"
	("not bad") → "not bad" */
	static public string _05_notString(string input) {	

		var inputString = input.ToString ();

		if (inputString.IndexOf ("not") < 0) {
			return "not" + inputString;
		} else if (inputString.IndexOf ("not") >= 0) {
			return inputString;
		} else {
			return "";
		}
	}


	// return 'length' # of characters from the input string, starting at index 'startIndex', but
	// only if the length of 'input' is greater than or equal to 'length'. If input is less than length,
	// return the empty string "".

	// Note you can use .Length on a string, to get the length of a string.
	// You can use .Substring(i,j) to get a 'substring' of length j starting at index i. Note that 
	// strings index their characters starting at 0.

	// horse,6,3 -> ""
	// horse, 3, 1 -> "ors"
	// 
	static public string _06_redundantSubstring(string input, int length, int startIndex) {

		if (input.Length >= length) {
			return input.Substring (startIndex, length);
		} else {
			return "";
		}
	}

	// Return the string, but with the parts before and after a certain character flipped.
	// index will always be less than input.Length.
	// "apple",2 -> "le"+"p"+"ap" (or "lepap")
	// "boy",0 -> "oy"+""+"b" (or "oyb")
	// "boy",1 -> "y"+"o"+"b" (or "yob")
	// "boy",2 -> ""+"y"+"bo" (or "ybo")
	static public string _07_trickyString(string input, int index) {

		var centerString = input[index];
		var beforeString = input.Substring (0, index);

		if (index == 0) {
			beforeString = "";
		}

		var afterString = input.Substring (index + 1, input.Length);

		return beforeString + centerString + afterString;
	}



	// This function does nothing, but acts as a reference for correct syntax.
	void exampleSyntax() {
		// Basic math operators. You can also group things by parentheses.
		int a = 0;
		int b = 0;
		a = a + b;
		a = a - b;
		a = a * b;
		a = a / b;
		a = (a + 1) * b;
		a = (a + (b - 4)) * (b - (a / 2));

		// Increment/decrement operators. Increases or decreases a variable by 1.
		a ++;
		a--;
		a += 1;
		a -= 1;

		// Shorthand multiplication (equivalent to a = a * 2, and a = a / 2);
		a *= 2;
		a /= 2;

		// if-else statements. 
		bool c = false;
		bool d = false;

		if (c) {
			// Do something because c was true.
		}

		if (c) {
			// Do s.t. b/c c was true.
		} else {
			// Otherwise, do some default action.
		}

		if (c) {
			// Do s.t. b/c c was true.
		} else if (d) {
			// otherwise, do s.t. b/c d was true.
		} else {
			// Otherwise, do some default action.
		}


		string str = "apple";
		str = "apple" + "banana"; // str is now "applebanana"
		int i = 1;
		string ith_letter = str[i].ToString ();
		ith_letter = ith_letter + ith_letter;

		// .Substring() gets part of an existing string, or a 'substring'.
		// The first parameter is what character of the string the
		// substring should start from, the second parmater is how long the substring should be
		// In this case, we are getting 5 characters of the string 'str', starting at index 0.
		// So we are getting "apple" out of "applebanana".
		string partOfString = str.Substring (0, 5); // partOfString is now "apple".

		partOfString = partOfString + "1";
	}
}
