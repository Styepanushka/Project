using System.Xml.Linq;

namespace Project.Statya;

internal class BaseStatya
{
    public int _value { get; protected set; }

    public string _desc { get; protected set; }
    public string _name { get; protected set; }

    public BaseStatya(int value, string name, string desc)
    {
        this._value = value;
        this._name = name; 
        this._desc = desc;
    }

    public BaseStatya()
    {
        this._name = "";
        this._value = 0;
        this._desc = "";
    }

    public override string ToString()
    {
        return _value.ToString() + ";" + _name + ";" + _desc + "\n";
    }
}
