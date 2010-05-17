namespace android.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class LogPrinter : java.lang.Object, Printer
	{ 
		internal static global::java.lang.Class staticClass; 
		static LogPrinter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.util.LogPrinter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _println7168; 
		public virtual void println(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.LogPrinter)) 
				@__env.CallVoidMethod(this, _println7168, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.LogPrinter.staticClass, _println7168, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LogPrinter7169; 
		public LogPrinter(int arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.LogPrinter.staticClass, _LogPrinter7169, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.util.LogPrinter.staticClass = @__class; 
			global::android.util.LogPrinter._println7168 = @__env.GetMethodID(global::android.util.LogPrinter.staticClass, "println", "(Ljava/lang/String;)V"); 
			global::android.util.LogPrinter._LogPrinter7169 = @__env.GetMethodID(global::android.util.LogPrinter.staticClass, "<init>", "(ILjava/lang/String;)V"); 
		} 
	} 
} 
