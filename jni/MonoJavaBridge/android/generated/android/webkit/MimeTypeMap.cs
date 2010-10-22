namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MimeTypeMap : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MimeTypeMap()
		{
			InitJNI();
		}
		protected MimeTypeMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getFileExtensionFromUrl15974;
		public static global::java.lang.String getFileExtensionFromUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.webkit.MimeTypeMap.staticClass, global::android.webkit.MimeTypeMap._getFileExtensionFromUrl15974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasMimeType15975;
		public virtual bool hasMimeType(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.MimeTypeMap._hasMimeType15975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.MimeTypeMap.staticClass, global::android.webkit.MimeTypeMap._hasMimeType15975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMimeTypeFromExtension15976;
		public virtual global::java.lang.String getMimeTypeFromExtension(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.MimeTypeMap._getMimeTypeFromExtension15976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.MimeTypeMap.staticClass, global::android.webkit.MimeTypeMap._getMimeTypeFromExtension15976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasExtension15977;
		public virtual bool hasExtension(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.MimeTypeMap._hasExtension15977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.MimeTypeMap.staticClass, global::android.webkit.MimeTypeMap._hasExtension15977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getExtensionFromMimeType15978;
		public virtual global::java.lang.String getExtensionFromMimeType(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.MimeTypeMap._getExtensionFromMimeType15978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.MimeTypeMap.staticClass, global::android.webkit.MimeTypeMap._getExtensionFromMimeType15978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public static global::android.webkit.MimeTypeMap Singleton
		{
			get
			{
				return getSingleton();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSingleton15979;
		public static global::android.webkit.MimeTypeMap getSingleton() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.MimeTypeMap.staticClass, global::android.webkit.MimeTypeMap._getSingleton15979)) as android.webkit.MimeTypeMap;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.MimeTypeMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/MimeTypeMap"));
			global::android.webkit.MimeTypeMap._getFileExtensionFromUrl15974 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.MimeTypeMap.staticClass, "getFileExtensionFromUrl", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.MimeTypeMap._hasMimeType15975 = @__env.GetMethodIDNoThrow(global::android.webkit.MimeTypeMap.staticClass, "hasMimeType", "(Ljava/lang/String;)Z");
			global::android.webkit.MimeTypeMap._getMimeTypeFromExtension15976 = @__env.GetMethodIDNoThrow(global::android.webkit.MimeTypeMap.staticClass, "getMimeTypeFromExtension", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.MimeTypeMap._hasExtension15977 = @__env.GetMethodIDNoThrow(global::android.webkit.MimeTypeMap.staticClass, "hasExtension", "(Ljava/lang/String;)Z");
			global::android.webkit.MimeTypeMap._getExtensionFromMimeType15978 = @__env.GetMethodIDNoThrow(global::android.webkit.MimeTypeMap.staticClass, "getExtensionFromMimeType", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.MimeTypeMap._getSingleton15979 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.MimeTypeMap.staticClass, "getSingleton", "()Landroid/webkit/MimeTypeMap;");
		}
	}
}
