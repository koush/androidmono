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
			internal static global::net.sf.jni4net.jni.MethodId _invoke9286; 
			 void android.webkit.GeolocationPermissions.Callback.invoke(java.lang.String arg0, bool arg1, bool arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.webkit.GeolocationPermissions.__Callback._invoke9286, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.webkit.GeolocationPermissions.__Callback.staticClass, global::android.webkit.GeolocationPermissions.__Callback._invoke9286, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.webkit.GeolocationPermissions.__Callback.staticClass = @__class; 
				global::android.webkit.GeolocationPermissions.__Callback._invoke9286 = @__env.GetMethodID(global::android.webkit.GeolocationPermissions.__Callback.staticClass, "android.webkit.GeolocationPermissions.Callback.invoke", "(Ljava/lang/String;ZZ)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear9287; 
		public void clear(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.GeolocationPermissions._clear9287, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._clear9287, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance9288; 
		public static global::android.webkit.GeolocationPermissions getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.GeolocationPermissions>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._getInstance9288)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _allow9289; 
		public void allow(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.GeolocationPermissions._allow9289, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._allow9289, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOrigins9290; 
		public void getOrigins(android.webkit.ValueCallback arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.GeolocationPermissions._getOrigins9290, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._getOrigins9290, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllowed9291; 
		public void getAllowed(java.lang.String arg0, android.webkit.ValueCallback arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.GeolocationPermissions._getAllowed9291, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._getAllowed9291, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearAll9292; 
		public void clearAll() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.GeolocationPermissions._clearAll9292); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._clearAll9292); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GeolocationPermissions9293; 
		public GeolocationPermissions()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.GeolocationPermissions.staticClass, global::android.webkit.GeolocationPermissions._GeolocationPermissions9293, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.GeolocationPermissions.staticClass = @__class; 
			global::android.webkit.GeolocationPermissions._clear9287 = @__env.GetMethodID(global::android.webkit.GeolocationPermissions.staticClass, "clear", "(Ljava/lang/String;)V"); 
			global::android.webkit.GeolocationPermissions._getInstance9288 = @__env.GetStaticMethodID(global::android.webkit.GeolocationPermissions.staticClass, "getInstance", "()Landroid/webkit/GeolocationPermissions;"); 
			global::android.webkit.GeolocationPermissions._allow9289 = @__env.GetMethodID(global::android.webkit.GeolocationPermissions.staticClass, "allow", "(Ljava/lang/String;)V"); 
			global::android.webkit.GeolocationPermissions._getOrigins9290 = @__env.GetMethodID(global::android.webkit.GeolocationPermissions.staticClass, "getOrigins", "(Landroid/webkit/ValueCallback;)V"); 
			global::android.webkit.GeolocationPermissions._getAllowed9291 = @__env.GetMethodID(global::android.webkit.GeolocationPermissions.staticClass, "getAllowed", "(Ljava/lang/String;Landroid/webkit/ValueCallback;)V"); 
			global::android.webkit.GeolocationPermissions._clearAll9292 = @__env.GetMethodID(global::android.webkit.GeolocationPermissions.staticClass, "clearAll", "()V"); 
			global::android.webkit.GeolocationPermissions._GeolocationPermissions9293 = @__env.GetMethodID(global::android.webkit.GeolocationPermissions.staticClass, "<init>", "()V"); 
		} 
	} 
} 
