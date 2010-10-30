namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class GeolocationPermissions : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal GeolocationPermissions(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.webkit.GeolocationPermissions.Callback_))]
		public partial interface Callback  : global::MonoJavaBridge.IJavaObject 
		{
			void invoke(java.lang.String arg0, bool arg1, bool arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.webkit.GeolocationPermissions.Callback))]
		internal sealed partial class Callback_ : java.lang.Object, Callback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Callback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.webkit.GeolocationPermissions.Callback.invoke(java.lang.String arg0, bool arg1, bool arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.GeolocationPermissions.Callback_.staticClass, "invoke", "(Ljava/lang/String;ZZ)V", ref global::android.webkit.GeolocationPermissions.Callback_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static Callback_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.GeolocationPermissions.Callback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/GeolocationPermissions$Callback"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void CallbackDelegate(java.lang.String arg0, bool arg1, bool arg2);

		internal partial class CallbackDelegateWrapper : java.lang.Object, Callback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected CallbackDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public CallbackDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.webkit.GeolocationPermissions.CallbackDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.webkit.GeolocationPermissions.CallbackDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.webkit.GeolocationPermissions.CallbackDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.GeolocationPermissions.CallbackDelegateWrapper.staticClass, global::android.webkit.GeolocationPermissions.CallbackDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static CallbackDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.GeolocationPermissions.CallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/GeolocationPermissions_CallbackDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class CallbackDelegateWrapper
		{
			private CallbackDelegate myDelegate;
			public void invoke(java.lang.String arg0, bool arg1, bool arg2)
			{
				myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator CallbackDelegateWrapper(CallbackDelegate d)
			{
				global::android.webkit.GeolocationPermissions.CallbackDelegateWrapper ret = new global::android.webkit.GeolocationPermissions.CallbackDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public void clear(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.GeolocationPermissions.staticClass, "clear", "(Ljava/lang/String;)V", ref global::android.webkit.GeolocationPermissions._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::android.webkit.GeolocationPermissions Instance
		{
			get
			{
				return getInstance();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::android.webkit.GeolocationPermissions getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.GeolocationPermissions._m1.native == global::System.IntPtr.Zero)
				global::android.webkit.GeolocationPermissions._m1 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.GeolocationPermissions.staticClass, "getInstance", "()Landroid/webkit/GeolocationPermissions;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.GeolocationPermissions>(@__env.CallStaticObjectMethod(android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._m1)) as android.webkit.GeolocationPermissions;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void allow(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.GeolocationPermissions.staticClass, "allow", "(Ljava/lang/String;)V", ref global::android.webkit.GeolocationPermissions._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public void getOrigins(android.webkit.ValueCallback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.GeolocationPermissions.staticClass, "getOrigins", "(Landroid/webkit/ValueCallback;)V", ref global::android.webkit.GeolocationPermissions._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void getOrigins(global::android.webkit.ValueCallbackDelegate arg0)
		{
			getOrigins((global::android.webkit.ValueCallbackDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public void getAllowed(java.lang.String arg0, android.webkit.ValueCallback arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.GeolocationPermissions.staticClass, "getAllowed", "(Ljava/lang/String;Landroid/webkit/ValueCallback;)V", ref global::android.webkit.GeolocationPermissions._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void getAllowed(java.lang.String arg0, global::android.webkit.ValueCallbackDelegate arg1)
		{
			getAllowed(arg0, (global::android.webkit.ValueCallbackDelegateWrapper)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public void clearAll()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.GeolocationPermissions.staticClass, "clearAll", "()V", ref global::android.webkit.GeolocationPermissions._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public GeolocationPermissions() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.GeolocationPermissions._m6.native == global::System.IntPtr.Zero)
				global::android.webkit.GeolocationPermissions._m6 = @__env.GetMethodIDNoThrow(global::android.webkit.GeolocationPermissions.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._m6);
			Init(@__env, handle);
		}
		static GeolocationPermissions()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.GeolocationPermissions.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/GeolocationPermissions"));
		}
		internal static void InitJNI()
		{
		}
	}
}
