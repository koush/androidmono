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
		internal static global::MonoJavaBridge.MethodId _getKey26522;
		public virtual global::java.lang.String getKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.MissingResourceException.staticClass, "getKey", "()Ljava/lang/String;", ref global::java.util.MissingResourceException._getKey26522) as java.lang.String;
		}
		public new global::java.lang.String ClassName
		{
			get
			{
				return getClassName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClassName26523;
		public virtual global::java.lang.String getClassName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.MissingResourceException.staticClass, "getClassName", "()Ljava/lang/String;", ref global::java.util.MissingResourceException._getClassName26523) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _MissingResourceException26524;
		public MissingResourceException(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.MissingResourceException._MissingResourceException26524.native == global::System.IntPtr.Zero)
				global::java.util.MissingResourceException._MissingResourceException26524 = @__env.GetMethodIDNoThrow(global::java.util.MissingResourceException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.MissingResourceException.staticClass, global::java.util.MissingResourceException._MissingResourceException26524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static MissingResourceException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.MissingResourceException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/MissingResourceException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
