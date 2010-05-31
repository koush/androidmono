namespace android.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class StringBuilderPrinter : java.lang.Object, Printer
	{
		internal static global::java.lang.Class staticClass;
		static StringBuilderPrinter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.StringBuilderPrinter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.util.StringBuilderPrinter(@__env);
			}
		}
		protected StringBuilderPrinter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _println7647;
		public virtual void println(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.StringBuilderPrinter._println7647, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.StringBuilderPrinter.staticClass, global::android.util.StringBuilderPrinter._println7647, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _StringBuilderPrinter7648;
		public StringBuilderPrinter(java.lang.StringBuilder arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.StringBuilderPrinter.staticClass, global::android.util.StringBuilderPrinter._StringBuilderPrinter7648, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.util.StringBuilderPrinter.staticClass = @__class;
			global::android.util.StringBuilderPrinter._println7647 = @__env.GetMethodID(global::android.util.StringBuilderPrinter.staticClass, "println", "(Ljava/lang/String;)V");
			global::android.util.StringBuilderPrinter._StringBuilderPrinter7648 = @__env.GetMethodID(global::android.util.StringBuilderPrinter.staticClass, "<init>", "(Ljava/lang/StringBuilder;)V");
		}
	}
}
