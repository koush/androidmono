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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMRuntime._getTargetHeapUtilization18663.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMRuntime._getTargetHeapUtilization18663 = @__env.GetMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "getTargetHeapUtilization", "()F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._getTargetHeapUtilization18663);
		}
		internal static global::MonoJavaBridge.MethodId _setTargetHeapUtilization18664;
		public float setTargetHeapUtilization(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMRuntime._setTargetHeapUtilization18664.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMRuntime._setTargetHeapUtilization18664 = @__env.GetMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "setTargetHeapUtilization", "(F)F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._setTargetHeapUtilization18664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMRuntime._getMinimumHeapSize18665.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMRuntime._getMinimumHeapSize18665 = @__env.GetMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "getMinimumHeapSize", "()J");
			return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._getMinimumHeapSize18665);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumHeapSize18666;
		public long setMinimumHeapSize(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMRuntime._setMinimumHeapSize18666.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMRuntime._setMinimumHeapSize18666 = @__env.GetMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "setMinimumHeapSize", "(J)J");
			return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._setMinimumHeapSize18666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _gcSoftReferences18667;
		public void gcSoftReferences()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMRuntime._gcSoftReferences18667.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMRuntime._gcSoftReferences18667 = @__env.GetMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "gcSoftReferences", "()V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._gcSoftReferences18667);
		}
		internal static global::MonoJavaBridge.MethodId _runFinalizationSync18668;
		public void runFinalizationSync()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMRuntime._runFinalizationSync18668.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMRuntime._runFinalizationSync18668 = @__env.GetMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "runFinalizationSync", "()V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._runFinalizationSync18668);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMRuntime._getExternalBytesAllocated18669.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMRuntime._getExternalBytesAllocated18669 = @__env.GetMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "getExternalBytesAllocated", "()J");
			return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._getExternalBytesAllocated18669);
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
