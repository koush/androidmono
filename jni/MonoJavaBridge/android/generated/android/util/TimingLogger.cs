namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TimingLogger : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TimingLogger()
		{
			InitJNI();
		}
		protected TimingLogger(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _reset8630;
		public virtual void reset(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.TimingLogger._reset8630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.TimingLogger.staticClass, global::android.util.TimingLogger._reset8630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _reset8631;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.TimingLogger._reset8631);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.TimingLogger.staticClass, global::android.util.TimingLogger._reset8631);
		}
		internal static global::MonoJavaBridge.MethodId _addSplit8632;
		public virtual void addSplit(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.TimingLogger._addSplit8632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.TimingLogger.staticClass, global::android.util.TimingLogger._addSplit8632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dumpToLog8633;
		public virtual void dumpToLog() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.TimingLogger._dumpToLog8633);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.TimingLogger.staticClass, global::android.util.TimingLogger._dumpToLog8633);
		}
		internal static global::MonoJavaBridge.MethodId _TimingLogger8634;
		public TimingLogger(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.TimingLogger.staticClass, global::android.util.TimingLogger._TimingLogger8634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.TimingLogger.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/TimingLogger"));
			global::android.util.TimingLogger._reset8630 = @__env.GetMethodIDNoThrow(global::android.util.TimingLogger.staticClass, "reset", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.util.TimingLogger._reset8631 = @__env.GetMethodIDNoThrow(global::android.util.TimingLogger.staticClass, "reset", "()V");
			global::android.util.TimingLogger._addSplit8632 = @__env.GetMethodIDNoThrow(global::android.util.TimingLogger.staticClass, "addSplit", "(Ljava/lang/String;)V");
			global::android.util.TimingLogger._dumpToLog8633 = @__env.GetMethodIDNoThrow(global::android.util.TimingLogger.staticClass, "dumpToLog", "()V");
			global::android.util.TimingLogger._TimingLogger8634 = @__env.GetMethodIDNoThrow(global::android.util.TimingLogger.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
