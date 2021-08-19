using System;
using System.Collections.Generic;
using System.Text;

namespace SF_17._6
{
    interface IInterestCounting
    {
        double CountRegularAccountInterest(Account account);
        double CountSalaryAccountInterest(Account account);
    }
}
