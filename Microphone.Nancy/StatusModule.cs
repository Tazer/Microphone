﻿using Microphone.Core;
using Nancy;

namespace Microphone.Nancy
{
    public class StatusModule : NancyModule
    {
        public StatusModule()
        {
            Get["/status"] = _ =>
            {
                Logger.Information("OK");
                return "ok";
            };
        }
    }
}