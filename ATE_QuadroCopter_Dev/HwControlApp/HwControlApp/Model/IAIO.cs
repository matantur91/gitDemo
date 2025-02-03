using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwControlApp.Model
{
    public interface IAIO
    {
        OperationResult GetVoltAvg(DriversWrapper.AIO.AIChannels channel);
        //
        // Summary:
        //     Computes the count of the average voltage above the parameter.
        //
        // Parameters:
        //   source:
        //     The avg Voltage above this value will count.
        //
        // Returns:
        //     The number of the avg voltage above the parameter value.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        int GetCountOfVoltagesAbove(double voltageLimit);

        OperationResult GetMaxVoltageAvg(DriversWrapper.AIO.AIChannels channel);
    }
}
