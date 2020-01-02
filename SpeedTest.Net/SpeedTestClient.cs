﻿using System.Threading.Tasks;
using SpeedTest.Net.Models;

namespace SpeedTest.Net
{
    public static class SpeedTestClient
    {
        private static SpeedTestHttpClient Client => new SpeedTestHttpClient();

        /// <summary>
        /// Calculates download speed using the provided server
        /// </summary>
        /// <param name="server">The server object used for downloading files</param>
        /// <returns>Download speed in KB/s</returns>
        public static async Task<DownloadSpeed> GetDownloadSpeed(Server server = null) => await Client.GetDownloadSpeed(server);

        /// <summary>
        /// Finds the closest server to the provided co-ordinates
        /// </summary>
        /// <param name="latitude">Latitude of the location</param>
        /// <param name="longitude">Longitude of the location</param>
        /// <returns>Server object close to the provided latitude and longitude</returns>
        public static async Task<Server> GetServer(double latitude, double longitude) => await Client.GetServer(latitude, longitude);

        /// <summary>
        /// Finds the best server based on the callee location
        /// </summary>
        /// <returns>Server object close to the callee location</returns>
        public static async Task<Server> GetServer() => await Client.GetServer();
    }
}