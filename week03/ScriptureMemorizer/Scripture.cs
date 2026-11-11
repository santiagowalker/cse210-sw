using System.Data;
using System.Reflection.Metadata;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            Word w = new Word(word);
            _words.Add(w);
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;
        while (hiddenCount < numberToHide && IsCompletelyHidden() == false)
        {
            Word randomWord = GetRandomWord();
            if (randomWord.IsHidden() == false)
            {
                randomWord.Hide();
                hiddenCount += 1;
            }
        }
    }
    private Word GetRandomWord()
    {
        Random random = new Random();
        int index = random.Next(0, _words.Count);
        return _words[index];
    }
    public string GetDisplayText()
    {
        string scripture = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            scripture += word.GetDisplayText() + " ";
        }
        return scripture;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (w.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}


