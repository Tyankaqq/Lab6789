using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_11;
using System;
using System.Collections.Generic;
using System.IO;

[Serializable]
public class Client
{
    public string LastName { get; set; }
    public decimal BasicPackageCost { get; set; }
    public decimal SocialPackageCost { get; set; }
    public int MonthsPaid { get; set; }

    public Client(string lastName, decimal basicPackageCost, decimal socialPackageCost, int monthsPaid)
    {
        LastName = lastName;
        BasicPackageCost = basicPackageCost;
        SocialPackageCost = socialPackageCost;
        MonthsPaid = monthsPaid;
    }
}
