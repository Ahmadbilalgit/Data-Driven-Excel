using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Registeration_Excel_Data
{
    class Registration_Obj
    {

        public Registration_Obj()

        {

            PageFactory.InitElements(Driver.driver, this);

        }


        [FindsBy(How = How.ClassName, Using = "ico-register")]
        public IWebElement Registrationlink { get; set; }

        [FindsBy(How = How.Id, Using = "gender-male")]
        public IWebElement Gender { get; set; }

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement First { get; set; }

        [FindsBy(How = How.Id, Using = "LastName")]
        public IWebElement Last { get; set; }

        [FindsBy(How = How.Name, Using = "DateOfBirthDay")]
        public IWebElement Day;
        //  public SelectElement select { get; set; }
        // public  SelectElement select = new SelectElement(Day);

        [FindsBy(How = How.Name, Using = "DateOfBirthMonth")]
        public IWebElement Month;

        [FindsBy(How = How.Name, Using = "DateOfBirthYear")]
        public IWebElement Year;


        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement Emailid { get; set; }


        [FindsBy(How = How.Id, Using = "Company")]
        public IWebElement Company { get; set; }



        [FindsBy(How = How.Id, Using = "Newsletter")]
        public IWebElement Newsletter { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "ConfirmPassword")]
        public IWebElement Confirmpassword { get; set; }



        [FindsBy(How = How.Id, Using = "register-button")]
        public IWebElement Registerbutton { get; set; }

        

       [FindsBy(How = How.ClassName, Using = "ico-logout")]
        public IWebElement Logout { get; set; }


    }
}
