namespace EmployeeManagementApp;

public partial class App
{
    private Theme theme { get; init; }
    public App()
    {
        theme = new()
        {
            BarOptions = new()
            {
                HorizontalHeight = "72px"
            },
            ColorOptions = new()
            {
                Primary = "#61B551",
                Secondary = "#A65529",
                Success = "#23C02E",
                Info = "#9BD8FE",
                Warning = "#F8B86C",
                Danger = "#F95741",
                Light = "#F0F0F0",
                Dark = "#535353",
            },
            BackgroundOptions = new()
            {
                Primary = "#61B551",
                Secondary = "#A65529",
                Success = "#23C02E",
                Info = "#9BD8FE",
                Warning = "#F8B86C",
                Danger = "#F95741",
                Light = "#F0F0F0",
                Dark = "#535353",
            },
            InputOptions = new()
            {
                CheckColor = "#61B551",
            }
        };
    }
}
