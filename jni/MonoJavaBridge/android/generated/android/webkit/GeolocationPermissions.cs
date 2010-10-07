namespace android.webkit
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class GeolocationPermissions : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static GeolocationPermissions()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.GeolocationPermissions), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.webkit.GeolocationPermissions(@__env);
			}
		}
		internal GeolocationPermissions(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface Callback 
		{
			void invoke(java.lang.String arg0, bool arg1, bool arg2);
		}

		public partial class Callback_
		{
			public static global::java.lang.Class _class
			{
				get { return __Callback.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __Callback : java.lang.Object, Callback
		{
			internal static global::java.lang.Class staticClass;
			static __Callback()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.GeolocationPermissions.__Callback), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.webkit.GeolocationPermissions.__Callback(@__env);
				}
			}
			internal __Callback(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _invoke9965;
			 void android.webkit.GeolocationPermissions.Callback.invoke(java.lang.String arg0, bool arg1, bool arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.webkit.GeolocationPermissions.__Callback._invoke9965, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.webkit.GeolocationPermissions.__Callback.staticClass, global::android.webkit.GeolocationPermissions.__Callback._invoke9965, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.webkit.GeolocationPermissions.__Callback.staticClass = @__class;
				global::android.webkit.GeolocationPermissions.__Callback._invoke9965 = @__env.GetMethodID(global::android.webkit.GeolocationPermissions.__Callback.staticClass, "android.webkit.GeolocationPermissions.Callback.invoke", "(Ljava/lang/String;ZZ)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear9966;
		public void clear(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.GeolocationPermissions._clear9966, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._clear9966, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance9967;
		public static global::android.webkit.GeolocationPermissions getInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.GeolocationPermissions>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._getInstance9967));
		}
		internal static global::net.sf.jni4net.jni.MethodId _allow9968;
		public void allow(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.GeolocationPermissions._allow9968, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._allow9968, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOrigins9969;
		public void getOrigins(android.webkit.ValueCallback arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.GeolocationPermissions._getOrigins9969, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._getOrigins9969, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAllowed9970;
		public void getAllowed(java.lang.String arg0, android.webkit.ValueCallback arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.GeolocationPermissions._getAllowed9970, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._getAllowed9970, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearAll9971;
		public void clearAll() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.GeolocationPermissions._clearAll9971);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._clearAll9971);
		}
		internal static global::net.sf.jni4net.jni.MethodId _GeolocationPermissions9972;
		public GeolocationPermissions()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._GeolocationPermissions9972, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.webkit.GeolocationPermissions.staticClass = @__class;
			global::android.webkit.GeolocationPermissions._clear9966 = @__env.GetMethodID(global::android.webkit.GeolocationPermissions.staticClass, "clear", "(Ljava/lang/String;)V");
			global::android.webkit.GeolocationPermissions._getInstance9967 = @__env.GetStaticMethodID(global::android.webkit.GeolocationPermissions.staticClass, "getInstance", "()Landroid/webkit/GeolocationPermissions;");
			global::android.webkit.GeolocationPermissions._allow9968 = @__env.GetMethodID(global::android.webkit.GeolocationPermissions.staticClass, "allow", "(Ljava/lang/String;)V");
			global::android.webkit.GeolocationPermissions._getOrigins9969 = @__env.GetMethodID(global::android.webkit.GeolocationPermissions.staticClass, "getOrigins", "(Landroid/webkit/ValueCallback;)V");
			global::android.webkit.GeolocationPermissions._getAllowed9970 = @__env.GetMethodID(global::android.webkit.GeolocationPermissions.staticClass, "getAllowed", "(Ljava/lang/String;Landroid/webkit/ValueCallback;)V");
			global::android.webkit.GeolocationPermissions._clearAll9971 = @__env.GetMethodID(global::android.webkit.GeolocationPermissions.staticClass, "clearAll", "()V");
			global::android.webkit.GeolocationPermissions._GeolocationPermissions9972 = @__env.GetMethodID(global::android.webkit.GeolocationPermissions.staticClass, "<init>", "()V");
		}
	}
}
