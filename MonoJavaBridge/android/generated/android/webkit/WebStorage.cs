namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class WebStorage : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal WebStorage(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.webkit.WebStorage.QuotaUpdater_))]
		public partial interface QuotaUpdater  : global::MonoJavaBridge.IJavaObject 
		{
			void updateQuota(long arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.webkit.WebStorage.QuotaUpdater))]
		internal sealed partial class QuotaUpdater_ : java.lang.Object, QuotaUpdater
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal QuotaUpdater_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.webkit.WebStorage.QuotaUpdater.updateQuota(long arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebStorage.QuotaUpdater_.staticClass, "updateQuota", "(J)V", ref global::android.webkit.WebStorage.QuotaUpdater_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static QuotaUpdater_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebStorage.QuotaUpdater_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebStorage$QuotaUpdater"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void QuotaUpdaterDelegate(long arg0);

		internal partial class QuotaUpdaterDelegateWrapper : java.lang.Object, QuotaUpdater
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected QuotaUpdaterDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public QuotaUpdaterDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.webkit.WebStorage.QuotaUpdaterDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.webkit.WebStorage.QuotaUpdaterDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.webkit.WebStorage.QuotaUpdaterDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebStorage.QuotaUpdaterDelegateWrapper.staticClass, global::android.webkit.WebStorage.QuotaUpdaterDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static QuotaUpdaterDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebStorage.QuotaUpdaterDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebStorage_QuotaUpdaterDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class QuotaUpdaterDelegateWrapper
		{
			private QuotaUpdaterDelegate myDelegate;
			public void updateQuota(long arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator QuotaUpdaterDelegateWrapper(QuotaUpdaterDelegate d)
			{
				global::android.webkit.WebStorage.QuotaUpdaterDelegateWrapper ret = new global::android.webkit.WebStorage.QuotaUpdaterDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		public static global::android.webkit.WebStorage Instance
		{
			get
			{
				return getInstance();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.webkit.WebStorage getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebStorage._m0.native == global::System.IntPtr.Zero)
				global::android.webkit.WebStorage._m0 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebStorage.staticClass, "getInstance", "()Landroid/webkit/WebStorage;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebStorage>(@__env.CallStaticObjectMethod(android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._m0)) as android.webkit.WebStorage;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public void getOrigins(android.webkit.ValueCallback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebStorage.staticClass, "getOrigins", "(Landroid/webkit/ValueCallback;)V", ref global::android.webkit.WebStorage._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void getOrigins(global::android.webkit.ValueCallbackDelegate arg0)
		{
			getOrigins((global::android.webkit.ValueCallbackDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void getUsageForOrigin(java.lang.String arg0, android.webkit.ValueCallback arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebStorage.staticClass, "getUsageForOrigin", "(Ljava/lang/String;Landroid/webkit/ValueCallback;)V", ref global::android.webkit.WebStorage._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void getUsageForOrigin(java.lang.String arg0, global::android.webkit.ValueCallbackDelegate arg1)
		{
			getUsageForOrigin(arg0, (global::android.webkit.ValueCallbackDelegateWrapper)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public void getQuotaForOrigin(java.lang.String arg0, android.webkit.ValueCallback arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebStorage.staticClass, "getQuotaForOrigin", "(Ljava/lang/String;Landroid/webkit/ValueCallback;)V", ref global::android.webkit.WebStorage._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void getQuotaForOrigin(java.lang.String arg0, global::android.webkit.ValueCallbackDelegate arg1)
		{
			getQuotaForOrigin(arg0, (global::android.webkit.ValueCallbackDelegateWrapper)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public void setQuotaForOrigin(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebStorage.staticClass, "setQuotaForOrigin", "(Ljava/lang/String;J)V", ref global::android.webkit.WebStorage._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public void deleteOrigin(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebStorage.staticClass, "deleteOrigin", "(Ljava/lang/String;)V", ref global::android.webkit.WebStorage._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public void deleteAllData()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebStorage.staticClass, "deleteAllData", "()V", ref global::android.webkit.WebStorage._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public WebStorage() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebStorage._m7.native == global::System.IntPtr.Zero)
				global::android.webkit.WebStorage._m7 = @__env.GetMethodIDNoThrow(global::android.webkit.WebStorage.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._m7);
			Init(@__env, handle);
		}
		static WebStorage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebStorage.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebStorage"));
		}
		internal static void InitJNI()
		{
		}
	}
}
