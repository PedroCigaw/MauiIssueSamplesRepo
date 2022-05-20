using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentCultureSample
{
    public class CultureData
    {
        public CultureData()
        {
            Add(CultureDataInfo.Create(() => Thread.CurrentThread.CurrentUICulture, "Thread.CurrentThread.CurrentUICulture"));
            Add(CultureDataInfo.Create(() => Thread.CurrentThread.CurrentCulture, "Thread.CurrentThread.CurrentCulture"));
            Add(CultureDataInfo.Create(() => CultureInfo.CurrentUICulture, "CultureInfo.CurrentUICulture"));
            Add(CultureDataInfo.Create(() => CultureInfo.DefaultThreadCurrentUICulture, "CultureInfo.DefaultThreadCurrentUICulture"));
            Add(CultureDataInfo.Create(() => CultureInfo.DefaultThreadCurrentCulture, "CultureInfo.DefaultThreadCurrentCulture"));
            Add(CultureDataInfo.Create(() => CultureInfo.InstalledUICulture, "CultureInfo.InstalledUICulture"));
            Add(CultureDataInfo.Create(() => CultureInfo.InvariantCulture, "CultureInfo.InvariantCulture"));
            Add(CultureDataInfo.Create(() => CultureInfo.CreateSpecificCulture("en-GB"), "CultureInfo.CreateSpecificCulture(\"en - GB\")"));

        }

        private CultureDataInfo Add(CultureDataInfo data)
        {
            Cultures.Add(data);
            return data;
        }

        public List<CultureDataInfo> Cultures { get; set; } = new List<CultureDataInfo>();
    }

    public class CultureDataInfo
    {
        private CultureDataInfo()
        {
            
        }

        public static CultureDataInfo Create(Func<CultureInfo> create, string name)
        {
            var result = new CultureDataInfo();
            result.Source = name;
            try
            {
                result.Culture = create();
            }
            catch (Exception ex)
            {
                result.Error = ex.Message;
            }
            return result;
        }

        public string Source { get; set; }

        public string Error { get; set; }

        public CultureInfo Culture { get; set; }

        public string CultureName => GetCultureString();

        private string GetCultureString()
        {
            if (Culture == null)
            {
                return "null";
            }

            if (string.IsNullOrEmpty(Culture.Name))
            {
                return Culture.EnglishName;
            }

            return Culture.ToString();
        }
        public override string ToString()
        {
            var error = string.Empty;
            if (!string.IsNullOrEmpty(Error))
            {
                error = $"           Error: {Error}";
            }
            return $"Source: {Source}           Culture: {GetCultureString()}{error}";
        }
    }
}
