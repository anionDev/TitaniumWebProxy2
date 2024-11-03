using TitaniumWebProxy2Backend.Core.Configuration;
using GRYLibrary.Core.APIServer.Settings;
using System.Threading;
using System;
using Microsoft.Extensions.Logging;
using GRYLibrary.Core.Logging.GeneralPurposeLogger;
using GRYLibrary.Core.APIServer.BaseServices;
using GRYLibrary.Core.Misc;
using System.Diagnostics.Metrics;
using TitaniumWebProxy2Backend.Core.Constants;

namespace TitaniumWebProxy2Backend.Core.BackgroundServices
{
    public sealed class MetricsBackgroundService : IteratingBackgroundService, ISomeBackgroundService
    {
        public ISomeBackgroundServiceSettings SomeBackgroundServiceSettings { get; private set; }
        private readonly Meter _Meter1;
        public Counter<decimal> SomeMetricsValue1 { get; private set; }
        private readonly Meter _Meter2;
        public Counter<decimal> SomeMetricsValue2 { get; private set; }
        public MetricsBackgroundService(ISomeBackgroundServiceSettings someBackgroundServiceSettings, IApplicationConstants applicationConstants) : base(applicationConstants.ExecutionMode, GeneralLoggerExtensions.SetupLogger(someBackgroundServiceSettings.LogConfiguration, applicationConstants.GetLogFolder(), nameof(MetricsBackgroundService)))
        {
            this.SomeBackgroundServiceSettings = someBackgroundServiceSettings;
            this.Enabled = this.SomeBackgroundServiceSettings.Enabled;

            this._Meter1 = new Meter(CodeUnitSpecificConstants.Metric1Name);//https://learn.microsoft.com/en-us/dotnet/core/diagnostics/metrics-instrumentation
            this.SomeMetricsValue1 = this._Meter1.CreateCounter<decimal>(CodeUnitSpecificConstants.Metric1Name);

            this._Meter2 = new Meter(CodeUnitSpecificConstants.Metric2Name);//https://learn.microsoft.com/en-us/dotnet/core/diagnostics/metrics-instrumentation
            this.SomeMetricsValue2 = this._Meter2.CreateCounter<decimal>(CodeUnitSpecificConstants.Metric2Name);
        }

        protected override void Run()
        {
            Thread.Sleep(TimeSpan.FromSeconds(20));
            this._Logger.Log("Do some scheduled job...", LogLevel.Debug);
            this.CalculateSomeMetricsValus();
        }

        public void CalculateSomeMetricsValus()
        {
            this.SomeMetricsValue1.Add(PercentValue.Random().Value);
            this.SomeMetricsValue2.Add(PercentValue.Random().Value);
        }

        public override void Dispose()
        {
            this._Meter1.Dispose();
        }
    }
}
