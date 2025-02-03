using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HwControlApp.Model.Constants;

namespace HwControlApp.Model
{
    static class Devices //initialization the hardware of the drone
    {
        //public properties
        public static PowerSupply PS;
        public static AIO AIO;


        //methods
        public static void init(string drvIniPath,string psName,string aioName)
        {
            PS = new PowerSupply(drvIniPath,psName);
            AIO = new AIO(drvIniPath,aioName);       
    
            
        }


    }
}
