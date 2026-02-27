using BreakTimer.Custom;

namespace BreakTimer;

public partial class MainPage : ContentPage
{
    private bool isRunning = false;
    int intSec = 0;
    int intMin = 0;
    
    public MainPage()
    {
        InitializeComponent();
        Title = "Break Timer";
    }
    
    public void Tick(int min)
    {
        intMin = min;
        intSec++;
        if (intSec == 60)
        {
            intSec = 0;
            intMin--;
        }

        lblDisplay.Text = $"{min} minutes left";
        
    }

    private void BtnTakeFive_OnClicked(object sender, EventArgs e)
    {
        isRunning = true;
        int intMin = 1;
        
        Application.Current.Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            if (isRunning)
            {
                Tick(intMin);
            }

            if (intMin == 0 && intSec == 0)
            {
                isRunning = false;
                lblDisplay.Text = "Time's up! Back to Work!";
            }
            
            return (isRunning);
        } );
}

    private void BtnTakeTen_OnClicked(object sender, EventArgs e)
    {
    }

    private void BtnTakeFifteen_OnClicked(object sender, EventArgs e)
    {
        
    }
}