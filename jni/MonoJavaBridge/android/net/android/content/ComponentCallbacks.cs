namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface ComponentCallbacks 
	{ 
		void onConfigurationChanged(android.content.res.Configuration arg0); 
		void onLowMemory(); 
	} 

	public partial class ComponentCallbacks_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __ComponentCallbacks.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __ComponentCallbacks : java.lang.Object, ComponentCallbacks
	{ 
		internal static global::java.lang.Class staticClass; 
		static __ComponentCallbacks() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.__ComponentCallbacks), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.__ComponentCallbacks(@__env); 
			} 
		} 
		internal __ComponentCallbacks(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onConfigurationChanged956; 
		 void android.content.ComponentCallbacks.onConfigurationChanged(android.content.res.Configuration arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.__ComponentCallbacks)) 
				@__env.CallVoidMethod(this, global::android.content.__ComponentCallbacks._onConfigurationChanged956, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.__ComponentCallbacks.staticClass, global::android.content.__ComponentCallbacks._onConfigurationChanged956, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLowMemory957; 
		 void android.content.ComponentCallbacks.onLowMemory() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.__ComponentCallbacks)) 
				@__env.CallVoidMethod(this, global::android.content.__ComponentCallbacks._onLowMemory957); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.__ComponentCallbacks.staticClass, global::android.content.__ComponentCallbacks._onLowMemory957); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.__ComponentCallbacks.staticClass = @__class; 
			global::android.content.__ComponentCallbacks._onConfigurationChanged956 = @__env.GetMethodID(global::android.content.__ComponentCallbacks.staticClass, "android.content.ComponentCallbacks.onConfigurationChanged", "(Landroid/content/res/Configuration;)V"); 
			global::android.content.__ComponentCallbacks._onLowMemory957 = @__env.GetMethodID(global::android.content.__ComponentCallbacks.staticClass, "android.content.ComponentCallbacks.onLowMemory", "()V"); 
		} 
	} 
} 
