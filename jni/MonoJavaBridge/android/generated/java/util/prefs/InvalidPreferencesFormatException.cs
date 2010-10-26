namespace java.util.prefs
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidPreferencesFormatException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InvalidPreferencesFormatException()
		{
			InitJNI();
		}
		protected InvalidPreferencesFormatException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InvalidPreferencesFormatException28173;
		public InvalidPreferencesFormatException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.InvalidPreferencesFormatException.staticClass, global::java.util.prefs.InvalidPreferencesFormatException._InvalidPreferencesFormatException28173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidPreferencesFormatException28174;
		public InvalidPreferencesFormatException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.InvalidPreferencesFormatException.staticClass, global::java.util.prefs.InvalidPreferencesFormatException._InvalidPreferencesFormatException28174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidPreferencesFormatException28175;
		public InvalidPreferencesFormatException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.InvalidPreferencesFormatException.staticClass, global::java.util.prefs.InvalidPreferencesFormatException._InvalidPreferencesFormatException28175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.InvalidPreferencesFormatException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/InvalidPreferencesFormatException"));
			global::java.util.prefs.InvalidPreferencesFormatException._InvalidPreferencesFormatException28173 = @__env.GetMethodIDNoThrow(global::java.util.prefs.InvalidPreferencesFormatException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::java.util.prefs.InvalidPreferencesFormatException._InvalidPreferencesFormatException28174 = @__env.GetMethodIDNoThrow(global::java.util.prefs.InvalidPreferencesFormatException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.prefs.InvalidPreferencesFormatException._InvalidPreferencesFormatException28175 = @__env.GetMethodIDNoThrow(global::java.util.prefs.InvalidPreferencesFormatException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
		}
	}
}
