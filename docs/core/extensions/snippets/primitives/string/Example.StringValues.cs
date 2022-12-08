﻿using Microsoft.Extensions.Primitives;

public partial class Example
{
    public void ShowStringValues()
    {
        // <StringValues>
        StringValues values =
            new(s_nineHundredAutoGeneratedParagraphsOfLoremIpsum.Split(
                new[] { '\n' }));

        Console.WriteLine($"Count = {values.Count:#,#}");

        foreach (string? value in values)
        {
            // Interact with the value
        }
        // Outputs:
        //     Count = 1,799
        // </StringValues>
    }
}
