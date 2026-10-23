static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 1000 && balance >= 0)
            return 0.5f;
        else if (balance >= 1000 && balance < 5000)
            return 1.621f;
        else if (balance >= 5000)
            return 2.475f;
        else if (balance < 0)
            return 3.213f;

        return 0f;
    }

    public static decimal Interest(decimal balance) =>
        (decimal)(balance * (decimal)InterestRate(balance)) / 100;

    public static decimal AnnualBalanceUpdate(decimal balance) =>
        balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int year = 0;


        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            year++;
        }

        return year;
    }
}
