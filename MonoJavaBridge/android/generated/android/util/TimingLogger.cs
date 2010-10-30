namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TimingLogger : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TimingLogger(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void reset(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.TimingLogger.staticClass, "reset", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.util.TimingLogger._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.TimingLogger.staticClass, "reset", "()V", ref global::android.util.TimingLogger._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void addSplit(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.TimingLogger.staticClass, "addSplit", "(Ljava/lang/String;)V", ref global::android.util.TimingLogger._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void dumpToLog()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.TimingLogger.staticClass, "dumpToLog", "()V", ref global::android.util.TimingLogger._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public TimingLogger(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.TimingLogger._m4.native == global::System.IntPtr.Zero)
				global::android.util.TimingLogger._m4 = @__env.GetMethodIDNoThrow(global::android.util.TimingLogger.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.TimingLogger.staticClass, global::android.util.TimingLogger._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static TimingLogger()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.TimingLogger.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/TimingLogger"));
		}
		internal static void InitJNI()
		{
		}
	}
}
