﻿using System.Collections.Generic;

namespace Swagger.Codegen.CodegenProcessors.CSharp.Templates
{
    public partial class Output
    {
        public CodegenSettings Settings { get; set; }

        public IList<string> Snippets { get; set; }
    }
}