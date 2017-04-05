using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCAVelModels
{
    public class HACVelServer
    {
        public string ServerName { get; set; }
        public string ConnectString { get; set; }

        public List<HACVelServer> GetServers()
        {
            List<HACVelServer> listOfServers = new List<HACVelServer>()
                {
                    new HACVelServer
                    {
                        ServerName = "Test",
                        ConnectString = "Test Connect String"
                    },
                    new HACVelServer
                    {
                        ServerName = "Dev",
                        ConnectString = "Dev Connect String"
                    },
                    new HACVelServer
                    {
                        ServerName = "Production",
                        ConnectString = "Production Connect"
                    }
                };

            return listOfServers;
        }

    }

}
