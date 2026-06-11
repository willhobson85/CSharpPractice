public static class LineUp
{
    public static string Format(string name, int number)
    {
        string suffix;
        string numberToString = number.ToString();
        char lastNumber = numberToString.Last();
        if (lastNumber == '1' && (numberToString != "11")) {
            suffix = "st";
        } else if (lastNumber == '2' && (numberToString != "12")  && (numberToString != "112")) {
            suffix = "nd";
        } else if (lastNumber == '3' && (numberToString != "13")) {
            suffix = "rd";
        } else {
            suffix = "th";
        }
        return $"{name}, you are the {number}{suffix} customer we serve today. Thank you!";
        throw new NotImplementedException("You need to implement this method.");
    }
}
