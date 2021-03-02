using System;
using System.Collections.Generic;
using System.Text;

namespace ProductService.DataLayer
{
    class DbConnectivitySettings
    {

        public string ProductCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
