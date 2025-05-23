public class Scripture
{
    Reference _reference = new Reference("Mosiah", 2, 17);
    private List<Word> _words = new List<Word>(
        
    );
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