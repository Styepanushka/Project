namespace Project.User;

using System;

internal class User
{
    private string _name;
    private string _password;

    private class SemicolonError : Exception
    {
        public SemicolonError() : base("No ; in name or password")
        {

        }
    }

    public User(string name, string password)
    {
        if(name.Contains(';') || password.Contains(';'))
        {
            throw new SemicolonError();
        }
        _name = name;
        _password = password;
    }

    public override string ToString()
    {
        return _name + ';' + _password;
    }
}
