

using System;
using System.Collections.Generic;

public class Scripture
{
    public Reference Reference { get; }
    public string Text { get; }

    private List<Word[]> _lines;  // Each line is an array of Word objects
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Text = text;
        _lines = new List<Word[]>();
        _random = new Random();

        // Split text into lines, then split each line into words
        string[] lines = text.Split('\n', StringSplitOptions.RemoveEmptyEntries);
        foreach (string line in lines)
        {
            string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Word[] wordObjs = new Word[words.Length];
            for (int i = 0; i < words.Length; i++)
                wordObjs[i] = new Word(words[i]);
            _lines.Add(wordObjs);
        }
    }

    // Returns the scripture text, replacing hidden words with underscores
    public string Get_HiddenWordsOnly()
    {
        string result = "";
        foreach (Word[] line in _lines)
        {
            foreach (Word w in line)
                result += w.GetText() + " ";
            result = result.Trim() + "\n";
        }
        return result.TrimEnd();
    }

    // Hide a specific number of words randomly
    public void Hide_RandomWords(int wordsToHide = 2)
    {
        int hiddenCount = 0;

        while (hiddenCount < wordsToHide && !All_WordsHidden())
        {
            int lineIndex = _random.Next(_lines.Count);
            int wordIndex = _random.Next(_lines[lineIndex].Length);

            Word w = _lines[lineIndex][wordIndex];
            if (!w.IsHidden())
            {
                w.Hide();
                hiddenCount++;
            }
        }
    }

    // Checks if all words are hidden
    public bool All_WordsHidden()
    {
        foreach (Word[] line in _lines)
            foreach (Word w in line)
                if (!w.IsHidden())
                    return false;
        return true;
    }
}