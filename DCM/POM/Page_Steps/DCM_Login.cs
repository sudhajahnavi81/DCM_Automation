using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DCM.POM.DCM_Objects;
using DCM.data;
using OtpNet;
using System.Threading;

namespace DCM.POM.Page_Steps
{
    public  class DCM_Login : MethodsAndActions
    {
        
        public static void LoginDCM()
        {
            Type(Exceldata.un1, Page_Objects.signIn);
            Type(Exceldata.psw, Page_Objects.oktapswd);
            click(Page_Objects.oktasubmit);
            Thread.Sleep(1000);

        }

        public static void twofa()
        {
            Thread.Sleep(4000);
            var otpKeyBytes = Base32Encoding.ToBytes(Exceldata.otpKeyStr);
            var totp = new Totp(otpKeyBytes);
            var twoFactorCode = totp.ComputeTotp();
            Type(twoFactorCode,Page_Objects.oktatwofa);
            click(Page_Objects.oktaverify);
            Thread.Sleep(1000);


        }

        public static void viewLoginDCM()
        {
            Type(Exceldata.Viewerrole, Page_Objects.signIn);
            Type(Exceldata.Viewrolepsw, Page_Objects.oktapswd);
            click(Page_Objects.oktasubmit);
            Thread.Sleep(1000);

        }

        public static void viewtwofa()
        {
            Thread.Sleep(1000);
            var otpKeyBytes = Base32Encoding.ToBytes(Exceldata.otpKeyStrview);
            var totp = new Totp(otpKeyBytes);
            var twoFactorCode = totp.ComputeTotp();
            Type(twoFactorCode, Page_Objects.oktatwofa);
            click(Page_Objects.oktaverify);
            Thread.Sleep(1000);


        }




        public static void DCMoktalogo()
        {
            Thread.Sleep(10000);
            click(Page_Objects.DCMoktalogo);
            Thread.Sleep(30000);
            movepointer();
            
        }

        public static void DCMlogout()
        {
            Thread.Sleep(25000);
            click(Page_Objects.Logout);
            Thread.Sleep(1000);
            click(Page_Objects.Signout);
            Thread.Sleep(5000);
            click(Page_Objects.OKbtn);
            Thread.Sleep(15000);
            click(Page_Objects.Oktalogout);
            click(Page_Objects.OktaSignout);

        }



    }
}
