namespace android.accounts 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface AccountManagerCallback 
	{ 
		void run(android.accounts.AccountManagerFuture arg0); 
	} 

	public partial class AccountManagerCallback_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __AccountManagerCallback.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __AccountManagerCallback : java.lang.Object, AccountManagerCallback
	{ 
		internal static global::java.lang.Class staticClass; 
		static __AccountManagerCallback() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.accounts.__AccountManagerCallback), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.accounts.__AccountManagerCallback(@__env); 
			} 
		} 
		internal __AccountManagerCallback(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _run90; 
		 void android.accounts.AccountManagerCallback.run(android.accounts.AccountManagerFuture arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.accounts.__AccountManagerCallback._run90, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.accounts.__AccountManagerCallback.staticClass, global::android.accounts.__AccountManagerCallback._run90, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.accounts.__AccountManagerCallback.staticClass = @__class; 
			global::android.accounts.__AccountManagerCallback._run90 = @__env.GetMethodID(global::android.accounts.__AccountManagerCallback.staticClass, "android.accounts.AccountManagerCallback.run", "(Landroid/accounts/AccountManagerFuture;)V"); 
		} 
	} 
} 
