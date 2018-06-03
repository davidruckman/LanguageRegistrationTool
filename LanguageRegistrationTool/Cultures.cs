using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace LanguageRegistrationTool {
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class Cultures {
        private Culture[] _cultureField;

        [XmlElement("Culture")]
        public Culture[] CultureList { get { return _cultureField; } set { _cultureField = value; } }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Culture {
        private string _baseFromCodeField;
        private string _baseFromRegionField;
        private string _codeField;
        private string _languageField;
        private string _countryField;
        private string _currencyIsoField;
        private string _currencySymbolField;
        private string _currencyNameField;
        private string _twoLetterIsoNameField;
        private string _threeLetterIsoNameField;
        private string _threeLetterWinNameField;

        public string BaseFromCode { get { return _baseFromCodeField; } set { _baseFromCodeField = value; } }
        public string BaseFromRegion { get { return _baseFromRegionField; } set { _baseFromRegionField = value; } }
        public string Code { get { return _codeField; } set { _codeField = value; } }
        public string Language { get { return _languageField; } set { _languageField = value; } }
        public string Country { get { return _countryField; } set { _countryField = value; } }
        public string CurrencyIso { get { return _currencyIsoField; } set { _currencyIsoField = value; } }
        public string CurrencySymbol { get { return _currencySymbolField; } set { _currencySymbolField = value; } }
        public string CurrencyName { get { return _currencyNameField; } set { _currencyNameField = value; } }
        public string TwoLetterIsoName { get { return _twoLetterIsoNameField; } set { _twoLetterIsoNameField = value; } }
        public string ThreeLetterIsoName { get { return _threeLetterIsoNameField; } set { _threeLetterIsoNameField = value; } }
        public string ThreeLetterWinName { get { return _threeLetterWinNameField; } set { _threeLetterWinNameField = value; } }
    }
}