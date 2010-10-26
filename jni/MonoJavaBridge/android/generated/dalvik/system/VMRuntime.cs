namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class VMRuntime : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static VMRuntime()
		{
			InitJNI();
		}
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
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<dalvik.system.VMRuntime>(@__env.CallStaticObjectMethod(dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._getRuntime18662)) as dalvik.system.VMRuntime;
		}
		public new float TargetHeapUtilization
		{
			get
			{
				return getTargetHeapUtilization();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTargetHeapUtilization18663;
		public float getTargetHeapUtilization() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::dalvik.system.VMRuntime._getTargetHeapUtilization18663);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._getTargetHeapUtilization18663);
		}
		internal static global::MonoJavaBridge.MethodId _setTargetHeapUtilization18664;
		public float setTargetHeapUtilization(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::dalvik.system.VMRuntime._setTargetHeapUtilization18664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._setTargetHeapUtilization18664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long MinimumHeapSize
		{
			get
			{
				return getMinimumHeapSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumHeapSize18665;
		public long getMinimumHeapSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::dalvik.system.VMRuntime._getMinimumHeapSize18665);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._getMinimumHeapSize18665);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumHeapSize18666;
		public long setMinimumHeapSize(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::dalvik.system.VMRuntime._setMinimumHeapSize18666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._setMinimumHeapSize18666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _gcSoftReferences18667;
		public void gcSoftReferences() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::dalvik.system.VMRuntime._gcSoftReferences18667);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._gcSoftReferences18667);
		}
		internal static global::MonoJavaBridge.MethodId _runFinalizationSync18668;
		public void runFinalizationSync() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::dalvik.system.VMRuntime._runFinalizationSync18668);
			else
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
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::dalvik.system.VMRuntime._getExternalBytesAllocated18669);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._getExternalBytesAllocated18669);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.VMRuntime.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/VMRuntime"));
			global::dalvik.system.VMRuntime._getRuntime18662 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "getRuntime", "()Ldalvik/system/VMRuntime;");
			global::dalvik.system.VMRuntime._getTargetHeapUtilization18663 = @__env.GetMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "getTargetHeapUtilization", "()F");
			global::dalvik.system.VMRuntime._setTargetHeapUtilization18664 = @__env.GetMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "setTargetHeapUtilization", "(F)F");
			global::dalvik.system.VMRuntime._getMinimumHeapSize18665 = @__env.GetMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "getMinimumHeapSize", "()J");
			global::dalvik.system.VMRuntime._setMinimumHeapSize18666 = @__env.GetMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "setMinimumHeapSize", "(J)J");
			global::dalvik.system.VMRuntime._gcSoftReferences18667 = @__env.GetMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "gcSoftReferences", "()V");
			global::dalvik.system.VMRuntime._runFinalizationSync18668 = @__env.GetMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "runFinalizationSync", "()V");
			global::dalvik.system.VMRuntime._getExternalBytesAllocated18669 = @__env.GetMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "getExternalBytesAllocated", "()J");
		}
	}
}
