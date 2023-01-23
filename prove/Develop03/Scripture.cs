using System;

class Scripture
{
    //This is what will be kept as a scripture track
    private string scriptureText;

    private Reference scriptureReference;
 
    public Scripture (Reference _scriptureReference, string _scriptureText) 
    {
        scriptureReference = _scriptureReference;
        scriptureText = _scriptureText;
    }

    public string toString()
    {
        return string.Format("{0}", scriptureText );
    }
}