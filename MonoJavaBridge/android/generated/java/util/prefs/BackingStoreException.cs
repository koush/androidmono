namespace java.util.prefs
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BackingStoreException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BackingStoreException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public BackingStoreException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.prefs.BackingStoreException._m0.native == global::System.IntPtr.Zero)
				global::java.util.prefs.BackingStoreException._m0 = @__env.GetMethodIDNoThrow(global::java.util.prefs.BackingStoreException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.BackingStoreException.staticClass, global::java.util.prefs.BackingStoreException._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public BackingStoreException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.prefs.BackingStoreException._m1.native == global::System.IntPtr.Zero)
				global::java.util.prefs.BackingStoreException._m1 = @__env.GetMethodIDNoThrow(global::java.util.prefs.BackingStoreException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.BackingStoreException.staticClass, global::java.util.prefs.BackingStoreException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BackingStoreException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.BackingStoreException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/BackingStoreException"));
		}
	}
}
