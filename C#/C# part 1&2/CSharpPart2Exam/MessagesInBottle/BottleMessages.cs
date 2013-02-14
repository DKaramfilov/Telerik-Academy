using System;
using System.Collections.Generic;
using System.Text;

class BottleMessages
{
    static void Main()
    {
        string code = Console.ReadLine();
        string cipherToDEcode = Console.ReadLine();
        List<CipherElement> cipher = BuilderCipher(cipherToDEcode);
        List<State> states = new List<State>();
        List<string> results =new List<string>();

        states.Add(new State() { Obtained ="", Left = code});
        int index = 0;
        while (index < states.Count)
        {
            State curentState = states[index];
            index++;
            foreach (var cipherEl in cipher)
            {
                if( curentState.Left.StartsWith(cipherEl.Digits))
                {
                    State state = new State();
                    state.Obtained = curentState.Obtained + cipherEl.Letter;
                    state.Left = curentState.Left.Remove(0,cipherEl.Digits.Length);
                    if (state.Left == "")
                    {
                        results.Add(state.Obtained);
                    }
                    else
                    {
                        states.Add(state);
                    }
                }
            }
        }
        Console.WriteLine(results.Count);
        results.Sort();
        foreach (var item in results)
        {
            Console.WriteLine(item);
        }
    }

    private static List<CipherElement> BuilderCipher(string cipherTodecode)
    {
        char? letter = null;
        List<CipherElement> elements = new List<CipherElement>();
        StringBuilder digits = new StringBuilder();
        foreach (var item in cipherTodecode)
        {
            if(char.IsLetter(item))
            {
                if (letter !=null)
                {
                    CipherElement element = new CipherElement();
                    element.Letter = letter;
                    element.Digits = digits.ToString();
                    elements.Add(element);
                    digits.Clear();
                }
                letter = item;
            }
            else
	        {
                digits.Append(item);

	        }
            
        }
        CipherElement Lastelement = new CipherElement();
        Lastelement.Letter = letter;
        Lastelement.Digits = digits.ToString();
        elements.Add(Lastelement);
        digits.Clear();
        return elements;
    }
}
class State
{
    public string Obtained { get; set; }
    public string Left { get; set; }
}
class CipherElement
{
    public char? Letter { get; set; }
    public string Digits { get; set; }
}