﻿using LocalAppVeyor.Engine.Configuration.Model;

namespace LocalAppVeyor.Engine.Pipeline.Internal.Steps
{
    internal sealed class AfterBuildStep : ScriptBlockExecuterStep
    {
        public AfterBuildStep(ScriptBlock scriptBlock) 
            : base(scriptBlock)
        {
        }
    }
}