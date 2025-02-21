﻿using System.Runtime.InteropServices;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility;

namespace Boilerplate.Client.Windows.Services;

public class WindowsTelemetryInitializer : ITelemetryInitializer
{
    private string sessionId { get; } = Guid.NewGuid().ToString();

    public void Initialize(ITelemetry telemetry)
    {
        telemetry.Context.Session.Id = sessionId;

        telemetry.Context.Device.OperatingSystem = RuntimeInformation.OSDescription;

        telemetry.Context.Component.Version = typeof(WindowsTelemetryInitializer).Assembly.GetName().Version!.ToString();
    }
}
