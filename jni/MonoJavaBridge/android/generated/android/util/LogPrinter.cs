namespace android.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class LogPrinter : java.lang.Object, Printer
	{
		internal static global::java.lang.Class staticClass;
		static LogPrinter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.LogPrinter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.util.LogPrinter(@__env);
			}
		}
		protected LogPrinter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _println7570;
		public virtual void println(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.LogPrinter._println7570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.LogPrinter.staticClass, global::android.util.LogPrinter._println7570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _LogPrinter7571;
		public LogPrinter(int arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.LogPrinter.staticClass, global::android.util.LogPrinter._LogPrinter7571, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.util.LogPrinter.staticClass = @__class;
			global::android.util.LogPrinter._println7570 = @__env.GetMethodID(global::android.util.LogPrinter.staticClass, "println", "(Ljava/lang/String;)V");
			global::android.util.LogPrinter._LogPrinter7571 = @__env.GetMethodID(global::android.util.LogPrinter.staticClass, "<init>", "(ILjava/lang/String;)V");
		}
	}
}
