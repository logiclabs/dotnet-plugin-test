using Spectre.Console;

// Display a fancy "Hello Dave" title
AnsiConsole.Write(
    new FigletText("Hello Dave!")
        .Centered()
        .Color(Color.Green));

// Create a nice panel with a welcome message
var panel = new Panel("[bold yellow]Welcome to Spectre.Console![/]\n\n" +
                      "[cyan]This is a simple Hello World application[/]\n" +
                      "[dim]Built with .NET 10 and Spectre.Console[/]")
{
    Header = new PanelHeader("[bold blue]Greetings![/]"),
    Border = BoxBorder.Rounded,
    BorderStyle = new Style(Color.Blue)
};

AnsiConsole.Write(panel);

// Display a simple colored message
AnsiConsole.MarkupLine("\n[green]Application completed successfully![/]");
