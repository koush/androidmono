namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MimeTypeMap : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MimeTypeMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getFileExtensionFromUrl16059;
		public static global::java.lang.String getFileExtensionFromUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.MimeTypeMap._getFileExtensionFromUrl16059.native == global::System.IntPtr.Zero)
				global::android.webkit.MimeTypeMap._getFileExtensionFromUrl16059 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.MimeTypeMap.staticClass, "getFileExtensionFromUrl", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.webkit.MimeTypeMap.staticClass, global::android.webkit.MimeTypeMap._getFileExtensionFromUrl16059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasMimeType16060;
		public virtual bool hasMimeType(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.MimeTypeMap._hasMimeType16060.native == global::System.IntPtr.Zero)
				global::android.webkit.MimeTypeMap._hasMimeType16060 = @__env.GetMethodIDNoThrow(global::android.webkit.MimeTypeMap.staticClass, "hasMimeType", "(Ljava/lang/String;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.MimeTypeMap.staticClass, global::android.webkit.MimeTypeMap._hasMimeType16060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMimeTypeFromExtension16061;
		public virtual global::java.lang.String getMimeTypeFromExtension(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.MimeTypeMap._getMimeTypeFromExtension16061.native == global::System.IntPtr.Zero)
				global::android.webkit.MimeTypeMap._getMimeTypeFromExtension16061 = @__env.GetMethodIDNoThrow(global::android.webkit.MimeTypeMap.staticClass, "getMimeTypeFromExtension", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.MimeTypeMap.staticClass, global::android.webkit.MimeTypeMap._getMimeTypeFromExtension16061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasExtension16062;
		public virtual bool hasExtension(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.MimeTypeMap._hasExtension16062.native == global::System.IntPtr.Zero)
				global::android.webkit.MimeTypeMap._hasExtension16062 = @__env.GetMethodIDNoThrow(global::android.webkit.MimeTypeMap.staticClass, "hasExtension", "(Ljava/lang/String;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.MimeTypeMap.staticClass, global::android.webkit.MimeTypeMap._hasExtension16062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getExtensionFromMimeType16063;
		public virtual global::java.lang.String getExtensionFromMimeType(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.MimeTypeMap._getExtensionFromMimeType16063.native == global::System.IntPtr.Zero)
				global::android.webkit.MimeTypeMap._getExtensionFromMimeType16063 = @__env.GetMethodIDNoThrow(global::android.webkit.MimeTypeMap.staticClass, "getExtensionFromMimeType", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.MimeTypeMap.staticClass, global::android.webkit.MimeTypeMap._getExtensionFromMimeType16063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		public static global::android.webkit.MimeTypeMap Singleton
		{
			get
			{
				return getSingleton();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSingleton16064;
		public static global::android.webkit.MimeTypeMap getSingleton()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.MimeTypeMap._getSingleton16064.native == global::System.IntPtr.Zero)
				global::android.webkit.MimeTypeMap._getSingleton16064 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.MimeTypeMap.staticClass, "getSingleton", "()Landroid/webkit/MimeTypeMap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.MimeTypeMap.staticClass, global::android.webkit.MimeTypeMap._getSingleton16064)) as android.webkit.MimeTypeMap;
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
