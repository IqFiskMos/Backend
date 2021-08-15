using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsAndInputsAssignment.Models
{
    public class FeverCheckModel
    {
        public static string FeverCheckEvaluation(double tempurature, string selctedTempType)
        {
            string healthReport = "";

            if (selctedTempType == "celsius")
            {
                if (tempurature > 37.5 && tempurature <=40) healthReport = "You have fever. Please take some rest and medicine.";
                else if (tempurature < 35) healthReport = "You have Hypothermia.";
                else if (tempurature > 40) healthReport = "You have Hyperpyrexia. Please consult a doctor.";
                else healthReport = "Nothing to worry. Your temperature is normal.";
            }
            
            if (selctedTempType == "fahrenheit")
            {
                if (tempurature > 99.5 && tempurature <= 104) healthReport = "You have fever. Please take some rest and medicine.";
                else if (tempurature < 95) healthReport = "You have Hypothermia.";
                else if (tempurature > 104) healthReport = "You have Hyperpyrexia. Please consult a doctor.";
                else healthReport = "Nothing to worry. Your temperature is normal.";
            }

            return healthReport;
        }
    }
}
