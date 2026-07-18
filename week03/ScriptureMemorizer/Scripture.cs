using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitText = text.Split(' ');
        foreach (string word in splitText)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> unhiddenWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                unhiddenWords.Add(word);
            }
        }

        if (unhiddenWords.Count == 0) return;

        int wordsToHide = Math.Min(numberToHide, unhiddenWords.Count);
        Random random = new Random();

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(unhiddenWords.Count);
            unhiddenWords[index].Hide();
            unhiddenWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string text = "";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }
        
        return $"{_reference.GetDisplayText()} {text.TrimEnd()}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
