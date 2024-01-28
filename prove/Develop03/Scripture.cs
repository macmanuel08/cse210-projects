using System;

class Scripture
{
  public Reference Reference { get; }
  private List<Word> _words = new List<Word>();

  public Scripture(Reference reference, string text)
  {
    Reference = reference;

    string[] wordInArray = text.Split(' ');
    foreach (string word in wordInArray)
    {
      Word eachWord = new Word(word);
      eachWord.Show();

      _words.Add(eachWord);
    }
  }

  public void HideRandomWords(int numberToHide)
  {
    for (int i = 0; i < numberToHide; i++)
    { 
      bool notHiddenAWord = true;
      while (notHiddenAWord)
      {
        int randomNumber = RandomNumber();
        if (!_words[randomNumber].IsHidden())
        {
          _words[randomNumber].Hide();
          notHiddenAWord = false;
        }
        else if (IsCompletelyHidden())
        {
          break;
        }
      }
    }
  }

  

  public string GetDisplayText()
  {
    string text = "";
    foreach (Word word in _words)
    {
      text += $"{word.GetDisplayText()} ";
    }
    return text;
  }
  
  public bool IsCompletelyHidden()
  {
    bool allWordsHidden = true;
    foreach (Word word in _words)
    {
      if (word.IsHidden() == false) {
        allWordsHidden = false;
        return allWordsHidden;
      }
    }
    return allWordsHidden;

  }

  private int RandomNumber()
  {
    Random randomGenerator = new Random();
    return randomGenerator.Next(0, _words.Count);
  }
}