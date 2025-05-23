public class Scripture
{
    Reference _reference = new Reference("book", 0, 0);
    public List<Word> _words = new List<Word>();
    Scripture(Reference reference, string text)
    {

    }
    public void HideRandomWords(int numberToHide)
    {

    }
    public string GetDisplayText()
    {
        return "";
    }
    public bool IsCompletelyHidden()
    {
        return true;
    }
}