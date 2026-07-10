using Section05;

public class CodeExe11
{

    private readonly string value;

    public string Value
    {
        get => value;
    }

    public CodeExe11(string _value)
    {
        value = _value;
    }
    public static void Run()
    {
        PrintReadOnlyProperty();
    }

    public static void PrintReadOnlyProperty()
    {
        CodeExe11 codeExe11 = new CodeExe11("Read-Only Property Value");
        System.Console.WriteLine(codeExe11.Value);
    }
}