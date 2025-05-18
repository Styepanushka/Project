using System.Xml.Linq;

namespace Project.Statya;

internal class ComboStatya : BaseStatya
{

    private List<BaseStatya> _substaties = [];

    public ComboStatya(int value, string name, string desc) : base(value, name, desc) { }

    public ComboStatya(string raw)
    {
        raw = raw.TrimStart('[');
        foreach(var i in raw.Split(' '))
        {
            if (i == "]")
                break;
            if (i.StartsWith("["))
            {
                _substaties.Add(new ComboStatya(i.TrimStart('[')));
                continue;
            }
            string[] a = i.Split(';');
            _substaties.Add(new BaseStatya(int.Parse(a[0]), a[1], a[2]));
        }
    }

    public void Add(BaseStatya statya)
    {
        _substaties.Add(statya);
    }

    public void Remove(BaseStatya statya) 
    {
        _substaties.Remove(statya);
    }

    public void CalculateAll()
    {
        foreach (BaseStatya baseStatya in _substaties)
        {
            if (baseStatya is ComboStatya) (baseStatya as ComboStatya).CalculateAll();
            _value += baseStatya._value;
        }
    }

    public override string ToString()
    {
        string s = "[";
        foreach(var i in _substaties)
        {
            s += i.ToString() + '\n';
        }
        s += "];";
        s += _name + ";" + _desc;
        return s;
    }

}
