using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace User_Registeration_Excel_Data
{
    public static class Registration
    {
        public static void Reg()
        {
            Registration_Obj Regobj = new Registration_Obj();
          
            //Explicitwait Expobj = new Explicitwait();
            // ExcelUtil ExcelObj = new ExcelUtil();


            for (int row = 1; row <= 2; row++) // The for-loop is hard coded depend on the Excel row

                //for (int rowd = 1; rowd < ExcelUtil.PopulateInCollection.dtt
                {
              
                Regobj.Registrationlink.Click();

                
                Thread.Sleep(2000);

                Regobj.First.SendKeys(ExcelUtil.ReadData(row, "Firstname"));
                Regobj.Last.SendKeys(ExcelUtil.ReadData(row, "Lastname"));
                Thread.Sleep(3000);

                SelectElement select = new SelectElement(Regobj.Day);// Select element is used to select data from drop list
                select.SelectByIndex(2);

                SelectElement selectmonth = new SelectElement(Regobj.Month);// Select element is used to select data from drop list
                selectmonth.SelectByIndex(5);

                SelectElement selectyear = new SelectElement(Regobj.Year);// Select element is used to select data from drop list
                selectyear.SelectByValue("2001");


                Regobj.Emailid.SendKeys(ExcelUtil.ReadData(row, "Email"));

                Regobj.Newsletter.Click();

                Regobj.Password.SendKeys("hello123");



                Regobj.Confirmpassword.Click();
                Regobj.Confirmpassword.SendKeys("hello123");

                Regobj.Registerbutton.Click();
                Thread.Sleep(3000);

                Assert.IsTrue(Driver.driver.PageSource.Contains("Your registration completed"));


                Regobj.Logout.Click();
                Thread.Sleep(3000);
            }
        }

    }
}
