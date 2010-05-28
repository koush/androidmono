using System;
using System.Collections.Generic;
using System.Text;

namespace Mono2Jni
{
    [Flags]
    public enum GenerationFlags : int
    {
        None = 0,
        KeepIntermediateFiles = 1
    }
}
