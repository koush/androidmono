namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TimingLogger : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TimingLogger(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _reset13890;
		public virtual void reset(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.TimingLogger.staticClass, global::android.util.TimingLogger._reset13890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _reset13891;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.TimingLogger.staticClass, global::android.util.TimingLogger._reset13891);
		}
		internal static global::MonoJavaBridge.MethodId _addSplit13892;
		public virtual void addSplit(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.TimingLogger.staticClass, global::android.util.TimingLogger._addSplit13892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dumpToLog13893;
		public virtual void dumpToLog()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.TimingLogger.staticClass, global::android.util.TimingLogger._dumpToLog13893);
		}
		internal static global::MonoJavaBridge.MethodId _TimingLogger13894;
		public TimingLogger(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.TimingLogger.staticClass, global::android.util.TimingLogger._TimingLogger13894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static TimingLogger()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.TimingLogger.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/TimingLogger"));
			global::android.util.TimingLogger._reset13890 = @__env.GetMethodIDNoThrow(global::android.util.TimingLogger.staticClass, "reset", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.util.TimingLogger._reset13891 = @__env.GetMethodIDNoThrow(global::android.util.TimingLogger.staticClass, "reset", "()V");
			global::android.util.TimingLogger._addSplit13892 = @__env.GetMethodIDNoThrow(global::android.util.TimingLogger.staticClass, "addSplit", "(Ljava/lang/String;)V");
			global::android.util.TimingLogger._dumpToLog13893 = @__env.GetMethodIDNoThrow(global::android.util.TimingLogger.staticClass, "dumpToLog", "()V");
			global::android.util.TimingLogger._TimingLogger13894 = @__env.GetMethodIDNoThrow(global::android.util.TimingLogger.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
