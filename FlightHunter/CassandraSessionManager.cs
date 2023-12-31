﻿using Cassandra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CassandraDataLayer
{
    public static class CassandraSessionManager
    {
        public static ISession session;
        // za povezivanje sa bazom
        public static ISession GetSession()
        {
            if(session == null)
            {
                Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
                session = cluster.Connect("FlightHunter");
            }

            return session;
        }
    }
}