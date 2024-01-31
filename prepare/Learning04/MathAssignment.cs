using System;

public class MathAssignment : Assignment
{
  private string _textbookSection;
  private string _problems;

  public MathAssignment (string studentName, string topic,string textboookSection, string problems) : base(studentName, topic)
  {
    _textbookSection = textboookSection;
    _problems = problems;
  }

  public string GetHomeworkList()
  {
    return $"Section {_textbookSection} Problems {_problems}";
  }
}