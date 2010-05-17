namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class WebIconDatabase : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static WebIconDatabase() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.WebIconDatabase), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.webkit.WebIconDatabase(@__env); 
			} 
		} 
		internal WebIconDatabase(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface IconListener 
		{ 
			void onReceivedIcon(java.lang.String arg0, android.graphics.Bitmap arg1); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance8708; 
		public static android.webkit.WebIconDatabase getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebIconDatabase>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebIconDatabase.staticClass, _getInstance8708)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close8709; 
		public void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebIconDatabase)) 
				@__env.CallVoidMethod(this, _close8709); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebIconDatabase.staticClass, _close8709); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _open8710; 
		public void open(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebIconDatabase)) 
				@__env.CallVoidMethod(this, _open8710, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebIconDatabase.staticClass, _open8710, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAllIcons8711; 
		public void removeAllIcons() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebIconDatabase)) 
				@__env.CallVoidMethod(this, _removeAllIcons8711); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebIconDatabase.staticClass, _removeAllIcons8711); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestIconForPageUrl8712; 
		public void requestIconForPageUrl(java.lang.String arg0, android.webkit.WebIconDatabase.IconListener arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebIconDatabase)) 
				@__env.CallVoidMethod(this, _requestIconForPageUrl8712, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebIconDatabase.staticClass, _requestIconForPageUrl8712, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _retainIconForPageUrl8713; 
		public void retainIconForPageUrl(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebIconDatabase)) 
				@__env.CallVoidMethod(this, _retainIconForPageUrl8713, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebIconDatabase.staticClass, _retainIconForPageUrl8713, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _releaseIconForPageUrl8714; 
		public void releaseIconForPageUrl(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebIconDatabase)) 
				@__env.CallVoidMethod(this, _releaseIconForPageUrl8714, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebIconDatabase.staticClass, _releaseIconForPageUrl8714, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.WebIconDatabase.staticClass = @__class; 
			global::android.webkit.WebIconDatabase._getInstance8708 = @__env.GetStaticMethodID(global::android.webkit.WebIconDatabase.staticClass, "getInstance", "()Landroid/webkit/WebIconDatabase;"); 
			global::android.webkit.WebIconDatabase._close8709 = @__env.GetMethodID(global::android.webkit.WebIconDatabase.staticClass, "close", "()V"); 
			global::android.webkit.WebIconDatabase._open8710 = @__env.GetMethodID(global::android.webkit.WebIconDatabase.staticClass, "open", "(Ljava/lang/String;)V"); 
			global::android.webkit.WebIconDatabase._removeAllIcons8711 = @__env.GetMethodID(global::android.webkit.WebIconDatabase.staticClass, "removeAllIcons", "()V"); 
			global::android.webkit.WebIconDatabase._requestIconForPageUrl8712 = @__env.GetMethodID(global::android.webkit.WebIconDatabase.staticClass, "requestIconForPageUrl", "(Ljava/lang/String;Landroid/webkit/WebIconDatabase$IconListener;)V"); 
			global::android.webkit.WebIconDatabase._retainIconForPageUrl8713 = @__env.GetMethodID(global::android.webkit.WebIconDatabase.staticClass, "retainIconForPageUrl", "(Ljava/lang/String;)V"); 
			global::android.webkit.WebIconDatabase._releaseIconForPageUrl8714 = @__env.GetMethodID(global::android.webkit.WebIconDatabase.staticClass, "releaseIconForPageUrl", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
