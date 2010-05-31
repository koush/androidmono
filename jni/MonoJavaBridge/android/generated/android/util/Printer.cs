namespace android.util
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface Printer 
	{
		void println(java.lang.String arg0);
	}

	public partial class Printer_
	{
		public static global::java.lang.Class _class
		{
			get { return __Printer.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __Printer : java.lang.Object, Printer
	{
		internal static global::java.lang.Class staticClass;
		static __Printer()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.__Printer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.util.__Printer(@__env);
			}
		}
		internal __Printer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _println7597;
		 void android.util.Printer.println(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.__Printer._println7597, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.__Printer.staticClass, global::android.util.__Printer._println7597, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.util.__Printer.staticClass = @__class;
			global::android.util.__Printer._println7597 = @__env.GetMethodID(global::android.util.__Printer.staticClass, "android.util.Printer.println", "(Ljava/lang/String;)V");
		}
	}
}
