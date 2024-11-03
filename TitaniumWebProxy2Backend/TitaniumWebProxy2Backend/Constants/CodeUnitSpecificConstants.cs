namespace TitaniumWebProxy2Backend.Core.Constants
{
    public class CodeUnitSpecificConstants
    {
        public const string CompanyName = "MyCompany";
        public const string ProductName = "MyProduct";
        public const string MetricNamePrefix = $"{CodeUnitSpecificConstants.CompanyName}.{CodeUnitSpecificConstants.ProductName}.{GeneralConstants.CodeUnitName}";
        public const string Metric1Name = "MyMetric1";
        public static readonly string Metric1NameFull = $"{CodeUnitSpecificConstants.MetricNamePrefix}.{CodeUnitSpecificConstants.Metric1Name}";
        public const string Metric2Name = "MyMetric2";
        public static readonly string Metric2NameFull = $"{CodeUnitSpecificConstants.MetricNamePrefix}.{CodeUnitSpecificConstants.Metric2Name}";
    }
}
