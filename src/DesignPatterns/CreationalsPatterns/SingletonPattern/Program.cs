
using SingletonPattern;

Console.WriteLine("Hello, World!");

MonitorState state = new MonitorState();
state.Enqueued++;
state.Enqueued++;

Console.WriteLine(state);

state.Enqueued--;
state.Processed++;

Console.WriteLine(state);

MonitorState state2 = new MonitorState();

state2.Processed--;
state2.Sent++;

Console.WriteLine(state);