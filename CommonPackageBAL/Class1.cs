using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtpNet;

namespace CommonPackageBAL
{
    public class Class1
    {
        Byte[] bytes = OtpNet.Base32Encoding.ToBytes("35325");
        //var totp = new OtpNet.Totp(bytes);
    }
}
