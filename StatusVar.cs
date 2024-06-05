using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgres_Viewer
{
    public static class StatusVar
    {
        public static string SqlBuffer = "";
        public static bool connected = false;
        public static int tabResultIndex = 0;
        public static int tabTablesIndex = 1;
        public static int tabProblemsIndex = 2;
        public static int tabCallStackIndex = 3;
    }
}
