namespace android.accounts 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface AccountManagerFuture 
	{ 
		bool cancel(bool arg0); 
		bool isCancelled(); 
		bool isDone(); 
		java.lang.Object getResult(); 
		java.lang.Object getResult(long arg0, java.util.concurrent.TimeUnit arg1); 
	} 

	public partial class AccountManagerFuture_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __AccountManagerFuture.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __AccountManagerFuture : java.lang.Object, AccountManagerFuture
	{ 
		internal static global::java.lang.Class staticClass; 
		static __AccountManagerFuture() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.accounts.__AccountManagerFuture), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.accounts.__AccountManagerFuture(@__env); 
			} 
		} 
		internal __AccountManagerFuture(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancel91; 
		 bool android.accounts.AccountManagerFuture.cancel(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.accounts.__AccountManagerFuture)) 
				return @__env.CallBooleanMethod(this, _cancel91, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.accounts.__AccountManagerFuture.staticClass, _cancel91, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isCancelled92; 
		 bool android.accounts.AccountManagerFuture.isCancelled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.accounts.__AccountManagerFuture)) 
				return @__env.CallBooleanMethod(this, _isCancelled92); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.accounts.__AccountManagerFuture.staticClass, _isCancelled92); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDone93; 
		 bool android.accounts.AccountManagerFuture.isDone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.accounts.__AccountManagerFuture)) 
				return @__env.CallBooleanMethod(this, _isDone93); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.accounts.__AccountManagerFuture.staticClass, _isDone93); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getResult94; 
		 java.lang.Object android.accounts.AccountManagerFuture.getResult() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.accounts.__AccountManagerFuture)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getResult94)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.accounts.__AccountManagerFuture.staticClass, _getResult94)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getResult95; 
		 java.lang.Object android.accounts.AccountManagerFuture.getResult(long arg0, java.util.concurrent.TimeUnit arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.accounts.__AccountManagerFuture)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getResult95, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.accounts.__AccountManagerFuture.staticClass, _getResult95, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.accounts.__AccountManagerFuture.staticClass = @__class; 
			global::android.accounts.__AccountManagerFuture._cancel91 = @__env.GetMethodID(global::android.accounts.__AccountManagerFuture.staticClass, "android.accounts.AccountManagerFuture.cancel", "(Z)Z"); 
			global::android.accounts.__AccountManagerFuture._isCancelled92 = @__env.GetMethodID(global::android.accounts.__AccountManagerFuture.staticClass, "android.accounts.AccountManagerFuture.isCancelled", "()Z"); 
			global::android.accounts.__AccountManagerFuture._isDone93 = @__env.GetMethodID(global::android.accounts.__AccountManagerFuture.staticClass, "android.accounts.AccountManagerFuture.isDone", "()Z"); 
			global::android.accounts.__AccountManagerFuture._getResult94 = @__env.GetMethodID(global::android.accounts.__AccountManagerFuture.staticClass, "android.accounts.AccountManagerFuture.getResult", "()Ljava/lang/Object;"); 
			global::android.accounts.__AccountManagerFuture._getResult95 = @__env.GetMethodID(global::android.accounts.__AccountManagerFuture.staticClass, "android.accounts.AccountManagerFuture.getResult", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;"); 
		} 
	} 
} 
