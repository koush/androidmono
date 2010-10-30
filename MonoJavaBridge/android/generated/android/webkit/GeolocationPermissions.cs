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
			internal static global::MonoJavaBridge.MethodId _invoke16042;
			void android.webkit.GeolocationPermissions.Callback.invoke(java.lang.String arg0, bool arg1, bool arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.GeolocationPermissions.Callback_._invoke16042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static Callback_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.GeolocationPermissions.Callback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/GeolocationPermissions$Callback"));
				global::android.webkit.GeolocationPermissions.Callback_._invoke16042 = @__env.GetMethodIDNoThrow(global::android.webkit.GeolocationPermissions.Callback_.staticClass, "invoke", "(Ljava/lang/String;ZZ)V");
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
			internal static global::MonoJavaBridge.MethodId _CallbackDelegateWrapper16043;
			public CallbackDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.GeolocationPermissions.CallbackDelegateWrapper.staticClass, global::android.webkit.GeolocationPermissions.CallbackDelegateWrapper._CallbackDelegateWrapper16043);
				Init(@__env, handle);
			}
			static CallbackDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.GeolocationPermissions.CallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/GeolocationPermissions_CallbackDelegateWrapper"));
				global::android.webkit.GeolocationPermissions.CallbackDelegateWrapper._CallbackDelegateWrapper16043 = @__env.GetMethodIDNoThrow(global::android.webkit.GeolocationPermissions.CallbackDelegateWrapper.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _clear16044;
		public void clear(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._clear16044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::android.webkit.GeolocationPermissions Instance
		{
			get
			{
				return getInstance();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstance16045;
		public static global::android.webkit.GeolocationPermissions getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.GeolocationPermissions>(@__env.CallStaticObjectMethod(android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._getInstance16045)) as android.webkit.GeolocationPermissions;
		}
		internal static global::MonoJavaBridge.MethodId _allow16046;
		public void allow(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._allow16046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOrigins16047;
		public void getOrigins(android.webkit.ValueCallback arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._getOrigins16047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void getOrigins(global::android.webkit.ValueCallbackDelegate arg0)
		{
			getOrigins((global::android.webkit.ValueCallbackDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getAllowed16048;
		public void getAllowed(java.lang.String arg0, android.webkit.ValueCallback arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._getAllowed16048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void getAllowed(java.lang.String arg0, global::android.webkit.ValueCallbackDelegate arg1)
		{
			getAllowed(arg0, (global::android.webkit.ValueCallbackDelegateWrapper)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _clearAll16049;
		public void clearAll()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._clearAll16049);
		}
		internal static global::MonoJavaBridge.MethodId _GeolocationPermissions16050;
		public GeolocationPermissions() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._GeolocationPermissions16050);
			Init(@__env, handle);
		}
		static GeolocationPermissions()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.GeolocationPermissions.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/GeolocationPermissions"));
			global::android.webkit.GeolocationPermissions._clear16044 = @__env.GetMethodIDNoThrow(global::android.webkit.GeolocationPermissions.staticClass, "clear", "(Ljava/lang/String;)V");
			global::android.webkit.GeolocationPermissions._getInstance16045 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.GeolocationPermissions.staticClass, "getInstance", "()Landroid/webkit/GeolocationPermissions;");
			global::android.webkit.GeolocationPermissions._allow16046 = @__env.GetMethodIDNoThrow(global::android.webkit.GeolocationPermissions.staticClass, "allow", "(Ljava/lang/String;)V");
			global::android.webkit.GeolocationPermissions._getOrigins16047 = @__env.GetMethodIDNoThrow(global::android.webkit.GeolocationPermissions.staticClass, "getOrigins", "(Landroid/webkit/ValueCallback;)V");
			global::android.webkit.GeolocationPermissions._getAllowed16048 = @__env.GetMethodIDNoThrow(global::android.webkit.GeolocationPermissions.staticClass, "getAllowed", "(Ljava/lang/String;Landroid/webkit/ValueCallback;)V");
			global::android.webkit.GeolocationPermissions._clearAll16049 = @__env.GetMethodIDNoThrow(global::android.webkit.GeolocationPermissions.staticClass, "clearAll", "()V");
			global::android.webkit.GeolocationPermissions._GeolocationPermissions16050 = @__env.GetMethodIDNoThrow(global::android.webkit.GeolocationPermissions.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
