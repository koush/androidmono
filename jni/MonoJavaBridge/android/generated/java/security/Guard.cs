namespace java.security
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface Guard 
	{
		void checkGuard(java.lang.Object arg0);
	}

	public partial class Guard_
	{
		public static global::java.lang.Class _class
		{
			get { return __Guard.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __Guard : java.lang.Object, Guard
	{
		internal static global::java.lang.Class staticClass;
		static __Guard()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.security.__Guard), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.security.__Guard(@__env);
			}
		}
		internal __Guard(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkGuard13165;
		 void java.security.Guard.checkGuard(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.security.__Guard._checkGuard13165, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.security.__Guard.staticClass, global::java.security.__Guard._checkGuard13165, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.security.__Guard.staticClass = @__class;
			global::java.security.__Guard._checkGuard13165 = @__env.GetMethodID(global::java.security.__Guard.staticClass, "java.security.Guard.checkGuard", "(Ljava/lang/Object;)V");
		}
	}
}
