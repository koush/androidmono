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
		internal static global::MonoJavaBridge.MethodId _reset9176;
		public virtual void reset(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.TimingLogger._reset9176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.TimingLogger.staticClass, global::android.util.TimingLogger._reset9176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _reset9177;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.TimingLogger._reset9177);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.TimingLogger.staticClass, global::android.util.TimingLogger._reset9177);
		}
		internal static global::MonoJavaBridge.MethodId _addSplit9178;
		public virtual void addSplit(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.TimingLogger._addSplit9178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.TimingLogger.staticClass, global::android.util.TimingLogger._addSplit9178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dumpToLog9179;
		public virtual void dumpToLog() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.TimingLogger._dumpToLog9179);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.TimingLogger.staticClass, global::android.util.TimingLogger._dumpToLog9179);
		}
		internal static global::MonoJavaBridge.MethodId _TimingLogger9180;
		public TimingLogger(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.TimingLogger.staticClass, global::android.util.TimingLogger._TimingLogger9180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.TimingLogger.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/TimingLogger"));
			global::android.util.TimingLogger._reset9176 = @__env.GetMethodIDNoThrow(global::android.util.TimingLogger.staticClass, "reset", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.util.TimingLogger._reset9177 = @__env.GetMethodIDNoThrow(global::android.util.TimingLogger.staticClass, "reset", "()V");
			global::android.util.TimingLogger._addSplit9178 = @__env.GetMethodIDNoThrow(global::android.util.TimingLogger.staticClass, "addSplit", "(Ljava/lang/String;)V");
			global::android.util.TimingLogger._dumpToLog9179 = @__env.GetMethodIDNoThrow(global::android.util.TimingLogger.staticClass, "dumpToLog", "()V");
			global::android.util.TimingLogger._TimingLogger9180 = @__env.GetMethodIDNoThrow(global::android.util.TimingLogger.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
