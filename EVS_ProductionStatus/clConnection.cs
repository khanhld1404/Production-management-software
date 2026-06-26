using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVS_ProductionStatus
{
    public static class clConnection
    {
        // Tài khoản của job là thuongcv mk thuongcv con 162
        public static string connectEntity = @"metadata=res://*/Data_EVS.db.csdl|res://*/Data_EVS.db.ssdl|res://*/Data_EVS.db.msl;provider=System.Data.SqlClient;provider connection string=""data source=10.239.1.162;initial catalog=EVS_ProductionStatus;persist security info=True;user id=khanh_ld;password=250711;multipleactiveresultsets=True;encrypt=True;trustservercertificate=True;application name=EntityFramework""";
        public static string connectEntity2 = @"metadata=res://*/Data_EVS.db2.csdl|res://*/Data_EVS.db2.ssdl|res://*/Data_EVS.db2.msl;provider=System.Data.SqlClient;provider connection string=""data source=10.239.1.54;initial catalog=Manage_evs;persist security info=True;user id=khanh_ld;password=250711;multipleactiveresultsets=True;encrypt=True;trustservercertificate=True;application name=EntityFramework""";
        public static string connectString = @"Data Source=10.239.1.162;Initial Catalog=EVS_ProductionStatus;Persist Security Info=True;User ID=khanh_ld;Password=250711;Encrypt=False;";
        public static string connectString3 = @"Data Source=10.239.1.54;Initial Catalog=Manage_evs;Persist Security Info=True;User ID=khanh_ld;Password=250711;Encrypt=False;";
        public static string connectString4 = @"Data Source=10.239.1.162;Initial Catalog= DBPrintLabel_ver02;Persist Security Info=True;User ID=khanh_ld;Password=250711;Encrypt=False;";
    }
}