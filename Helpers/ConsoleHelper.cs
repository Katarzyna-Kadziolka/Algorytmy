﻿namespace Helpers;

public static class ConsoleHelper {
    public static void RedirectInputToFile() {
        FileInfo sourceFile = new FileInfo("Data.txt");
        TextReader sourceFileReader = new StreamReader(sourceFile.FullName);
        Console.SetIn(sourceFileReader);
    }
}