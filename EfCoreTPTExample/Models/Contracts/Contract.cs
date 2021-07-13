using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTPTExample.Models.Contracts
{
    public class Contract
    {
        public int ContractId { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Charge { get; set; }
    }
    public class MobileContract : Contract
    {
        public string MobileNumber { get; set; }
    }
    public class TvContract : Contract
    {
        public string PackageType { get; set; }
    }
    public class BroadBandContract : Contract
    {
        public int DownloadSpeed { get; set; }
    }

}
