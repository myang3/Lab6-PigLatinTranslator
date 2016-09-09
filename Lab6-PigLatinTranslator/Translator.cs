using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_PigLatinTranslator
{
       public class translator
    {
        public string Translate(string wordToTranslate)

        {

        string firstcharacter = wordToTranslate.Substring(0, 1);
        if (IsVowel(firstcharacter))
        {
        return wordToTranslate + "way";
        }

    int startPositionOfFirstVowel = 0;
    for (int i = 0; i < wordToTranslate.Length; i++)
        {
        char[] letters = wordToTranslate.ToArray();
        string testLetter = letters[i].ToString();
    if(IsVowel(testLetter)){
    startPositionOfFirstVowel = i;
        break;
        }
}

string firstconstanant = wordToTranslate.Substring(0, startPositionOfFirstVowel);
string remainingword = wordToTranslate.Substring(startPositionOfFirstVowel);
string translatedword = remainingword + firstconstanant + "ay";
return translatedword;
    }

    public bool IsVowel(string testcharacter)
{
    if (testcharacter == "a"||testcharacter == "e"||testcharacter == "i"||testcharacter == "o"  || testcharacter == "u" || testcharacter == "A" || testcharacter == "E" || testcharacter == "I" || testcharacter == "O" || testcharacter == "U") { return true; }
    else return false;
}

    }
}

/*
  string a_word=”help!”;
			0,1,2,3
String [] wordAsArray= a _word.ToArray() //changes it into characters array by letter
For (int i=0; i<wordAsArray.Length;i++)
{string testLetter = wordAsArray[]; //way1
String versiontest2 = a.word.substring(i,1); //way2
}
Check each character, use array or substring
*/

