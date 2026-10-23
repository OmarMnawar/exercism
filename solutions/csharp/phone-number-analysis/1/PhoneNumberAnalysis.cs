public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] splitedPhoneNumber = phoneNumber.Split('-', StringSplitOptions.TrimEntries);

        return (splitedPhoneNumber[0] == "212", splitedPhoneNumber[1] == "555", splitedPhoneNumber[2]);
    }
    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => 
        phoneNumberInfo.IsFake;    
}
