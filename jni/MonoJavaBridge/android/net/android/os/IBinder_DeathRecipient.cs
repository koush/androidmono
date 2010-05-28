namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface IBinder_DeathRecipient 
	{ 
		void binderDied(); 
	} 

	public partial class IBinder_DeathRecipient_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __IBinder_DeathRecipient.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __IBinder_DeathRecipient : java.lang.Object, IBinder_DeathRecipient
	{ 
		internal static global::java.lang.Class staticClass; 
		static __IBinder_DeathRecipient() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.__IBinder_DeathRecipient), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.__IBinder_DeathRecipient(@__env); 
			} 
		} 
		internal __IBinder_DeathRecipient(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _binderDied5618; 
		 void android.os.IBinder_DeathRecipient.binderDied() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.__IBinder_DeathRecipient)) 
				@__env.CallVoidMethod(this, global::android.os.__IBinder_DeathRecipient._binderDied5618); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.__IBinder_DeathRecipient.staticClass, global::android.os.__IBinder_DeathRecipient._binderDied5618); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.__IBinder_DeathRecipient.staticClass = @__class; 
			global::android.os.__IBinder_DeathRecipient._binderDied5618 = @__env.GetMethodID(global::android.os.__IBinder_DeathRecipient.staticClass, "android.os.IBinder_DeathRecipient.binderDied", "()V"); 
		} 
	} 
} 
