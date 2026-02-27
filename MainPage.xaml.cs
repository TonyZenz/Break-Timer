namespace BreakTimer;

public partial class MainPage : ContentPage
{
    private bool isRunning = false;
    private bool isFlashing = false;
    int intSec = 0;
    int intMin = 0;
    
    public MainPage()
    {
        InitializeComponent();
        Title = "Break Timer";
    }
    
    private void Tick()
    {
        intSec++;
        if (intSec == 60)
        {
            intSec = 0;
            intMin--;
        }
        lblDisplay.Text = $"{intMin} minutes left";
    }

    private void StartFlashing()
    {
        isFlashing = true;
        bool flashOn = false;

        Application.Current.Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            flashOn = !flashOn;
            ftmMain.BackgroundColor = flashOn ? Colors.Red : Colors.White;
            return isFlashing;
        });
    }

    private void BtnTakeFive_OnClicked(object sender, EventArgs e)
    {
        // Initialize variables
        isRunning = true;
        isFlashing = false;
        intMin = 1;
        intSec = 0;
        
        Application.Current.Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            
            if (intMin == 0 && intSec == 0)
            {
                isRunning = false;
                lblDisplay.Text = "Time's up! Back to Work!";
                StartFlashing();
            }
            if (isRunning)
            {
                Tick();
            }
            return (isRunning);
        } );
}

    private void BtnTakeTen_OnClicked(object sender, EventArgs e)
    {
        isRunning = true;
        isFlashing = false;
        intMin = 10;
        intSec = 0;
        
        Application.Current.Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            
            if (intMin == 0 && intSec == 0)
            {
                isRunning = false;
                lblDisplay.Text = "Time's up! Back to Work!";
                StartFlashing();
            }
            if (isRunning)
            {
                Tick();
            }
            return (isRunning);
        } );
    }

    private void BtnTakeFifteen_OnClicked(object sender, EventArgs e)
    {
        isRunning = true;
        isFlashing = false;
        intMin = 15;
        intSec = 0;
        
        Application.Current.Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            
            if (intMin == 0 && intSec == 0)
            {
                isRunning = false;
                lblDisplay.Text = "Time's up! Back to Work!";
                StartFlashing();
            }
            if (isRunning)
            {
                Tick();
            }
            return (isRunning);
        } );
        
    }
}