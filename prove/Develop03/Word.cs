using System;

class Word
{

  private string _text;
  private bool _isHidden;
  
  public bool IsHidden()
  {
    return _isHidden;
  }

  public Word(string text)
  {
    _text = text;
  }

  public void Hide()
  {
    _isHidden = true;
  }

  public void Show()
  {
    _isHidden = false;
  }

  public string GetDisplayText()
  {
    if (_isHidden)
    {
      string[] underscoredWord = new string[_text.Length];
      for (int i = 0; i < _text.Length; i++)
      {
        underscoredWord[i] = "_";
      }
      string result = string.Concat(underscoredWord);

      return result;
    }
    else
    {
      return _text;
    }
  }

}