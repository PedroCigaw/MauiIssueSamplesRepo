using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using CurrentCultureSample.Annotations;

namespace CurrentCultureSample;

public class CultureDataService
{
    private static readonly CultureData _startUp;
    private CultureData _onLoad;

    public static CultureDataService Instance { get; }

    static CultureDataService()
    {
        Instance = new CultureDataService();
        _startUp = new CultureData();
    }

    private CultureDataService()
    {
    }

    public CultureData StartUp => _startUp;

    public CultureData Constructor
    {
        get { return new CultureData(); }
    }

    public void SetCultureToAU()
    {
        var culture = CultureInfo.CreateSpecificCulture("en-AU");
        CultureInfo.DefaultThreadCurrentCulture = culture;
        CultureInfo.DefaultThreadCurrentUICulture = culture;
    }
}