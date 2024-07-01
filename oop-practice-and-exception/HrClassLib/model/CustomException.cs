namespace model.HrClassLib;

public class WrongName : Exception
{
    public WrongName() { }
    public WrongName(string message) : base(message) { } // :base(message) calles the constructore
}
