using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets.BusinessLogicLayer.Extensions
{
    internal static class IntegerExtensions
    {
        /// <summary>
        /// Converts a miles value to kilometers
        /// </summary>
        /// <param name="miles"></param>
        /// <returns></returns>
        internal static double MilesToKilometers(this double miles) => 1.609344d*miles;

        /// <summary>
        /// Converts a kilometers value to miles
        /// </summary>
        /// <param name="kilometers"></param>
        /// <returns></returns>
        internal static double KilometersToMiles(this double kilometers) => 0.6213712d*kilometers;

        /// <summary>
        /// Converts a miles value to bananas
        /// </summary>
        /// <param name="miles"></param>
        /// <see cref="http://bananaforscale.info/#!/convert/length/1/miles/bananas"/>
        /// <returns></returns>
        internal static double MilesToBananas(this double miles) => 9041.258*miles;

        /// <summary>
        /// Converts a kilometers value to bananas
        /// </summary>
        /// <param name="kilometers"></param>
        /// <see cref="http://bananaforscale.info/#!/convert/length/1/kilometers/bananas"/>
        /// <returns></returns>
        internal static double KilometersToBananas(this double kilometers) => 5617.978*kilometers;
    }
}
