using System;
using System.Collections.Generic;
using System.Text;

namespace SF_17._6
{
    class Calculator : IInterestCounting
    {

        // Метод для расчета процентной ставки
        public double CalculateInterest(Account account)
        {
            double interest = 0;

            if (account.Type == "обычный")
                interest = CountRegularAccountInterest(account);

            if (account.Type == "зарплатный")
                interest = CountSalaryAccountInterest(account);

            return interest;
        }


        public double CountRegularAccountInterest(Account account)
        {
            account.Interest = account.Balance * 0.4;

              //Изменил условие расчета процентной ставки
              //Вероятно снижение процента на 0,2 должно происходить при балансе в диапазоне от 1 000 до 50 000 
            if (account.Balance > 1000 && account.Balance < 50000)
                account.Interest -= account.Balance * 0.2;

              //снижение на 0,4 при балансе более 50 000
            if (account.Balance > 50000)
                account.Interest -= account.Balance * 0.4;

            return account.Interest;
        }


        public double CountSalaryAccountInterest(Account account)
        {
            return account.Interest = account.Balance * 0.5;
        }
    }
}
