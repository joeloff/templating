﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable enable

using System.CommandLine.Invocation;
using System.CommandLine.Parsing;
using Microsoft.TemplateEngine.Abstractions;

namespace Microsoft.TemplateEngine.Cli.Commands
{
    internal class AliasShowCommand : BaseCommand<AliasShowCommandArgs>
    {
        internal AliasShowCommand(ITemplateEngineHost host, ITelemetryLogger logger, NewCommandCallbacks callbacks) : base(host, logger, callbacks, "show") { }

        protected override Task<NewCommandStatus> ExecuteAsync(AliasShowCommandArgs args, IEngineEnvironmentSettings environmentSettings, InvocationContext context) => throw new NotImplementedException();

        protected override AliasShowCommandArgs ParseContext(ParseResult parseResult) => throw new NotImplementedException();
    }

    internal class AliasShowCommandArgs : GlobalArgs
    {
        public AliasShowCommandArgs(AliasShowCommand command, ParseResult parseResult) : base(command, parseResult)
        {
        }
    }
}