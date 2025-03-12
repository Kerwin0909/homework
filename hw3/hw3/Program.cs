using System;
using System.Data;
using System.Threading;

public class Clock
{
    public event EventHandler Tick;//Tick事件
    public event EventHandler Alarm;//Alarm事件
    public DateTime Timenow;//当前时间
    public DateTime Alarmtime;//响应时间
    public void begin()
    {
        while (true)
        {
            Timenow = DateTime.Now;
            if (Timenow < Alarmtime)
            {
                onTick();
                Thread.Sleep(1000);
            }
            else
            {
                onAlarm();
                break;
            }
        }
    }
    protected virtual void onTick()
    {
        Tick?.Invoke(this, EventArgs.Empty);
    }
    protected virtual void onAlarm()
    {
        Alarm?.Invoke(this, EventArgs.Empty);
    }
}
class Program
{
    static void Main()
    {
        Clock clock = new Clock();
        clock.Alarmtime = DateTime.Now.AddSeconds(5);
        clock.Tick += onTick;
        clock.Alarm += onAlarm;
        clock.begin();
    }

    static void onTick(object sender, EventArgs e)
    {
        Console.WriteLine("当前时间:" + DateTime.Now);
    }
    static void onAlarm(object sender, EventArgs e)
    {
        Console.WriteLine("时间到");
    }
}