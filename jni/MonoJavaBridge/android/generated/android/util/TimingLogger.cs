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
		internal static global::MonoJavaBridge.MethodId _reset13825;
		public virtual void reset(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.TimingLogger._reset13825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.TimingLogger.staticClass, global::android.util.TimingLogger._reset13825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _reset13826;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.TimingLogger._reset13826);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.TimingLogger.staticClass, global::android.util.TimingLogger._reset13826);
		}
		internal static global::MonoJavaBridge.MethodId _addSplit13827;
		public virtual void addSplit(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.TimingLogger._addSplit13827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.TimingLogger.staticClass, global::android.util.TimingLogger._addSplit13827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dumpToLog13828;
		public virtual void dumpToLog() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.TimingLogger._dumpToLog13828);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.TimingLogger.staticClass, global::android.util.TimingLogger._dumpToLog13828);
		}
		internal static global::MonoJavaBridge.MethodId _TimingLogger13829;
		public TimingLogger(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.TimingLogger.staticClass, global::android.util.TimingLogger._TimingLogger13829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.TimingLogger.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/TimingLogger"));
			global::android.util.TimingLogger._reset13825 = @__env.GetMethodIDNoThrow(global::android.util.TimingLogger.staticClass, "reset", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.util.TimingLogger._reset13826 = @__env.GetMethodIDNoThrow(global::android.util.TimingLogger.staticClass, "reset", "()V");
			global::android.util.TimingLogger._addSplit13827 = @__env.GetMethodIDNoThrow(global::android.util.TimingLogger.staticClass, "addSplit", "(Ljava/lang/String;)V");
			global::android.util.TimingLogger._dumpToLog13828 = @__env.GetMethodIDNoThrow(global::android.util.TimingLogger.staticClass, "dumpToLog", "()V");
			global::android.util.TimingLogger._TimingLogger13829 = @__env.GetMethodIDNoThrow(global::android.util.TimingLogger.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
