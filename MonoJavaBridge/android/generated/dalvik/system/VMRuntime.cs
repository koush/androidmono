namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class VMRuntime : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal VMRuntime(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::dalvik.system.VMRuntime Runtime
		{
			get
			{
				return getRuntime();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::dalvik.system.VMRuntime getRuntime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMRuntime._m0.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMRuntime._m0 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "getRuntime", "()Ldalvik/system/VMRuntime;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<dalvik.system.VMRuntime>(@__env.CallStaticObjectMethod(dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._m0)) as dalvik.system.VMRuntime;
		}
		public new float TargetHeapUtilization
		{
			get
			{
				return getTargetHeapUtilization();
			}
			set
			{
				setTargetHeapUtilization(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public float getTargetHeapUtilization()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::dalvik.system.VMRuntime.staticClass, "getTargetHeapUtilization", "()F", ref global::dalvik.system.VMRuntime._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public float setTargetHeapUtilization(float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::dalvik.system.VMRuntime.staticClass, "setTargetHeapUtilization", "(F)F", ref global::dalvik.system.VMRuntime._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long MinimumHeapSize
		{
			get
			{
				return getMinimumHeapSize();
			}
			set
			{
				setMinimumHeapSize(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public long getMinimumHeapSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::dalvik.system.VMRuntime.staticClass, "getMinimumHeapSize", "()J", ref global::dalvik.system.VMRuntime._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public long setMinimumHeapSize(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::dalvik.system.VMRuntime.staticClass, "setMinimumHeapSize", "(J)J", ref global::dalvik.system.VMRuntime._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public void gcSoftReferences()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::dalvik.system.VMRuntime.staticClass, "gcSoftReferences", "()V", ref global::dalvik.system.VMRuntime._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public void runFinalizationSync()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::dalvik.system.VMRuntime.staticClass, "runFinalizationSync", "()V", ref global::dalvik.system.VMRuntime._m6);
		}
		public new long ExternalBytesAllocated
		{
			get
			{
				return getExternalBytesAllocated();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public long getExternalBytesAllocated()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::dalvik.system.VMRuntime.staticClass, "getExternalBytesAllocated", "()J", ref global::dalvik.system.VMRuntime._m7);
		}
		static VMRuntime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.VMRuntime.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/VMRuntime"));
		}
	}
}
