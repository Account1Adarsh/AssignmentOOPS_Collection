namespace HRLib
{
    public abstract class Employee
    {
		private static int count;

        #region Property
        private int empNo;

		public int EmpNo
		{
			get { return empNo; }
			protected set { empNo = value; }
		}


		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private string address;

		public string Address
		{
			get { return address; }
			set { address = value; }
		}



        #endregion

        #region Constructors
        public Employee()
        {
			count++;
			EmpNo = count;
			this.Name = "Sample Kumar";
			this.Address = "Sample house address";
        }
        public Employee(string nameis,string isaddress) :this()
        {
			this.Name = nameis;
			this.Address = isaddress;

        }
		static Employee()
		{
			count = 1000;
		}

        #endregion

        #region Methods Overridden
        public override string ToString()
        {
			return $"Emplyee Id : {EmpNo}, Employee Name is: {Name} , Emplyee address is:{Address} ";
        }
        #endregion
        public abstract double CalculateSalary();



    }
}
