//Jacob 6:12 O be awise; what can I say more?

using System.Runtime.CompilerServices;
using System.Collections.Generic;

public class Scripture
{

    Reference reference = new Reference();

    private List<Word> wordList = new List<Word>(); //Make a list for Words to be storded in

    public Scripture()
    {
        MakeScriptureWordList();
    }

    private void MakeScriptureWordList(){ // Each word in the scritur qoute will turn into a item Word (Word is a class)
        string[] wordsArray;
                wordsArray = reference._scripture.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // Got this code online slipts each word seperated with a space into a item in a array
        // Creat each Word item in list/Array
        foreach(string word in wordsArray)
        {
     
            wordList.Add(new Word(word));
        }
    }
    public string GetDiaplyText(){ //Get string of the entire phrase of all the words from the qoute then return it as a string

        string phrase = "";

        foreach(Word item in wordList){
            if (item.IsHidden() == true){ // See if the word is supost to be hidden if true then hide it

                phrase = phrase + "____" + " "; //Add blank word intead of what the word would be
            }
            else{ //If word is not hidden then show it in the list

                phrase = phrase + item.GetWordString() + " "; //add all previous words then the one new word, then add space at the end.
            }
        }

        phrase = reference.GetReferenceString() + " " + phrase;
        return phrase;
    }

    public void HideRandomWord(int numberOfRandomWords = 0)
    {
        Random random = new Random();
        int I = 1;
        int randumNumber;

        while (numberOfRandomWords >= I && IsCompletelyHidden() == false)
        {
            randumNumber = random.Next(0, wordList.Count()); // pick a random item from 0 to max length of list in wordList

            if (wordList[randumNumber].IsHidden() == true)
            {
                // Skip
            }
            else
            {
                wordList[randumNumber].Hide(); // Tell randumNumber item to hide
                I = I + 1;
            }
        }
    }               

    public bool IsCompletelyHidden()
    {
        bool allHidden = true;
        foreach(Word item in wordList)//This methood is very odd to find if all items are hidden or not bot it works!
        { 
            if(item.IsHidden() == false)
            {
                allHidden = false;
            }
        }
        return allHidden;
    }
}
