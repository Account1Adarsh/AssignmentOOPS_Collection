using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class ConfirmEmployee : Employee
    {
        #region Property
        private double basic;

        public double Basic
        {
            get { return basic; }
            set { 
                if (value < 5000)
                {
                    throw new MinimumPayException("Maintain a minimum basic pay of 5000 !! It not vaild enrty");
                }
                basic = value;
            }
        }

        private string designation;

        public string Desgination
        {
            get { return designation; }
            set { designation = value; }
        }
        #endregion


        #region Constructor
        public ConfirmEmployee():base()
        {
            Basic = 90000;
            designation = "SDE1";
        }

        public ConfirmEmployee(string name,string address, double basicpay,string desg):base(name,address)
        {
            Basic = basicpay;
            designation= desg;
            //if (Basic < 5000)
            //{
            //    throw new MinimumPayException("Maintain a minimum basic pay of 5000 !! It not vaild enrty");
            //}
        }
        #endregion


        #region Methods Overriden

        public sealed override double CalculateSalary()
        {
            double hra, pf, conv;

            if (Basic >= 30000)
            {
                hra = (30 * Basic) / 100;
                conv= (30 * Basic) / 100;
                pf = (10 * Basic) / 100;
            }
            else if (Basic >= 20000)
            {
                hra = (20 * Basic) / 100;
                conv = (20 * Basic) / 100;
                pf = (10 * Basic) / 100;
            }
            else
            {
                hra = (10 * Basic) / 100;
                conv = (10 * Basic) / 100;
                pf = (10 * Basic) / 100;
            }
            double NetSalary = hra + conv - pf;
            return NetSalary;
        }
        public override string ToString()
        {
            return base.ToString()+$"This is an permanent Employee and its salary is:{CalculateSalary()}";
        }
        #endregion

    }
}
