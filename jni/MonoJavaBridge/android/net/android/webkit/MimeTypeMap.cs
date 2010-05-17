namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class MimeTypeMap : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static MimeTypeMap() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.MimeTypeMap), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getFileExtensionFromUrl8618; 
		public static java.lang.String getFileExtensionFromUrl(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.MimeTypeMap.staticClass, _getFileExtensionFromUrl8618, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasMimeType8619; 
		public virtual bool hasMimeType(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.MimeTypeMap)) 
				return @__env.CallBooleanMethod(this, _hasMimeType8619, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.MimeTypeMap.staticClass, _hasMimeType8619, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMimeTypeFromExtension8620; 
		public virtual java.lang.String getMimeTypeFromExtension(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.MimeTypeMap)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getMimeTypeFromExtension8620, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.MimeTypeMap.staticClass, _getMimeTypeFromExtension8620, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasExtension8621; 
		public virtual bool hasExtension(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.MimeTypeMap)) 
				return @__env.CallBooleanMethod(this, _hasExtension8621, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.MimeTypeMap.staticClass, _hasExtension8621, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExtensionFromMimeType8622; 
		public virtual java.lang.String getExtensionFromMimeType(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.MimeTypeMap)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getExtensionFromMimeType8622, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.MimeTypeMap.staticClass, _getExtensionFromMimeType8622, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSingleton8623; 
		public static android.webkit.MimeTypeMap getSingleton() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.MimeTypeMap>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.MimeTypeMap.staticClass, _getSingleton8623)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.MimeTypeMap.staticClass = @__class; 
			global::android.webkit.MimeTypeMap._getFileExtensionFromUrl8618 = @__env.GetStaticMethodID(global::android.webkit.MimeTypeMap.staticClass, "getFileExtensionFromUrl", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.webkit.MimeTypeMap._hasMimeType8619 = @__env.GetMethodID(global::android.webkit.MimeTypeMap.staticClass, "hasMimeType", "(Ljava/lang/String;)Z"); 
			global::android.webkit.MimeTypeMap._getMimeTypeFromExtension8620 = @__env.GetMethodID(global::android.webkit.MimeTypeMap.staticClass, "getMimeTypeFromExtension", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.webkit.MimeTypeMap._hasExtension8621 = @__env.GetMethodID(global::android.webkit.MimeTypeMap.staticClass, "hasExtension", "(Ljava/lang/String;)Z"); 
			global::android.webkit.MimeTypeMap._getExtensionFromMimeType8622 = @__env.GetMethodID(global::android.webkit.MimeTypeMap.staticClass, "getExtensionFromMimeType", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.webkit.MimeTypeMap._getSingleton8623 = @__env.GetStaticMethodID(global::android.webkit.MimeTypeMap.staticClass, "getSingleton", "()Landroid/webkit/MimeTypeMap;"); 
		} 
	} 
} 
