using BuffettCodeCommon.Config;
using BuffettCodeCommon.Period;
using BuffettCodeCommon.Validator;

namespace BuffettCodeAddinRibbon.Settings
{
    public class CSVFormSettings
    {

        private CSVFormSettings(string ticker, PeriodRange<FiscalQuarterPeriod> range, CSVOutputSettings outputSettings)
        {
            Ticker = ticker;
            Range = range;
            OutputSettings = outputSettings;
        }


        public static CSVFormSettings Create(string ticker, FiscalQuarterPeriod from, FiscalQuarterPeriod to, CSVOutputSettings outputSettings)
        {
            JpTickerValidator.Validate(ticker);
            var range = PeriodRange<FiscalQuarterPeriod>.Create(from, to);
            return new CSVFormSettings(ticker, range, outputSettings);
        }
        public string Ticker { get; set; }
        public PeriodRange<FiscalQuarterPeriod> Range { get; set; }

        public CSVOutputSettings OutputSettings { get; set; }
        public bool IsCreateNewFile() => OutputSettings.Destination is CSVOutputDestination.NewFile;

        public bool IsUTF8Encoding() => OutputSettings.Encoding.Equals(CSVOutputEncoding.UTF8);
    }
}
