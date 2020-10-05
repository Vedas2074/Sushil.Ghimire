using System;
class person
{
    internal string name;
    byte age=23;
    public byte Age
    {
        get
        {
            return age;
        }
        set
        {
            if(value >20 && value <30)
                age=value;
        }
    }
}
// public string Name {get; set;}
// {
    
// }
// public string Address {get;}
// {

// }


    