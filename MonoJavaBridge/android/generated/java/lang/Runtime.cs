namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Runtime : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Runtime(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void exit(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Runtime.staticClass, "exit", "(I)V", ref global::java.lang.Runtime._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void runFinalizersOnExit(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Runtime._m1.native == global::System.IntPtr.Zero)
				global::java.lang.Runtime._m1 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Runtime.staticClass, "runFinalizersOnExit", "(Z)V");
			@__env.CallStaticVoidMethod(java.lang.Runtime.staticClass, global::java.lang.Runtime._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void loadLibrary(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Runtime.staticClass, "loadLibrary", "(Ljava/lang/String;)V", ref global::java.lang.Runtime._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void load(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Runtime.staticClass, "load", "(Ljava/lang/String;)V", ref global::java.lang.Runtime._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void gc()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Runtime.staticClass, "gc", "()V", ref global::java.lang.Runtime._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void runFinalization()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Runtime.staticClass, "runFinalization", "()V", ref global::java.lang.Runtime._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.lang.Runtime getRuntime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Runtime._m6.native == global::System.IntPtr.Zero)
				global::java.lang.Runtime._m6 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Runtime.staticClass, "getRuntime", "()Ljava/lang/Runtime;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Runtime.staticClass, global::java.lang.Runtime._m6)) as java.lang.Runtime;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual long freeMemory()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.lang.Runtime.staticClass, "freeMemory", "()J", ref global::java.lang.Runtime._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual long maxMemory()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.lang.Runtime.staticClass, "maxMemory", "()J", ref global::java.lang.Runtime._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void addShutdownHook(java.lang.Thread arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Runtime.staticClass, "addShutdownHook", "(Ljava/lang/Thread;)V", ref global::java.lang.Runtime._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool removeShutdownHook(java.lang.Thread arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Runtime.staticClass, "removeShutdownHook", "(Ljava/lang/Thread;)Z", ref global::java.lang.Runtime._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void halt(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Runtime.staticClass, "halt", "(I)V", ref global::java.lang.Runtime._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.lang.Process exec(java.lang.String arg0, java.lang.String[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Runtime.staticClass, "exec", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Process;", ref global::java.lang.Runtime._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Process;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.lang.Process exec(java.lang.String[] arg0, java.lang.String[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Runtime.staticClass, "exec", "([Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Process;", ref global::java.lang.Runtime._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Process;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.lang.Process exec(java.lang.String[] arg0, java.lang.String[] arg1, java.io.File arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Runtime.staticClass, "exec", "([Ljava/lang/String;[Ljava/lang/String;Ljava/io/File;)Ljava/lang/Process;", ref global::java.lang.Runtime._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Process;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::java.lang.Process exec(java.lang.String arg0, java.lang.String[] arg1, java.io.File arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Runtime.staticClass, "exec", "(Ljava/lang/String;[Ljava/lang/String;Ljava/io/File;)Ljava/lang/Process;", ref global::java.lang.Runtime._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Process;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::java.lang.Process exec(java.lang.String[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Runtime.staticClass, "exec", "([Ljava/lang/String;)Ljava/lang/Process;", ref global::java.lang.Runtime._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Process;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::java.lang.Process exec(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Runtime.staticClass, "exec", "(Ljava/lang/String;)Ljava/lang/Process;", ref global::java.lang.Runtime._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Process;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual int availableProcessors()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Runtime.staticClass, "availableProcessors", "()I", ref global::java.lang.Runtime._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual long totalMemory()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.lang.Runtime.staticClass, "totalMemory", "()J", ref global::java.lang.Runtime._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void traceInstructions(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Runtime.staticClass, "traceInstructions", "(Z)V", ref global::java.lang.Runtime._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void traceMethodCalls(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Runtime.staticClass, "traceMethodCalls", "(Z)V", ref global::java.lang.Runtime._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual global::java.io.InputStream getLocalizedInputStream(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Runtime.staticClass, "getLocalizedInputStream", "(Ljava/io/InputStream;)Ljava/io/InputStream;", ref global::java.lang.Runtime._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual global::java.io.OutputStream getLocalizedOutputStream(java.io.OutputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Runtime.staticClass, "getLocalizedOutputStream", "(Ljava/io/OutputStream;)Ljava/io/OutputStream;", ref global::java.lang.Runtime._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.OutputStream;
		}
		static Runtime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Runtime.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Runtime"));
		}
	}
}
