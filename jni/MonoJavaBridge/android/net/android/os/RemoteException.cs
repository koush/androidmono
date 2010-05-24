namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class RemoteException : android.util.AndroidException
	{ 
		internal new static global::java.lang.Class staticClass; 
		static RemoteException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.RemoteException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.RemoteException(@__env); 
			} 
		} 
		protected RemoteException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RemoteException5862; 
		public RemoteException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.RemoteException.staticClass, _RemoteException5862, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.RemoteException.staticClass = @__class; 
			global::android.os.RemoteException._RemoteException5862 = @__env.GetMethodID(global::android.os.RemoteException.staticClass, "<init>", "()V"); 
		} 
	} 
} 
