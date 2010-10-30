namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MimeTypeMap : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MimeTypeMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.lang.String getFileExtensionFromUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.MimeTypeMap._m0.native == global::System.IntPtr.Zero)
				global::android.webkit.MimeTypeMap._m0 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.MimeTypeMap.staticClass, "getFileExtensionFromUrl", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.webkit.MimeTypeMap.staticClass, global::android.webkit.MimeTypeMap._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool hasMimeType(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.MimeTypeMap.staticClass, "hasMimeType", "(Ljava/lang/String;)Z", ref global::android.webkit.MimeTypeMap._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getMimeTypeFromExtension(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.MimeTypeMap.staticClass, "getMimeTypeFromExtension", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.webkit.MimeTypeMap._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool hasExtension(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.MimeTypeMap.staticClass, "hasExtension", "(Ljava/lang/String;)Z", ref global::android.webkit.MimeTypeMap._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getExtensionFromMimeType(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.MimeTypeMap.staticClass, "getExtensionFromMimeType", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.webkit.MimeTypeMap._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		public static global::android.webkit.MimeTypeMap Singleton
		{
			get
			{
				return getSingleton();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::android.webkit.MimeTypeMap getSingleton()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.MimeTypeMap._m5.native == global::System.IntPtr.Zero)
				global::android.webkit.MimeTypeMap._m5 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.MimeTypeMap.staticClass, "getSingleton", "()Landroid/webkit/MimeTypeMap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.MimeTypeMap.staticClass, global::android.webkit.MimeTypeMap._m5)) as android.webkit.MimeTypeMap;
		}
		static MimeTypeMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.MimeTypeMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/MimeTypeMap"));
		}
		internal static void InitJNI()
		{
		}
	}
}
