using System;

namespace Blazor_app.Data
{
    public class Customer_Data
    {
        private string Grade = string.Empty;
        private string Cclass = string.Empty;
        private string No = string.Empty;
        private string Name = string.Empty;
        private string Score = string.Empty;


        public string grade
        {
            get { return this.Grade; }
            set
            {
                if (value != this.Grade)
                {
                    this.Grade = value;
                }
            }
        }
        public string cclass
        {
            get { return this.Cclass; }
            set
            {
                if (value != this.Cclass)
                {
                    this.Cclass = value;
                }
            }
        }
        public string no
        {
            get { return this.No; }
            set
            {
                if (value != this.No)
                {
                    this.No = value;
                }
            }
        }
        public string name
        {
            get { return this.Name; }
            set
            {
                if (value != this.Name)
                {
                    this.Name = value;
                }
            }
        }

        public string score
        {
            get { return this.Score; }
            set
            {
                if (value != this.Score)
                {
                    this.Score = value;
                }
            }
        }
    }
}
