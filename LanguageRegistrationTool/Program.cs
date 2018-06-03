using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace LanguageRegistrationTool {
    internal static class Program {

        private static void Main(string[] args) {
            const string path = "cultures.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(Cultures));
            StreamReader reader = new StreamReader(path);
            Cultures culturesImport = (Cultures) serializer.Deserialize(reader);
            reader.Close();

            foreach (Culture culture in culturesImport.CultureList) {
                if (!culture.Code.CultureExists()) {
                    try {
                        CultureAndRegionInfoBuilder cib = new CultureAndRegionInfoBuilder(culture.Code, CultureAndRegionModifiers.None);
                        cib.LoadDataFromCultureInfo(new CultureInfo(culture.BaseFromCode));
                        cib.LoadDataFromRegionInfo(new RegionInfo(culture.BaseFromRegion));

                        cib.CultureEnglishName = $"{culture.Language} ({culture.Country})";
                        cib.CultureNativeName = cib.CultureEnglishName;
                        cib.IetfLanguageTag = culture.Code;
                        cib.RegionEnglishName = culture.Country;
                        cib.RegionNativeName = cib.RegionEnglishName;
                        cib.ISOCurrencySymbol = culture.CurrencyIso;
                        cib.NumberFormat.CurrencySymbol = culture.CurrencySymbol;
                        cib.CurrencyEnglishName = culture.CurrencyName;
                        cib.CurrencyNativeName = cib.CurrencyEnglishName;
                        cib.ThreeLetterISOLanguageName = culture.ThreeLetterIsoName;
                        cib.ThreeLetterWindowsLanguageName = culture.ThreeLetterWinName;
                        cib.TwoLetterISOLanguageName = culture.TwoLetterIsoName;

                        cib.Register();

                        Console.WriteLine(culture.Code + " => created");
                    } catch (Exception e) {
                        Console.WriteLine("Could not register {0} - {1}", culture.Code, e.Message);
                    }
                } else {
                    Console.WriteLine("{0} already exsists", culture.Code);
                }
            }

            Console.WriteLine("Finished - press any key to exit");
            Console.ReadKey();
        }

        private static bool CultureExists(this string cultureCode) {
            return CultureInfo.GetCultures(CultureTypes.AllCultures).Any(culture => string.Equals(culture.Name, cultureCode, StringComparison.CurrentCultureIgnoreCase));
        }

    }
}