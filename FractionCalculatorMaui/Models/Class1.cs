using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculatorMaui.Models
{
    public class Name : IName
    {
        private string m_firstName;
        private string m_lastName;

        public Name()
        {
            // Constructor
        }

        public string FirstName
        {
            get { return m_firstName; }
            set { m_firstName = value; }
        }

        public string LastName
        {
            get { return m_lastName; }
            set { m_lastName = value; }
        }

        public void SetFullName(string first, string last)
        {
            m_firstName = first;
            m_lastName = last;
        }
    }

}
