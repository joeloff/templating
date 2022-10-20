﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;

namespace Microsoft.TemplateEngine.CommandUtils
{
    public readonly struct CommandResult
    {
        public static readonly CommandResult Empty;

        public CommandResult(ProcessStartInfo startInfo, int exitCode, string? stdOut, string? stdErr)
        {
            StartInfo = startInfo;
            ExitCode = exitCode;
            StdOut = stdOut;
            StdErr = stdErr;
        }

        public ProcessStartInfo StartInfo { get; }

        public int ExitCode { get; }

        public string? StdOut { get; }

        public string? StdErr { get; }
    }
}