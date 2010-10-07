namespace android.webkit
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class MimeTypeMap : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static MimeTypeMap()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.MimeTypeMap), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.webkit.MimeTypeMap(@__env);
			}
		}
		protected MimeTypeMap(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFileExtensionFromUrl9981;
		public static global::java.lang.String getFileExtensionFromUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.MimeTypeMap.staticClass, global::android.webkit.MimeTypeMap._getFileExtensionFromUrl9981, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasMimeType9982;
		public virtual bool hasMimeType(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.MimeTypeMap._hasMimeType9982, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.MimeTypeMap.staticClass, global::android.webkit.MimeTypeMap._hasMimeType9982, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMimeTypeFromExtension9983;
		public virtual global::java.lang.String getMimeTypeFromExtension(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.MimeTypeMap._getMimeTypeFromExtension9983, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.MimeTypeMap.staticClass, global::android.webkit.MimeTypeMap._getMimeTypeFromExtension9983, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasExtension9984;
		public virtual bool hasExtension(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.MimeTypeMap._hasExtension9984, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.MimeTypeMap.staticClass, global::android.webkit.MimeTypeMap._hasExtension9984, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getExtensionFromMimeType9985;
		public virtual global::java.lang.String getExtensionFromMimeType(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.MimeTypeMap._getExtensionFromMimeType9985, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.MimeTypeMap.staticClass, global::android.webkit.MimeTypeMap._getExtensionFromMimeType9985, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSingleton9986;
		public static global::android.webkit.MimeTypeMap getSingleton() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.MimeTypeMap>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.MimeTypeMap.staticClass, global::android.webkit.MimeTypeMap._getSingleton9986));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.webkit.MimeTypeMap.staticClass = @__class;
			global::android.webkit.MimeTypeMap._getFileExtensionFromUrl9981 = @__env.GetStaticMethodID(global::android.webkit.MimeTypeMap.staticClass, "getFileExtensionFromUrl", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.MimeTypeMap._hasMimeType9982 = @__env.GetMethodID(global::android.webkit.MimeTypeMap.staticClass, "hasMimeType", "(Ljava/lang/String;)Z");
			global::android.webkit.MimeTypeMap._getMimeTypeFromExtension9983 = @__env.GetMethodID(global::android.webkit.MimeTypeMap.staticClass, "getMimeTypeFromExtension", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.MimeTypeMap._hasExtension9984 = @__env.GetMethodID(global::android.webkit.MimeTypeMap.staticClass, "hasExtension", "(Ljava/lang/String;)Z");
			global::android.webkit.MimeTypeMap._getExtensionFromMimeType9985 = @__env.GetMethodID(global::android.webkit.MimeTypeMap.staticClass, "getExtensionFromMimeType", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.MimeTypeMap._getSingleton9986 = @__env.GetStaticMethodID(global::android.webkit.MimeTypeMap.staticClass, "getSingleton", "()Landroid/webkit/MimeTypeMap;");
		}
	}
}
