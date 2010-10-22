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
		internal static global::MonoJavaBridge.MethodId _getRuntime18544;
		public static global::dalvik.system.VMRuntime getRuntime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<dalvik.system.VMRuntime>(@__env.CallStaticObjectMethod(dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._getRuntime18544)) as dalvik.system.VMRuntime;
		}
		public new float TargetHeapUtilization
		{
			get
			{
				return getTargetHeapUtilization();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTargetHeapUtilization18545;
		public float getTargetHeapUtilization() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::dalvik.system.VMRuntime._getTargetHeapUtilization18545);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._getTargetHeapUtilization18545);
		}
		internal static global::MonoJavaBridge.MethodId _setTargetHeapUtilization18546;
		public float setTargetHeapUtilization(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::dalvik.system.VMRuntime._setTargetHeapUtilization18546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._setTargetHeapUtilization18546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long MinimumHeapSize
		{
			get
			{
				return getMinimumHeapSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumHeapSize18547;
		public long getMinimumHeapSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::dalvik.system.VMRuntime._getMinimumHeapSize18547);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._getMinimumHeapSize18547);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumHeapSize18548;
		public long setMinimumHeapSize(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::dalvik.system.VMRuntime._setMinimumHeapSize18548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._setMinimumHeapSize18548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _gcSoftReferences18549;
		public void gcSoftReferences() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::dalvik.system.VMRuntime._gcSoftReferences18549);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._gcSoftReferences18549);
		}
		internal static global::MonoJavaBridge.MethodId _runFinalizationSync18550;
		public void runFinalizationSync() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::dalvik.system.VMRuntime._runFinalizationSync18550);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._runFinalizationSync18550);
		}
		public new long ExternalBytesAllocated
		{
			get
			{
				return getExternalBytesAllocated();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExternalBytesAllocated18551;
		public long getExternalBytesAllocated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::dalvik.system.VMRuntime._getExternalBytesAllocated18551);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::dalvik.system.VMRuntime.staticClass, global::dalvik.system.VMRuntime._getExternalBytesAllocated18551);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.VMRuntime.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/VMRuntime"));
			global::dalvik.system.VMRuntime._getRuntime18544 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "getRuntime", "()Ldalvik/system/VMRuntime;");
			global::dalvik.system.VMRuntime._getTargetHeapUtilization18545 = @__env.GetMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "getTargetHeapUtilization", "()F");
			global::dalvik.system.VMRuntime._setTargetHeapUtilization18546 = @__env.GetMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "setTargetHeapUtilization", "(F)F");
			global::dalvik.system.VMRuntime._getMinimumHeapSize18547 = @__env.GetMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "getMinimumHeapSize", "()J");
			global::dalvik.system.VMRuntime._setMinimumHeapSize18548 = @__env.GetMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "setMinimumHeapSize", "(J)J");
			global::dalvik.system.VMRuntime._gcSoftReferences18549 = @__env.GetMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "gcSoftReferences", "()V");
			global::dalvik.system.VMRuntime._runFinalizationSync18550 = @__env.GetMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "runFinalizationSync", "()V");
			global::dalvik.system.VMRuntime._getExternalBytesAllocated18551 = @__env.GetMethodIDNoThrow(global::dalvik.system.VMRuntime.staticClass, "getExternalBytesAllocated", "()J");
		}
	}
}
