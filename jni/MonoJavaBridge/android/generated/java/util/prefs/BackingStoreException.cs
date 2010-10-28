namespace java.util.prefs
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BackingStoreException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BackingStoreException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _BackingStoreException28172;
		public BackingStoreException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.BackingStoreException.staticClass, global::java.util.prefs.BackingStoreException._BackingStoreException28172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BackingStoreException28173;
		public BackingStoreException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.BackingStoreException.staticClass, global::java.util.prefs.BackingStoreException._BackingStoreException28173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BackingStoreException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.BackingStoreException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/BackingStoreException"));
			global::java.util.prefs.BackingStoreException._BackingStoreException28172 = @__env.GetMethodIDNoThrow(global::java.util.prefs.BackingStoreException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.prefs.BackingStoreException._BackingStoreException28173 = @__env.GetMethodIDNoThrow(global::java.util.prefs.BackingStoreException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
