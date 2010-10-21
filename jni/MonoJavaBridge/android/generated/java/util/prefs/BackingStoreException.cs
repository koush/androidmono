namespace java.util.prefs
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BackingStoreException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BackingStoreException()
		{
			InitJNI();
		}
		protected BackingStoreException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _BackingStoreException28053;
		public BackingStoreException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.BackingStoreException.staticClass, global::java.util.prefs.BackingStoreException._BackingStoreException28053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BackingStoreException28054;
		public BackingStoreException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.BackingStoreException.staticClass, global::java.util.prefs.BackingStoreException._BackingStoreException28054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.BackingStoreException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/BackingStoreException"));
			global::java.util.prefs.BackingStoreException._BackingStoreException28053 = @__env.GetMethodIDNoThrow(global::java.util.prefs.BackingStoreException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.prefs.BackingStoreException._BackingStoreException28054 = @__env.GetMethodIDNoThrow(global::java.util.prefs.BackingStoreException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
