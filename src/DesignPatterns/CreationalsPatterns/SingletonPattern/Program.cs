
using SingletonPattern;

Console.WriteLine("Hello, World!");

MonitorState state = MonitorState.Instance;
state.Enqueued++;
state.Enqueued++;

Console.WriteLine(state);

state.Enqueued--;
state.Processed++;

Console.WriteLine(state);

MonitorState state2 = MonitorState.Instance;

state2.Processed--;
state2.Sent++;

Console.WriteLine(state);

var logger = Logger.Instance;