using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentTracker.util
{
    public class CAC_PDF417
    {
        public CAC_PDF417()
        {
            //Default Constructor
        }

        public CAC_PDF417(string rawPDF417String)
        {
            //Constructor for raw PDF417 string to be formatted
            getFirstName(rawPDF417String);
            getLastName(rawPDF417String);
            getMiddleInitial(rawPDF417String);
            getRank(rawPDF417String);
            getEDI(rawPDF417String);
            getBranchCode(rawPDF417String);
        }

        private void getFirstName(string rawDataString)
        {
            _firstName = rawDataString.Substring(15, 20).Trim();
        }
        private void getLastName(string rawDataString)
        {
            _lastName = rawDataString.Substring(35, 26).Trim();
        }

        private void getMiddleInitial(string rawDataString)
        {
            //code to pull middle initial if available
            if (rawDataString.StartsWith("N") && rawDataString.Length == 89)
            {
                _middleInitial = rawDataString.Substring(88,1).Trim();
            }
        }

        private void getRank(string rawDataString)
        {
            _rank = rawDataString.Substring(69, 6).Trim();
        }
        private void getEDI(string rawDataString)
        {
            //Pulls encoded EDI (Base32) and converts it to Decimal EDI
            _edi = Base32.base32ToLongInt(rawDataString.Substring(8, 7)).ToString();
        }
        private void getBranchCode(string rawDataString)
        {
            _branchCode = rawDataString.Substring(66, 1);
        }
        private string _firstName;
        private string _lastName;
        private string _middleInitial;
        private string _rank;
        private string _edi;
        private string _branchCode;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string MiddleInitial
        {
            get { return _middleInitial; }
            set { _middleInitial = value; }
        }
        public string Rank
        {
            get { return _rank; }
            set { _rank = value; }
        }
        public string EDI
        {
            get { return _edi; }
            set { _edi = value; }
        }
        public string BranchCode
        {
            get { return _branchCode; }
            set { _branchCode = value; }
        }
        
    }
}
