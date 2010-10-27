namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class WebStorage : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WebStorage()
		{
			InitJNI();
		}
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
			static QuotaUpdater_()
			{
				InitJNI();
			}
			internal QuotaUpdater_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _updateQuota16286;
			void android.webkit.WebStorage.QuotaUpdater.updateQuota(long arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebStorage.QuotaUpdater_._updateQuota16286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebStorage.QuotaUpdater_.staticClass, global::android.webkit.WebStorage.QuotaUpdater_._updateQuota16286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebStorage.QuotaUpdater_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebStorage$QuotaUpdater"));
				global::android.webkit.WebStorage.QuotaUpdater_._updateQuota16286 = @__env.GetMethodIDNoThrow(global::android.webkit.WebStorage.QuotaUpdater_.staticClass, "updateQuota", "(J)V");
			}
		}

		public delegate void QuotaUpdaterDelegate(long arg0);

		internal partial class QuotaUpdaterDelegateWrapper : java.lang.Object, QuotaUpdater
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static QuotaUpdaterDelegateWrapper()
			{
				InitJNI();
			}
			protected QuotaUpdaterDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _QuotaUpdaterDelegateWrapper16287;
			public QuotaUpdaterDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebStorage.QuotaUpdaterDelegateWrapper.staticClass, global::android.webkit.WebStorage.QuotaUpdaterDelegateWrapper._QuotaUpdaterDelegateWrapper16287);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebStorage.QuotaUpdaterDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebStorage_QuotaUpdaterDelegateWrapper"));
				global::android.webkit.WebStorage.QuotaUpdaterDelegateWrapper._QuotaUpdaterDelegateWrapper16287 = @__env.GetMethodIDNoThrow(global::android.webkit.WebStorage.QuotaUpdaterDelegateWrapper.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _getInstance16288;
		public static global::android.webkit.WebStorage getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebStorage>(@__env.CallStaticObjectMethod(android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._getInstance16288)) as android.webkit.WebStorage;
		}
		internal static global::MonoJavaBridge.MethodId _getOrigins16289;
		public void getOrigins(android.webkit.ValueCallback arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebStorage._getOrigins16289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._getOrigins16289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void getOrigins(global::android.webkit.ValueCallbackDelegate arg0)
		{
			getOrigins((global::android.webkit.ValueCallbackDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getUsageForOrigin16290;
		public void getUsageForOrigin(java.lang.String arg0, android.webkit.ValueCallback arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebStorage._getUsageForOrigin16290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._getUsageForOrigin16290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void getUsageForOrigin(java.lang.String arg0, global::android.webkit.ValueCallbackDelegate arg1)
		{
			getUsageForOrigin(arg0, (global::android.webkit.ValueCallbackDelegateWrapper)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _getQuotaForOrigin16291;
		public void getQuotaForOrigin(java.lang.String arg0, android.webkit.ValueCallback arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebStorage._getQuotaForOrigin16291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._getQuotaForOrigin16291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void getQuotaForOrigin(java.lang.String arg0, global::android.webkit.ValueCallbackDelegate arg1)
		{
			getQuotaForOrigin(arg0, (global::android.webkit.ValueCallbackDelegateWrapper)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setQuotaForOrigin16292;
		public void setQuotaForOrigin(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebStorage._setQuotaForOrigin16292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._setQuotaForOrigin16292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _deleteOrigin16293;
		public void deleteOrigin(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebStorage._deleteOrigin16293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._deleteOrigin16293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteAllData16294;
		public void deleteAllData()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebStorage._deleteAllData16294);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._deleteAllData16294);
		}
		internal static global::MonoJavaBridge.MethodId _WebStorage16295;
		public WebStorage() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._WebStorage16295);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebStorage.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebStorage"));
			global::android.webkit.WebStorage._getInstance16288 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebStorage.staticClass, "getInstance", "()Landroid/webkit/WebStorage;");
			global::android.webkit.WebStorage._getOrigins16289 = @__env.GetMethodIDNoThrow(global::android.webkit.WebStorage.staticClass, "getOrigins", "(Landroid/webkit/ValueCallback;)V");
			global::android.webkit.WebStorage._getUsageForOrigin16290 = @__env.GetMethodIDNoThrow(global::android.webkit.WebStorage.staticClass, "getUsageForOrigin", "(Ljava/lang/String;Landroid/webkit/ValueCallback;)V");
			global::android.webkit.WebStorage._getQuotaForOrigin16291 = @__env.GetMethodIDNoThrow(global::android.webkit.WebStorage.staticClass, "getQuotaForOrigin", "(Ljava/lang/String;Landroid/webkit/ValueCallback;)V");
			global::android.webkit.WebStorage._setQuotaForOrigin16292 = @__env.GetMethodIDNoThrow(global::android.webkit.WebStorage.staticClass, "setQuotaForOrigin", "(Ljava/lang/String;J)V");
			global::android.webkit.WebStorage._deleteOrigin16293 = @__env.GetMethodIDNoThrow(global::android.webkit.WebStorage.staticClass, "deleteOrigin", "(Ljava/lang/String;)V");
			global::android.webkit.WebStorage._deleteAllData16294 = @__env.GetMethodIDNoThrow(global::android.webkit.WebStorage.staticClass, "deleteAllData", "()V");
			global::android.webkit.WebStorage._WebStorage16295 = @__env.GetMethodIDNoThrow(global::android.webkit.WebStorage.staticClass, "<init>", "()V");
		}
	}
}
