using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HwControlApp.Model
{
    interface IPowerSupply
    {
        OperationResult GetActualVoltage();
        OperationResult GetActualCurrent();
        OperationResult GetVoltageProgrammed();
        OperationResult SetPowerONOFF(PowerStatus state);
        OperationResult SetVoltage(double newVoltage);
        OperationResult SetCurrentLimit(double newCurrentLimit);
        OperationResult GetPowerStatus();
        OperationResult GetCurrentLimit();

    }
}
