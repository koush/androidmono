namespace android.webkit
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class WebStorage : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static WebStorage()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.WebStorage), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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

		public partial class QuotaUpdater_
		{
			public static global::java.lang.Class _class
			{
				get { return __QuotaUpdater.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __QuotaUpdater : java.lang.Object, QuotaUpdater
		{
			internal static global::java.lang.Class staticClass;
			static __QuotaUpdater()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.WebStorage.__QuotaUpdater), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.webkit.WebStorage.__QuotaUpdater(@__env);
				}
			}
			internal __QuotaUpdater(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _updateQuota10199;
			 void android.webkit.WebStorage.QuotaUpdater.updateQuota(long arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.webkit.WebStorage.__QuotaUpdater._updateQuota10199, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebStorage.__QuotaUpdater.staticClass, global::android.webkit.WebStorage.__QuotaUpdater._updateQuota10199, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.webkit.WebStorage.__QuotaUpdater.staticClass = @__class;
				global::android.webkit.WebStorage.__QuotaUpdater._updateQuota10199 = @__env.GetMethodID(global::android.webkit.WebStorage.__QuotaUpdater.staticClass, "android.webkit.WebStorage.QuotaUpdater.updateQuota", "(J)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance10200;
		public static global::android.webkit.WebStorage getInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebStorage>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._getInstance10200));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOrigins10201;
		public void getOrigins(android.webkit.ValueCallback arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebStorage._getOrigins10201, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._getOrigins10201, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUsageForOrigin10202;
		public void getUsageForOrigin(java.lang.String arg0, android.webkit.ValueCallback arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebStorage._getUsageForOrigin10202, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._getUsageForOrigin10202, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getQuotaForOrigin10203;
		public void getQuotaForOrigin(java.lang.String arg0, android.webkit.ValueCallback arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebStorage._getQuotaForOrigin10203, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._getQuotaForOrigin10203, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setQuotaForOrigin10204;
		public void setQuotaForOrigin(java.lang.String arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebStorage._setQuotaForOrigin10204, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._setQuotaForOrigin10204, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _deleteOrigin10205;
		public void deleteOrigin(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebStorage._deleteOrigin10205, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._deleteOrigin10205, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _deleteAllData10206;
		public void deleteAllData() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebStorage._deleteAllData10206);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._deleteAllData10206);
		}
		internal static global::net.sf.jni4net.jni.MethodId _WebStorage10207;
		public WebStorage()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._WebStorage10207, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.webkit.WebStorage.staticClass = @__class;
			global::android.webkit.WebStorage._getInstance10200 = @__env.GetStaticMethodID(global::android.webkit.WebStorage.staticClass, "getInstance", "()Landroid/webkit/WebStorage;");
			global::android.webkit.WebStorage._getOrigins10201 = @__env.GetMethodID(global::android.webkit.WebStorage.staticClass, "getOrigins", "(Landroid/webkit/ValueCallback;)V");
			global::android.webkit.WebStorage._getUsageForOrigin10202 = @__env.GetMethodID(global::android.webkit.WebStorage.staticClass, "getUsageForOrigin", "(Ljava/lang/String;Landroid/webkit/ValueCallback;)V");
			global::android.webkit.WebStorage._getQuotaForOrigin10203 = @__env.GetMethodID(global::android.webkit.WebStorage.staticClass, "getQuotaForOrigin", "(Ljava/lang/String;Landroid/webkit/ValueCallback;)V");
			global::android.webkit.WebStorage._setQuotaForOrigin10204 = @__env.GetMethodID(global::android.webkit.WebStorage.staticClass, "setQuotaForOrigin", "(Ljava/lang/String;J)V");
			global::android.webkit.WebStorage._deleteOrigin10205 = @__env.GetMethodID(global::android.webkit.WebStorage.staticClass, "deleteOrigin", "(Ljava/lang/String;)V");
			global::android.webkit.WebStorage._deleteAllData10206 = @__env.GetMethodID(global::android.webkit.WebStorage.staticClass, "deleteAllData", "()V");
			global::android.webkit.WebStorage._WebStorage10207 = @__env.GetMethodID(global::android.webkit.WebStorage.staticClass, "<init>", "()V");
		}
	}
}
