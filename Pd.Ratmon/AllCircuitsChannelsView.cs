using IO.Swagger.Model;
using System;
using System.Collections.Generic;
using System.Text;
  
namespace Pd.Ratmon
{
    public class AllCircuitsChannelsView : AllCircuitsChannels 
    {
        public string StateView
        {
            //Ratmon stany
            //Operational = 0, (ok)
            //Accepted = 1, (stan zaakceptowany przez użytkownika)
            //Attention = 16 (uwaga)
            //Alert = 4, (ostrzeżenie)
            //Alarm = 2, (alarm)
            //Undefined = 8, (nieznany)
            get
            {
                string s = "";               
                if (this.State == 0) { return "Operational"; };
                if (this.State == StateEnum.NUMBER_1) { return  "Alarm";};
                if (this.State == StateEnum.NUMBER_2) { return "Accepted"; };
                if (this.State == StateEnum.NUMBER_4) { return "Alert"; };
                if (this.State == StateEnum.NUMBER_8) { return "Undefined"; };
                //
                if (s == "") { return "Undefined"; };
                return s;
            }
            set { }
        }
    }
}
