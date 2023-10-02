using Delegate;
//ActionDelegateVersion();
//ActionVersion();
//Console.WriteLine(FuncDelegateVersion(1, 2, (x, y) => x + y));
//Console.WriteLine(FuncVersion(1, 2, (x, y) => x + y));
//EventDelegateVersion();
EventVersion();

void ActionDelegateVersion()
{
    PrintMessageDelegate printMessage = msg => Console.WriteLine(msg);
    printMessage("1");
}

void ActionVersion()
{
    Action<string> printMessage = msg => Console.WriteLine(msg);
    printMessage("2");
}

int FuncDelegateVersion(int x, int y, MathOperation operation)
{
    return operation(x, y);
}

int FuncVersion(int x, int y, Func<int, int, int> func)
{
    return func(x, y);
}

void EventDelegateVersion()
{
    var thermostat = new ThermostatDelegate();
    TemperatureChangedHandler handler = (newTemp) => Console.WriteLine($"Temperature changed to {newTemp}°C");
    thermostat.AddTemperatureChangedHandler(handler);
    thermostat.Temperature = 25.5; // This will trigger the delegate
}

void EventVersion()
{
    var thermostat = new Thermostat();
    thermostat.TemperatureChanged += (sender, e) => Console.WriteLine($"Temperature changed to {((Thermostat)sender).Temperature}°C");
    thermostat.Temperature = 25.5; // This will trigger the event
}

delegate void PrintMessageDelegate(string message);

public delegate int MathOperation(int x, int y);


