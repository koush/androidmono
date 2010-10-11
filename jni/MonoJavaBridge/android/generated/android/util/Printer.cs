namespace android.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.util.Printer_))]
	public interface Printer  : global::MonoJavaBridge.IJavaObject 
	{
		void println(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.util.Printer))]
	public sealed partial class Printer_ : java.lang.Object, Printer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Printer_()
		{
			InitJNI();
		}
		internal Printer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _println8575;
		 void android.util.Printer.println(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.Printer_._println8575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.Printer_.staticClass, global::android.util.Printer_._println8575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Printer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Printer"));
			global::android.util.Printer_._println8575 = @__env.GetMethodIDNoThrow(global::android.util.Printer_.staticClass, "println", "(Ljava/lang/String;)V");
		}
	}
}
