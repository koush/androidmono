namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DeadObjectException : android.os.RemoteException
	{ 
		internal new static global::java.lang.Class staticClass; 
		static DeadObjectException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.DeadObjectException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.DeadObjectException(@__env); 
			} 
		} 
		protected DeadObjectException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DeadObjectException5227; 
		public DeadObjectException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.DeadObjectException.staticClass, _DeadObjectException5227, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.DeadObjectException.staticClass = @__class; 
			global::android.os.DeadObjectException._DeadObjectException5227 = @__env.GetMethodID(global::android.os.DeadObjectException.staticClass, "<init>", "()V"); 
		} 
	} 
} 
