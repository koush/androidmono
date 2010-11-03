namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MissingResourceException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MissingResourceException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Key
		{
			get
			{
				return getKey();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.MissingResourceException.staticClass, "getKey", "()Ljava/lang/String;", ref global::java.util.MissingResourceException._m0) as java.lang.String;
		}
		public new global::java.lang.String ClassName
		{
			get
			{
				return getClassName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getClassName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.MissingResourceException.staticClass, "getClassName", "()Ljava/lang/String;", ref global::java.util.MissingResourceException._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public MissingResourceException(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.MissingResourceException._m2.native == global::System.IntPtr.Zero)
				global::java.util.MissingResourceException._m2 = @__env.GetMethodIDNoThrow(global::java.util.MissingResourceException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.MissingResourceException.staticClass, global::java.util.MissingResourceException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static MissingResourceException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.MissingResourceException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/MissingResourceException"));
		}
	}
}
