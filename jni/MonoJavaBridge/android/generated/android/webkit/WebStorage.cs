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
		public interface QuotaUpdater  : global::MonoJavaBridge.IJavaObject 
		{
			void updateQuota(long arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.webkit.WebStorage.QuotaUpdater))]
		public sealed partial class QuotaUpdater_ : java.lang.Object, QuotaUpdater
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static QuotaUpdater_()
			{
				InitJNI();
			}
			internal QuotaUpdater_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _updateQuota10546;
			 void android.webkit.WebStorage.QuotaUpdater.updateQuota(long arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebStorage.QuotaUpdater_._updateQuota10546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebStorage.QuotaUpdater_.staticClass, global::android.webkit.WebStorage.QuotaUpdater_._updateQuota10546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebStorage.QuotaUpdater_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebStorage$QuotaUpdater"));
				global::android.webkit.WebStorage.QuotaUpdater_._updateQuota10546 = @__env.GetMethodIDNoThrow(global::android.webkit.WebStorage.QuotaUpdater_.staticClass, "updateQuota", "(J)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstance10547;
		public static global::android.webkit.WebStorage getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._getInstance10547)) as android.webkit.WebStorage;
		}
		internal static global::MonoJavaBridge.MethodId _getOrigins10548;
		public void getOrigins(android.webkit.ValueCallback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebStorage._getOrigins10548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._getOrigins10548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUsageForOrigin10549;
		public void getUsageForOrigin(java.lang.String arg0, android.webkit.ValueCallback arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebStorage._getUsageForOrigin10549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._getUsageForOrigin10549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getQuotaForOrigin10550;
		public void getQuotaForOrigin(java.lang.String arg0, android.webkit.ValueCallback arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebStorage._getQuotaForOrigin10550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._getQuotaForOrigin10550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setQuotaForOrigin10551;
		public void setQuotaForOrigin(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebStorage._setQuotaForOrigin10551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._setQuotaForOrigin10551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _deleteOrigin10552;
		public void deleteOrigin(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebStorage._deleteOrigin10552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._deleteOrigin10552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteAllData10553;
		public void deleteAllData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebStorage._deleteAllData10553);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._deleteAllData10553);
		}
		internal static global::MonoJavaBridge.MethodId _WebStorage10554;
		public WebStorage()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebStorage.staticClass, global::android.webkit.WebStorage._WebStorage10554);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebStorage.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebStorage"));
			global::android.webkit.WebStorage._getInstance10547 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebStorage.staticClass, "getInstance", "()Landroid/webkit/WebStorage;");
			global::android.webkit.WebStorage._getOrigins10548 = @__env.GetMethodIDNoThrow(global::android.webkit.WebStorage.staticClass, "getOrigins", "(Landroid/webkit/ValueCallback;)V");
			global::android.webkit.WebStorage._getUsageForOrigin10549 = @__env.GetMethodIDNoThrow(global::android.webkit.WebStorage.staticClass, "getUsageForOrigin", "(Ljava/lang/String;Landroid/webkit/ValueCallback;)V");
			global::android.webkit.WebStorage._getQuotaForOrigin10550 = @__env.GetMethodIDNoThrow(global::android.webkit.WebStorage.staticClass, "getQuotaForOrigin", "(Ljava/lang/String;Landroid/webkit/ValueCallback;)V");
			global::android.webkit.WebStorage._setQuotaForOrigin10551 = @__env.GetMethodIDNoThrow(global::android.webkit.WebStorage.staticClass, "setQuotaForOrigin", "(Ljava/lang/String;J)V");
			global::android.webkit.WebStorage._deleteOrigin10552 = @__env.GetMethodIDNoThrow(global::android.webkit.WebStorage.staticClass, "deleteOrigin", "(Ljava/lang/String;)V");
			global::android.webkit.WebStorage._deleteAllData10553 = @__env.GetMethodIDNoThrow(global::android.webkit.WebStorage.staticClass, "deleteAllData", "()V");
			global::android.webkit.WebStorage._WebStorage10554 = @__env.GetMethodIDNoThrow(global::android.webkit.WebStorage.staticClass, "<init>", "()V");
		}
	}
}
