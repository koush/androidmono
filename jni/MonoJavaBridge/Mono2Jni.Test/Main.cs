using System;
using Mono2Jni;

namespace Mono2Jni.Test
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            MonoReflector refl = new MonoReflector(@"T:\documents\android\androidmono\androidmono\jni\MonoJavaBridge\bin\Mono2Jni.Test.exe");
            refl.Generate(GenerationFlags.KeepIntermediateFiles);
        }
    }
}

