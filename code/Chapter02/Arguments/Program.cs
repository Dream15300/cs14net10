WriteLine($"There are {args.Length} arguments.");

foreach (string arg in args)
{
  WriteLine(arg);
}

if (args.Length < 3)
{
  WriteLine("You must specify two colors and cursor size, e.g.");
  WriteLine("dotnet run red yellow 50");
  return; // Stop running.
}

ForegroundColor = (ConsoleColor)Enum.Parse( // Enum.Parse sucht den passenden Wert in der ConsoleColor-Enumeration basierend auf dem übergebenen String-Argument.
  enumType: typeof(ConsoleColor),
  value: args[0], ignoreCase: true);

BackgroundColor = (ConsoleColor)Enum.Parse(
  enumType: typeof(ConsoleColor),
  value: args[1], ignoreCase: true);

try
{
  CursorSize = int.Parse(args[2]); // Parse converts the string argument to an integer.
}
catch (PlatformNotSupportedException)
{
  WriteLine("The current platform does not support changing the size of the cursor.");
}
