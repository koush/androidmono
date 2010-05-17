namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class WebStorage : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static WebStorage() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.WebStorage), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.webkit.WebStorage(@__env); 
			} 
		} 
		internal WebStorage(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface QuotaUpdater 
		{ 
			void updateQuota(long arg0); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance8818; 
		public static android.webkit.WebStorage getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebStorage>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebStorage.staticClass, _getInstance8818)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOrigins8819; 
		public void getOrigins(android.webkit.ValueCallback arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebStorage)) 
				@__env.CallVoidMethod(this, _getOrigins8819, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebStorage.staticClass, _getOrigins8819, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUsageForOrigin8820; 
		public void getUsageForOrigin(java.lang.String arg0, android.webkit.ValueCallback arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebStorage)) 
				@__env.CallVoidMethod(this, _getUsageForOrigin8820, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebStorage.staticClass, _getUsageForOrigin8820, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getQuotaForOrigin8821; 
		public void getQuotaForOrigin(java.lang.String arg0, android.webkit.ValueCallback arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebStorage)) 
				@__env.CallVoidMethod(this, _getQuotaForOrigin8821, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebStorage.staticClass, _getQuotaForOrigin8821, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setQuotaForOrigin8822; 
		public void setQuotaForOrigin(java.lang.String arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebStorage)) 
				@__env.CallVoidMethod(this, _setQuotaForOrigin8822, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebStorage.staticClass, _setQuotaForOrigin8822, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deleteOrigin8823; 
		public void deleteOrigin(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebStorage)) 
				@__env.CallVoidMethod(this, _deleteOrigin8823, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebStorage.staticClass, _deleteOrigin8823, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deleteAllData8824; 
		public void deleteAllData() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebStorage)) 
				@__env.CallVoidMethod(this, _deleteAllData8824); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebStorage.staticClass, _deleteAllData8824); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _WebStorage8825; 
		public WebStorage()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.WebStorage.staticClass, _WebStorage8825, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.WebStorage.staticClass = @__class; 
			global::android.webkit.WebStorage._getInstance8818 = @__env.GetStaticMethodID(global::android.webkit.WebStorage.staticClass, "getInstance", "()Landroid/webkit/WebStorage;"); 
			global::android.webkit.WebStorage._getOrigins8819 = @__env.GetMethodID(global::android.webkit.WebStorage.staticClass, "getOrigins", "(Landroid/webkit/ValueCallback;)V"); 
			global::android.webkit.WebStorage._getUsageForOrigin8820 = @__env.GetMethodID(global::android.webkit.WebStorage.staticClass, "getUsageForOrigin", "(Ljava/lang/String;Landroid/webkit/ValueCallback;)V"); 
			global::android.webkit.WebStorage._getQuotaForOrigin8821 = @__env.GetMethodID(global::android.webkit.WebStorage.staticClass, "getQuotaForOrigin", "(Ljava/lang/String;Landroid/webkit/ValueCallback;)V"); 
			global::android.webkit.WebStorage._setQuotaForOrigin8822 = @__env.GetMethodID(global::android.webkit.WebStorage.staticClass, "setQuotaForOrigin", "(Ljava/lang/String;J)V"); 
			global::android.webkit.WebStorage._deleteOrigin8823 = @__env.GetMethodID(global::android.webkit.WebStorage.staticClass, "deleteOrigin", "(Ljava/lang/String;)V"); 
			global::android.webkit.WebStorage._deleteAllData8824 = @__env.GetMethodID(global::android.webkit.WebStorage.staticClass, "deleteAllData", "()V"); 
			global::android.webkit.WebStorage._WebStorage8825 = @__env.GetMethodID(global::android.webkit.WebStorage.staticClass, "<init>", "()V"); 
		} 
	} 
} 
