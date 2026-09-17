using UnityEngine;

//this is our interface
//it acts like a socket between two bits of code
//think of it like a type c charger
//It doesn't matter what it is plugged into, as long as:
//It has a type C port

//we can call this
public interface Iclickable
{
    //and then it will look foe this piece of code
    //on the other code block
    void OnClick();

    //what happens if it doesn't find it?
}