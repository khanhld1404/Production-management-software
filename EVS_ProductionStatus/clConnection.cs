using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVS_ProductionStatus
{
    public static class clConnection
    {
        public static string connectEntity = "metadata=res://*/db.csdl|res://*/db.ssdl|res://*/db.msl;provider=System.Data.SqlClient;provider connection string='data source=10.239.1.162;initial catalog=EVS_ProductionStatus;user id=thuongcv; password=thuongcv; MultipleActiveResultSets=True;App=EntityFramework'";
        public static string connectString = @"Data Source=10.239.1.54;Initial Catalog=Export_data_QAD;Persist Security Info=True;User ID=khanh_ld;Password=250711;Encrypt=False;";
        public static string connectString2 = @"metadata = res://*/Data.Model1.csdl|res://*/Data.Model1.ssdl|res://*/Data.Model1.msl;provider=System.Data.SqlClient;provider connection string=""data source=10.239.1.54;initial catalog=Manage_evs;persist security info=False;user id=khanh_ld;password=250711;Encrypt=True;TrustServerCertificate=True;MultipleActiveResultSets=True;App=EntityFramework""";
        public static string connectString3 = @"Data Source=10.239.1.54;Initial Catalog=Manage_evs;Persist Security Info=True;User ID=khanh_ld;Password=250711;Encrypt=False;";
    }
}