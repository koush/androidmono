namespace java.util.prefs
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidPreferencesFormatException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InvalidPreferencesFormatException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public InvalidPreferencesFormatException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.prefs.InvalidPreferencesFormatException._m0.native == global::System.IntPtr.Zero)
				global::java.util.prefs.InvalidPreferencesFormatException._m0 = @__env.GetMethodIDNoThrow(global::java.util.prefs.InvalidPreferencesFormatException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.InvalidPreferencesFormatException.staticClass, global::java.util.prefs.InvalidPreferencesFormatException._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public InvalidPreferencesFormatException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.prefs.InvalidPreferencesFormatException._m1.native == global::System.IntPtr.Zero)
				global::java.util.prefs.InvalidPreferencesFormatException._m1 = @__env.GetMethodIDNoThrow(global::java.util.prefs.InvalidPreferencesFormatException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.InvalidPreferencesFormatException.staticClass, global::java.util.prefs.InvalidPreferencesFormatException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public InvalidPreferencesFormatException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.prefs.InvalidPreferencesFormatException._m2.native == global::System.IntPtr.Zero)
				global::java.util.prefs.InvalidPreferencesFormatException._m2 = @__env.GetMethodIDNoThrow(global::java.util.prefs.InvalidPreferencesFormatException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.InvalidPreferencesFormatException.staticClass, global::java.util.prefs.InvalidPreferencesFormatException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static InvalidPreferencesFormatException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.InvalidPreferencesFormatException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/InvalidPreferencesFormatException"));
		}
	}
}
