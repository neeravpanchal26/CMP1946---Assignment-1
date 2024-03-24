IComponent<string> component = new ConcreteComponent();
IComponent<string> colorDecorator = new ColorDecorator(component);
IComponent<string> plainDecorator = new PlainDecorator(component);
IComponent<string> upperCaseDecorator = new UpperCaseDecorator(component);

Console.WriteLine(component.GetText());
Console.WriteLine(colorDecorator.GetText());
Console.WriteLine(plainDecorator.GetText());
Console.WriteLine(upperCaseDecorator.GetText());