using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BMI_thing
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        // SOAP
        public string healthIndicatorSOAP(int weight, int height)
        {
            double bmi = BMI(weight, height);

            string result = "You are obese";

            if (bmi < 18)
            {
                result = "You are underweight";
            }
            else if (25 > bmi && bmi >= 18)
            {
                result = "Your weight is normal";
            }
            else if (30 > bmi && bmi >= 25)
            {
                result = "You are pre-obease";
            }

            return "<?xml version=\"1.0\" encoding=\"UTF-8\"?><soap><result>" + result + "</result></soap>";
        }


        // Restful (JSON)
        public string healthIndicatorREST(int weight, int height)
        {
            double bmi = BMI(weight, height);

            string result = "You are obese";

            if (bmi < 18)
            {
                result = "You are underweight";
            }
            else if (25 > bmi && bmi >= 18)
            {
                result = "Your weight is normal";
            }
            else if (30 > bmi && bmi >= 25)
            {
                result = "You are pre-obease";
            }

            return "{\"result\":\"" + result + "\"}";
        }

        public double BMI(int weight, int height)
        {
            return ((weight / height)) * (height) * 703;
        }

    }
}
