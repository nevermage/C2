using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab_C_sharp
{
    class zavod: IComparable<zavod>
    {
        public static List<zavod> zavodi = new List<zavod>();
        public string nameZavod { get; set; }
        public int numOfWorkshops { get; set; }
        public int numOfMasters { get; set; }
        public int numOfemployees { get; set; }
        public double salaryEmpl { get; set; }
        public double salaryMaster { get; set; }
        public double incomeMaster { get; set; }
        public double incomeEmpl{ get; set; }

        public zavod(string nameZavod, int numOfWorkshop,int numOfMasters, int numOfemployees, double salaryEmpl, double salaryMaster, double incomeMaster, double incomeEmpl)
        {
            this.nameZavod = nameZavod;
            this.numOfWorkshops = numOfWorkshop;
            this.numOfMasters = numOfMasters;
            this.numOfemployees = numOfemployees;
            this.salaryEmpl = salaryEmpl;
            this.salaryMaster = salaryMaster;
            this.incomeMaster = incomeMaster;
            this.incomeEmpl = incomeEmpl;

        }
        public zavod(zavod obj)
        {
            nameZavod = obj.nameZavod;
            numOfWorkshops = obj.numOfWorkshops;
            numOfMasters = obj.numOfMasters;
            numOfemployees = obj.numOfemployees;
            salaryEmpl = obj.salaryEmpl;
            salaryMaster = obj.salaryMaster;
            incomeMaster = obj.incomeMaster;
            incomeEmpl = obj.incomeEmpl;
        }

        public void HireEmpl()
        {
            numOfemployees++;
        }
        public void HireMaster()
        {
            numOfMasters++;
        }
        public void FireEmpl()
        {
            if (numOfemployees>0)
                numOfemployees--;
        }
        public void FireMaster()
        {
            if (numOfMasters > 0)
                numOfMasters--;
        }

        public static zavod operator +(zavod zavod1,zavod zavod2)
        {
            return new zavod(zavod1.nameZavod+" X "+zavod2.nameZavod,zavod1.numOfWorkshops+zavod2.numOfWorkshops,zavod1.numOfMasters+zavod2.numOfMasters,zavod1.numOfemployees+zavod2.numOfemployees,zavod1.salaryEmpl+zavod2.salaryEmpl,zavod1.salaryMaster+zavod2.salaryMaster,zavod1.incomeMaster+zavod2.incomeMaster,zavod1.incomeEmpl+zavod2.incomeEmpl);
        }

        public int CompareTo(zavod obj)
        {
            if (this.incomeEmpl > obj.incomeEmpl)
                return 1;
            if (this.incomeEmpl < obj.incomeEmpl)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return String.Format("Назва заводу:{0}   Прибуток за місяць з робітника: {1}   Прибуток за місяць з майстра: {2}",
                this.nameZavod, this.incomeEmpl,this.incomeMaster);
        }

        









    }
    public static class income
    {
        public static double Money(this double m, double incomeEml,double numEml)
        {
            double ez = (m /numEml)*incomeEml;

            return ez;
        }

    }
}
