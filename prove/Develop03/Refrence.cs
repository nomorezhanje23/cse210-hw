using System;

// use the class name to start building on your program

class Reference
{
    // These have been declared at once but will be difined in the contructer.
    private string book, chapter, verse;

    //This is the constructor and should always be public

    public Reference (string _book, string _chapter, string _verse)

    //set the attributes to what has been passed in inside the constructor

    {
        book      = _book;
        chapter   = _chapter;
        verse     = _verse;
    }

    //This code is to return what the Reference hold. This can als be printed if needs be
    // Like to say display.Reference etc
    public string toString()
    {
        return string.Format("{0} {1}:{2}" ,book, chapter, verse);
    }


}