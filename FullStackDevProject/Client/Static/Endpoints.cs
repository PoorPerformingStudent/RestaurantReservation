using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackDevProject.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string RestaurantsEndpoint = $"{Prefix}/restaurants";
        public static readonly string MenusEndpoint = $"{Prefix}/menus";
        public static readonly string TablesEndpoint = $"{Prefix}/tables";
        public static readonly string SeatingsEndpoint = $"{Prefix}/seatings";
        public static readonly string CustomersEndpoint = $"{Prefix}/customers";
    }
}
