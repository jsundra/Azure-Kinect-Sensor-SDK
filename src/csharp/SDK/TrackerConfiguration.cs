using System.Runtime.InteropServices;
using Microsoft.Azure.Kinect.Sensor.Native;

namespace Microsoft.Azure.Kinect.BodyTracking
{

    [NativeReference]
    public enum SensorOrientation
    {
        K4ABT_SENSOR_ORIENTATION_DEFAULT = 0,        /** < Mount the sensor at its default orientation */
        K4ABT_SENSOR_ORIENTATION_CLOCKWISE90,        /** < Clockwisely rotate the sensor 90 degree */
        K4ABT_SENSOR_ORIENTATION_COUNTERCLOCKWISE90, /** < Counter-clockwisely rotate the sensor 90 degrees */
        K4ABT_SENSOR_ORIENTATION_FLIP180,            /** < Mount the sensor upside-down */
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TrackerConfiguration
    {
        public SensorOrientation SensorOrientation;
    }
}