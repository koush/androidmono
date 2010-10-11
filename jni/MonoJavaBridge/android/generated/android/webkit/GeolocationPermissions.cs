namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class GeolocationPermissions : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GeolocationPermissions()
		{
			InitJNI();
		}
		internal GeolocationPermissions(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.webkit.GeolocationPermissions.Callback_))]
		public interface Callback  : global::MonoJavaBridge.IJavaObject 
		{
			void invoke(java.lang.String arg0, bool arg1, bool arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.webkit.GeolocationPermissions.Callback))]
		public sealed partial class Callback_ : java.lang.Object, Callback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Callback_()
			{
				InitJNI();
			}
			internal Callback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _invoke10312;
			 void android.webkit.GeolocationPermissions.Callback.invoke(java.lang.String arg0, bool arg1, bool arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.GeolocationPermissions.Callback_._invoke10312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.GeolocationPermissions.Callback_.staticClass, global::android.webkit.GeolocationPermissions.Callback_._invoke10312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.GeolocationPermissions.Callback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/GeolocationPermissions$Callback"));
				global::android.webkit.GeolocationPermissions.Callback_._invoke10312 = @__env.GetMethodIDNoThrow(global::android.webkit.GeolocationPermissions.Callback_.staticClass, "invoke", "(Ljava/lang/String;ZZ)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _clear10313;
		public void clear(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.GeolocationPermissions._clear10313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._clear10313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInstance10314;
		public static global::android.webkit.GeolocationPermissions getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._getInstance10314)) as android.webkit.GeolocationPermissions;
		}
		internal static global::MonoJavaBridge.MethodId _allow10315;
		public void allow(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.GeolocationPermissions._allow10315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._allow10315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOrigins10316;
		public void getOrigins(android.webkit.ValueCallback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.GeolocationPermissions._getOrigins10316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._getOrigins10316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAllowed10317;
		public void getAllowed(java.lang.String arg0, android.webkit.ValueCallback arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.GeolocationPermissions._getAllowed10317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._getAllowed10317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clearAll10318;
		public void clearAll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.GeolocationPermissions._clearAll10318);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._clearAll10318);
		}
		internal static global::MonoJavaBridge.MethodId _GeolocationPermissions10319;
		public GeolocationPermissions()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._GeolocationPermissions10319);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.GeolocationPermissions.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/GeolocationPermissions"));
			global::android.webkit.GeolocationPermissions._clear10313 = @__env.GetMethodIDNoThrow(global::android.webkit.GeolocationPermissions.staticClass, "clear", "(Ljava/lang/String;)V");
			global::android.webkit.GeolocationPermissions._getInstance10314 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.GeolocationPermissions.staticClass, "getInstance", "()Landroid/webkit/GeolocationPermissions;");
			global::android.webkit.GeolocationPermissions._allow10315 = @__env.GetMethodIDNoThrow(global::android.webkit.GeolocationPermissions.staticClass, "allow", "(Ljava/lang/String;)V");
			global::android.webkit.GeolocationPermissions._getOrigins10316 = @__env.GetMethodIDNoThrow(global::android.webkit.GeolocationPermissions.staticClass, "getOrigins", "(Landroid/webkit/ValueCallback;)V");
			global::android.webkit.GeolocationPermissions._getAllowed10317 = @__env.GetMethodIDNoThrow(global::android.webkit.GeolocationPermissions.staticClass, "getAllowed", "(Ljava/lang/String;Landroid/webkit/ValueCallback;)V");
			global::android.webkit.GeolocationPermissions._clearAll10318 = @__env.GetMethodIDNoThrow(global::android.webkit.GeolocationPermissions.staticClass, "clearAll", "()V");
			global::android.webkit.GeolocationPermissions._GeolocationPermissions10319 = @__env.GetMethodIDNoThrow(global::android.webkit.GeolocationPermissions.staticClass, "<init>", "()V");
		}
	}
}
