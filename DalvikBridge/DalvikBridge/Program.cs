using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;
using System.Net;
//using OpenGLES;

namespace MonoDalvikBridge
{
    class Program
    {
        /*
        static EGLDisplay myDisplay;
        static EGLSurface mySurface;
        static EGLContext myContext;
        */

        static void Main(string[] args)
        {
            DalvikBridge.Initialize();
            DalvikBridge.DebugLog("Mono has initialized.");

            /*
            myDisplay = egl.GetDisplay(EGLNativeDisplayType.Default);

            int major, minor;
            egl.Initialize(myDisplay, out major, out minor);

            EGLConfig[] configs = new EGLConfig[10];
            int[] attribList = new int[] 
            { 
                egl.EGL_RED_SIZE, 5, 
                egl.EGL_GREEN_SIZE, 6, 
                egl.EGL_BLUE_SIZE, 5, 
                egl.EGL_DEPTH_SIZE, 16 , 
                egl.EGL_SURFACE_TYPE, egl.EGL_WINDOW_BIT,
                egl.EGL_STENCIL_SIZE, egl.EGL_DONT_CARE,
                egl.EGL_NONE, egl.EGL_NONE 
            };

            int numConfig;
            if (!egl.ChooseConfig(myDisplay, attribList, configs, configs.Length, out numConfig) || numConfig < 1)
                throw new InvalidOperationException("Unable to choose config.");

            EGLConfig config = configs[0];
            mySurface = egl.CreateWindowSurface(myDisplay, config, Handle, null);
            myContext = egl.CreateContext(myDisplay, config, EGLContext.None, null);

            egl.MakeCurrent(myDisplay, mySurface, mySurface, myContext);
            */
            
            //try
            //{
            //    DalvikBridge.DebugLog("Trying google");
            //    HttpWebRequest req = HttpWebRequest.Create(new Uri("http://www.google.com")) as HttpWebRequest;
            //    DalvikBridge.DebugLog("request created");
            //    HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
            //    using (StreamReader reader = new StreamReader(resp.GetResponseStream()))
            //    {
            //        string content = reader.ReadToEnd();
            //        DalvikBridge.DebugLog("Content:");
            //        DalvikBridge.DebugLog("Content:\n{0}", content);
            //    }
            //}
            //catch (Exception e)
            //{
            //    DalvikBridge.DebugLog("ex caught");
            //    DalvikBridge.DebugLog("error: {0}{1}", e.Message == null ? "null while downloading" : e.Message, e.GetType());
            //}


            // suspend this thread forever. remoting happens on other threads.
            // not a clean way to do it, as there is always a 
            // inactive thread. but i don't want to try to try to embed mono yet.
            Thread.Sleep(Timeout.Infinite);
        }
    }
}
