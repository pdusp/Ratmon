using IO.Swagger.Model;
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace Pd.Ratmon
{
    public partial class SelectedChannelView : SelectedChannel
    {

        public SelectedChannelView(SelectedChannel ch)
        {
            this.ChannelId = ch.ChannelId;
            this.Resistance = ch.Resistance;
            this.ResThresholds = ch.ResThresholds;
        }

        /*  jest niezgodność z tym co podali a co zwraca RatMon
            Ratmon stany
            Operational = 0, (ok)
            Accepted = 1, (stan zaakceptowany przez użytkownika)
            Attention = 16 (uwaga)
            Alert = 4, (ostrzeżenie)
            Alarm = 2, (alarm)          
            Undefined = 8, (nieznany)
         */
        enum StateView
        { 
            Operational,
            Alarm,
            Accepted,
            Alert 
        }
               

        [DataMember(Name = "R1_Stan")]
        public string R1_Stan
        {
            get
            {
                try
                {
                    if (this.Resistance.R1State == 0) return StateView.Operational.ToString();
                    if (this.Resistance.R1State == SelectedChannelResistance.R1StateEnum.NUMBER_1) return StateView.Alarm.ToString();
                    if (this.Resistance.R1State == SelectedChannelResistance.R1StateEnum.NUMBER_2) return StateView.Accepted.ToString();
                    if (this.Resistance.R1State == SelectedChannelResistance.R1StateEnum.NUMBER_4) return StateView.Alert.ToString();
                    return "Undefined";
                }
                catch
                {
                    return "Undefined";
                }
                
            }
        }

        [DataMember(Name = "R2_Stan")]
        public string R2_Stan
        {
            get
            {
                try
                {
                    if (this.Resistance.R2State == 0) return StateView.Operational.ToString();
                    if (this.Resistance.R2State == SelectedChannelResistance.R2StateEnum.NUMBER_1) return StateView.Alarm.ToString();
                    if (this.Resistance.R2State == SelectedChannelResistance.R2StateEnum.NUMBER_2) return StateView.Accepted.ToString();
                    if (this.Resistance.R2State == SelectedChannelResistance.R2StateEnum.NUMBER_4) return StateView.Alert.ToString();
                    return "Undefined";
                }
                catch
                {
                    return "Undefined";
                }
            }
        }
        [DataMember(Name = "RLoop_Stan")]
        public string RLoop_Stan
        {
            get
            {
                try
                {
                    if (this.Resistance.RLoopState == 0) return StateView.Operational.ToString();
                    if (this.Resistance.RLoopState == SelectedChannelResistance.RLoopStateEnum.NUMBER_1) return StateView.Alarm.ToString();
                    if (this.Resistance.RLoopState == SelectedChannelResistance.RLoopStateEnum.NUMBER_2) return StateView.Accepted.ToString();
                    if (this.Resistance.RLoopState == SelectedChannelResistance.RLoopStateEnum.NUMBER_4) return StateView.Alert.ToString();
                    return "Undefined";
                }
                catch
                {
                    return "Undefined";
                }
            }
        }

        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }


    }
}
