namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface ServiceConnection 
	{ 
		void onServiceConnected(android.content.ComponentName arg0, android.os.IBinder arg1); 
		void onServiceDisconnected(android.content.ComponentName arg0); 
	} 

	public partial class ServiceConnection_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __ServiceConnection.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __ServiceConnection : java.lang.Object, ServiceConnection
	{ 
		internal static global::java.lang.Class staticClass; 
		static __ServiceConnection() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.__ServiceConnection), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.__ServiceConnection(@__env); 
			} 
		} 
		internal __ServiceConnection(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onServiceConnected1491; 
		 void android.content.ServiceConnection.onServiceConnected(android.content.ComponentName arg0, android.os.IBinder arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.__ServiceConnection)) 
				@__env.CallVoidMethod(this, _onServiceConnected1491, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.__ServiceConnection.staticClass, _onServiceConnected1491, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onServiceDisconnected1492; 
		 void android.content.ServiceConnection.onServiceDisconnected(android.content.ComponentName arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.__ServiceConnection)) 
				@__env.CallVoidMethod(this, _onServiceDisconnected1492, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.__ServiceConnection.staticClass, _onServiceDisconnected1492, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.__ServiceConnection.staticClass = @__class; 
			global::android.content.__ServiceConnection._onServiceConnected1491 = @__env.GetMethodID(global::android.content.__ServiceConnection.staticClass, "android.content.ServiceConnection.onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V"); 
			global::android.content.__ServiceConnection._onServiceDisconnected1492 = @__env.GetMethodID(global::android.content.__ServiceConnection.staticClass, "android.content.ServiceConnection.onServiceDisconnected", "(Landroid/content/ComponentName;)V"); 
		} 
	} 
} 
