using System;
namespace MyApp
{
    public class PropertyDemo
    {
        //Private Data Members
        private int _EmpId;
        private string _EmpName="";

        //Public Properties
        public int EmpId
        {
            //The Set Accessor is used to set the _EmpId private variable value
            set
            {
                _EmpId = value;
            }
            //The Get Accessor is used to return the _EmpId private variable value
            get
            {
                return _EmpId;
            }
        }
        public string EmpName
        {
            //The Set Accessor is used to set the _EmpName private variable value
            set
            {
                _EmpName = value;
            }
            //The Get Accessor is used to return the _EmpName private variable value
            get
            {
                return _EmpName;
            }
        }
    }
    
} 