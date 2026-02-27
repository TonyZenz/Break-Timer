namespace BreakTimer.Custom;

public class TimerLogic
{
    private int _intSec = 0;
    private int _intMin = 0;

    public void StartTimer(int minutes)
    {
        _intMin = minutes;
        _intSec = 0;
    }

    public void Tick()
    {
        _intSec++;
        if (_intSec == 60)
        {
            _intSec = 0;
            _intMin--;
        }

        if (_intMin <= 0 && _intSec <= 0)
        {
            
        }

    }
    
    



}