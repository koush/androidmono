namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MissingResourceException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MissingResourceException()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getKey26521;
		public virtual global::java.lang.String getKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.MissingResourceException._getKey26521)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.MissingResourceException.staticClass, global::java.util.MissingResourceException._getKey26521)) as java.lang.String;
		}
		public new global::java.lang.String ClassName
		{
			get
			{
				return getClassName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClassName26522;
		public virtual global::java.lang.String getClassName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.MissingResourceException._getClassName26522)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.MissingResourceException.staticClass, global::java.util.MissingResourceException._getClassName26522)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _MissingResourceException26523;
		public MissingResourceException(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.MissingResourceException.staticClass, global::java.util.MissingResourceException._MissingResourceException26523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.MissingResourceException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/MissingResourceException"));
			global::java.util.MissingResourceException._getKey26521 = @__env.GetMethodIDNoThrow(global::java.util.MissingResourceException.staticClass, "getKey", "()Ljava/lang/String;");
			global::java.util.MissingResourceException._getClassName26522 = @__env.GetMethodIDNoThrow(global::java.util.MissingResourceException.staticClass, "getClassName", "()Ljava/lang/String;");
			global::java.util.MissingResourceException._MissingResourceException26523 = @__env.GetMethodIDNoThrow(global::java.util.MissingResourceException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
