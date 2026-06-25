namespace UtilityLibraries;

public static class StringLibrary
{
    // Make sure "(string str)" or "(String? str)" is right here!
    public static bool StartsWithUpper(this string str)
    {
        if (string.IsNullOrWhiteSpace(str)) // Line 7?
            return false;

        char ch = str[0];                   // Line 10?
        return char.IsUpper(ch);
    }
}