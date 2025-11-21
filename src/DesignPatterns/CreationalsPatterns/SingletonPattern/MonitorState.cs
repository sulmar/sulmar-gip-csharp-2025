using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern;

internal class MonitorState
{
    public int Enqueued { get; set; }
    public int Processed { get; set; }
    public int Sent { get; set; }

    public override string ToString()
    {
        return $"Enqueued: {Enqueued} Processed: {Processed} Sent: {Sent}";
    }

}
