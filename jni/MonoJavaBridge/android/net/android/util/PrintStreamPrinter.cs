namespace android.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PrintStreamPrinter : java.lang.Object, Printer
	{ 
		internal static global::java.lang.Class staticClass; 
		static PrintStreamPrinter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.PrintStreamPrinter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.util.PrintStreamPrinter(@__env); 
			} 
		} 
		protected PrintStreamPrinter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _println7593; 
		public virtual void println(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.PrintStreamPrinter)) 
				@__env.CallVoidMethod(this, global::android.util.PrintStreamPrinter._println7593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.util.PrintStreamPrinter.staticClass, global::android.util.PrintStreamPrinter._println7593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PrintStreamPrinter7594; 
		public PrintStreamPrinter(java.io.PrintStream arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.PrintStreamPrinter.staticClass, global::android.util.PrintStreamPrinter._PrintStreamPrinter7594, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.util.PrintStreamPrinter.staticClass = @__class; 
			global::android.util.PrintStreamPrinter._println7593 = @__env.GetMethodID(global::android.util.PrintStreamPrinter.staticClass, "println", "(Ljava/lang/String;)V"); 
			global::android.util.PrintStreamPrinter._PrintStreamPrinter7594 = @__env.GetMethodID(global::android.util.PrintStreamPrinter.staticClass, "<init>", "(Ljava/io/PrintStream;)V"); 
		} 
	} 
} 
