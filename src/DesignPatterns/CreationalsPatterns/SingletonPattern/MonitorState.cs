using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern;

// Wzorzec Singleton
internal sealed class MonitorState
{
    public int Enqueued { get; set; }
    public int Processed { get; set; }
    public int Sent { get; set; }

    public override string ToString()
    {
        return $"Enqueued: {Enqueued} Processed: {Processed} Sent: {Sent}";
    }

    private static MonitorState? _instance = null;
    public static MonitorState? Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new MonitorState();
            }

            return _instance;
        }
    }

    private MonitorState()
    {        
    }

}

internal sealed class Logger : Singleton<Logger>
{
    private Logger()
    {

    }
}

// Szablon singletona
internal class Singleton<T>
{
    private static Singleton<T>? _instance = null;
    public static Singleton<T>? Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Singleton<T>();
            }

            return _instance;
        }
    }

    protected Singleton()
    {
    }

}


/* PowerBuilder
// n_cst_monitorstate.sru
forward prototypes
end prototypes

global type n_cst_monitorstate from nonvisualobject
end type

global n_cst_monitorstate this

// --- Zmienne instancji (properties) ---
public:
    integer ii_Enqueued
    integer ii_Processed
    integer ii_Sent

// --- Singleton: statyczna instancja ---
private:
    n_cst_monitorstate inv_instance

public function string ToString()
    return "Enqueued: " + string(ii_Enqueued) + &
           " Processed: " + string(ii_Processed) + &
           " Sent: " + string(ii_Sent)
end function

public function n_cst_monitorstate Instance()
    if not isvalid(inv_instance) then
        inv_instance = create n_cst_monitorstate
    end if
    return inv_instance
end function

// Konstruktor
constructor()
    // Można inicjalizować pola jeśli trzeba
end constructor
*/