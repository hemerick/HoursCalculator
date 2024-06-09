using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatriceHeures
{
    public class ErrorManager
    {
        public ErrorManager(string functionName, string errorMessage, bool detailedError)
        {
            FunctionName = functionName;
            ErrorMessage = errorMessage;
            DetailedError = detailedError;
        }

        string FunctionName { get; set; }
        string ErrorMessage { get; set; }

        bool DetailedError { get; set; }

        public string PrintError()
        {
            string baseTXT = "ERROR : ";
            string errorTXT;

            if(FunctionName == null || ErrorMessage==null) 
            {
                FunctionName = "PrintError";
                ErrorMessage = "FunctionName or ErrorMessage cannot be null!";
            }

            if (FunctionName == "" || ErrorMessage == "")
            {
                return "";
            }

            if (DetailedError)
            {
                #pragma warning disable CS0162 // Code inaccessible détecté
                errorTXT = baseTXT + " in " + FunctionName + " function\n--> " + ErrorMessage;
                #pragma warning restore CS0162 // Code inaccessible détecté
            }
            else
            {
                #pragma warning disable CS0162 // Code inaccessible détecté
                errorTXT = baseTXT + ErrorMessage;
                #pragma warning restore CS0162 // Code inaccessible détecté
            }
            ResetError();

            return errorTXT;
        }

        public void SetError(string functionName, string error) 
        {
            FunctionName = functionName;
            ErrorMessage = error;
        }

        public string ResetError() 
        {
            FunctionName= "";
            ErrorMessage= "";

            return "";
        }
    }
}
