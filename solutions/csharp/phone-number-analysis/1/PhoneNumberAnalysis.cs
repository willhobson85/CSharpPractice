public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string areaCode = phoneNumber.Substring(0, 3);
        string firstDigits = phoneNumber.Substring(4, 3);
        string lastDigits = phoneNumber.Substring(8, 4);
        bool IsNewYork = (areaCode == "212");
        bool IsFake = (firstDigits == "555");
        string LocalNumber = lastDigits;

        return (IsNewYork, IsFake, LocalNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
