namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class GeolocationPermissions : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static GeolocationPermissions() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.GeolocationPermissions), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _clear8603; 
		public void clear(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.GeolocationPermissions)) 
				@__env.CallVoidMethod(this, _clear8603, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.GeolocationPermissions.staticClass, _clear8603, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance8604; 
		public static android.webkit.GeolocationPermissions getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.GeolocationPermissions>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.GeolocationPermissions.staticClass, _getInstance8604)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _allow8605; 
		public void allow(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.GeolocationPermissions)) 
				@__env.CallVoidMethod(this, _allow8605, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.GeolocationPermissions.staticClass, _allow8605, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOrigins8606; 
		public void getOrigins(android.webkit.ValueCallback arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.GeolocationPermissions)) 
				@__env.CallVoidMethod(this, _getOrigins8606, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.GeolocationPermissions.staticClass, _getOrigins8606, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllowed8607; 
		public void getAllowed(java.lang.String arg0, android.webkit.ValueCallback arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.GeolocationPermissions)) 
				@__env.CallVoidMethod(this, _getAllowed8607, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.GeolocationPermissions.staticClass, _getAllowed8607, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearAll8608; 
		public void clearAll() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.GeolocationPermissions)) 
				@__env.CallVoidMethod(this, _clearAll8608); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.GeolocationPermissions.staticClass, _clearAll8608); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GeolocationPermissions8609; 
		public GeolocationPermissions()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.GeolocationPermissions.staticClass, _GeolocationPermissions8609, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.GeolocationPermissions.staticClass = @__class; 
			global::android.webkit.GeolocationPermissions._clear8603 = @__env.GetMethodID(global::android.webkit.GeolocationPermissions.staticClass, "clear", "(Ljava/lang/String;)V"); 
			global::android.webkit.GeolocationPermissions._getInstance8604 = @__env.GetStaticMethodID(global::android.webkit.GeolocationPermissions.staticClass, "getInstance", "()Landroid/webkit/GeolocationPermissions;"); 
			global::android.webkit.GeolocationPermissions._allow8605 = @__env.GetMethodID(global::android.webkit.GeolocationPermissions.staticClass, "allow", "(Ljava/lang/String;)V"); 
			global::android.webkit.GeolocationPermissions._getOrigins8606 = @__env.GetMethodID(global::android.webkit.GeolocationPermissions.staticClass, "getOrigins", "(Landroid/webkit/ValueCallback;)V"); 
			global::android.webkit.GeolocationPermissions._getAllowed8607 = @__env.GetMethodID(global::android.webkit.GeolocationPermissions.staticClass, "getAllowed", "(Ljava/lang/String;Landroid/webkit/ValueCallback;)V"); 
			global::android.webkit.GeolocationPermissions._clearAll8608 = @__env.GetMethodID(global::android.webkit.GeolocationPermissions.staticClass, "clearAll", "()V"); 
			global::android.webkit.GeolocationPermissions._GeolocationPermissions8609 = @__env.GetMethodID(global::android.webkit.GeolocationPermissions.staticClass, "<init>", "()V"); 
		} 
	} 
} 
