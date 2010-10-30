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
		internal static global::MonoJavaBridge.MethodId _getRuntime18662;
		public static global::dalvik.system.VMRuntime getRuntime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMRuntime._getRuntime18662.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMRuntime._getRuntime18662 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "getRuntime", "()Ldalvik/system/VMRuntime;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<dalvik.system.VMRuntime>(@__env.CallStaticObjectMethod(dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._getRuntime18662)) as dalvik.system.VMRuntime;
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
		internal static global::MonoJavaBridge.MethodId _getTargetHeapUtilization18663;
		public float getTargetHeapUtilization()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::dalvik.system.VMRuntime.staticClass, "getTargetHeapUtilization", "()F", ref global::dalvik.system.VMRuntime._getTargetHeapUtilization18663);
		}
		internal static global::MonoJavaBridge.MethodId _setTargetHeapUtilization18664;
		public float setTargetHeapUtilization(float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::dalvik.system.VMRuntime.staticClass, "setTargetHeapUtilization", "(F)F", ref global::dalvik.system.VMRuntime._setTargetHeapUtilization18664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMinimumHeapSize18665;
		public long getMinimumHeapSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::dalvik.system.VMRuntime.staticClass, "getMinimumHeapSize", "()J", ref global::dalvik.system.VMRuntime._getMinimumHeapSize18665);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumHeapSize18666;
		public long setMinimumHeapSize(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::dalvik.system.VMRuntime.staticClass, "setMinimumHeapSize", "(J)J", ref global::dalvik.system.VMRuntime._setMinimumHeapSize18666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _gcSoftReferences18667;
		public void gcSoftReferences()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::dalvik.system.VMRuntime.staticClass, "gcSoftReferences", "()V", ref global::dalvik.system.VMRuntime._gcSoftReferences18667);
		}
		internal static global::MonoJavaBridge.MethodId _runFinalizationSync18668;
		public void runFinalizationSync()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::dalvik.system.VMRuntime.staticClass, "runFinalizationSync", "()V", ref global::dalvik.system.VMRuntime._runFinalizationSync18668);
		}
		public new long ExternalBytesAllocated
		{
			get
			{
				return getExternalBytesAllocated();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExternalBytesAllocated18669;
		public long getExternalBytesAllocated()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::dalvik.system.VMRuntime.staticClass, "getExternalBytesAllocated", "()J", ref global::dalvik.system.VMRuntime._getExternalBytesAllocated18669);
		}
		static VMRuntime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.VMRuntime.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/VMRuntime"));
		}
		internal static void InitJNI()
		{
		}
	}
}
