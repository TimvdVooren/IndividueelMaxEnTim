using Newtonsoft.Json;
using Client.Bicycle;

namespace Client.ServerConnection
{
    class ServerCommands
    {
        public static int BikeID = 0;

        public static string SendBikeData(string time, string rpm, string distance, string energy, string power)
        {
            return JsonConvert.SerializeObject(new
            {
                command = "bike_data",
                data = new
                {
                    time = time,
                    rpm = rpm,
                    distance = distance,
                    energy = energy,
                    power = power
                }
            });
        }
        public static string SendBikeData(BikeDataPackage package)
        {
            return JsonConvert.SerializeObject(new
            {
                command = "bike_data",
                data = new
                {
                    time = package.time,
                    rpm = package.rpm,
                    distance = package.distance,
                    energy = package.energy,
                    power = package.power
                }
            });
        }

        public static string ClientType()
        {
            return JsonConvert.SerializeObject(new
            {
                data = new
                {
                    type = "patient"
                }
            });
        }
    }
}
