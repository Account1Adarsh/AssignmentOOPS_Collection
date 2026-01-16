using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class Trainee:Employee
    {
        #region property
        private int noOfDays;

		public int NoOfDays
		{
			get { return noOfDays; }
			set {
                noOfDays = value; 
            }
		}
		private double ratePerDay;

		public double RatePerDay
		{
			get { return ratePerDay; }
			set { ratePerDay = value; }
		}
        #endregion


        #region Constructor
        public Trainee():base()
        {
            NoOfDays = 30;
			RatePerDay = 500;
        }
        public Trainee(string name,string address,int days,int rate):base(name,address)
        {
            NoOfDays= days;	
			RatePerDay = rate;		
        }

        #endregion


        #region Methods Overridden

        public sealed override double CalculateSalary()
        {
            return NoOfDays * RatePerDay;
        }

        public override string ToString()
        {
            return base.ToString() + $" This is an intern and salary is :{CalculateSalary()} ";
            
        }
        #endregion


    }
}
