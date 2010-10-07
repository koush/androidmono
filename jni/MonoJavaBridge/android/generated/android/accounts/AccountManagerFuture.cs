namespace android.accounts
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface AccountManagerFuture 
	{
		bool cancel(bool arg0);
		bool isCancelled();
		bool isDone();
		global::java.lang.Object getResult();
		global::java.lang.Object getResult(long arg0, java.util.concurrent.TimeUnit arg1);
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
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.accounts.__AccountManagerFuture), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _cancel92;
		 bool android.accounts.AccountManagerFuture.cancel(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.accounts.__AccountManagerFuture._cancel92, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.accounts.__AccountManagerFuture.staticClass, global::android.accounts.__AccountManagerFuture._cancel92, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isCancelled93;
		 bool android.accounts.AccountManagerFuture.isCancelled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.accounts.__AccountManagerFuture._isCancelled93);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.accounts.__AccountManagerFuture.staticClass, global::android.accounts.__AccountManagerFuture._isCancelled93);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDone94;
		 bool android.accounts.AccountManagerFuture.isDone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.accounts.__AccountManagerFuture._isDone94);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.accounts.__AccountManagerFuture.staticClass, global::android.accounts.__AccountManagerFuture._isDone94);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getResult95;
		 global::java.lang.Object android.accounts.AccountManagerFuture.getResult() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.accounts.__AccountManagerFuture._getResult95));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.accounts.__AccountManagerFuture.staticClass, global::android.accounts.__AccountManagerFuture._getResult95));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getResult96;
		 global::java.lang.Object android.accounts.AccountManagerFuture.getResult(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.accounts.__AccountManagerFuture._getResult96, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.accounts.__AccountManagerFuture.staticClass, global::android.accounts.__AccountManagerFuture._getResult96, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.accounts.__AccountManagerFuture.staticClass = @__class;
			global::android.accounts.__AccountManagerFuture._cancel92 = @__env.GetMethodID(global::android.accounts.__AccountManagerFuture.staticClass, "android.accounts.AccountManagerFuture.cancel", "(Z)Z");
			global::android.accounts.__AccountManagerFuture._isCancelled93 = @__env.GetMethodID(global::android.accounts.__AccountManagerFuture.staticClass, "android.accounts.AccountManagerFuture.isCancelled", "()Z");
			global::android.accounts.__AccountManagerFuture._isDone94 = @__env.GetMethodID(global::android.accounts.__AccountManagerFuture.staticClass, "android.accounts.AccountManagerFuture.isDone", "()Z");
			global::android.accounts.__AccountManagerFuture._getResult95 = @__env.GetMethodID(global::android.accounts.__AccountManagerFuture.staticClass, "android.accounts.AccountManagerFuture.getResult", "()Ljava/lang/Object;");
			global::android.accounts.__AccountManagerFuture._getResult96 = @__env.GetMethodID(global::android.accounts.__AccountManagerFuture.staticClass, "android.accounts.AccountManagerFuture.getResult", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
		}
	}
}
