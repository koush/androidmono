namespace android.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PrintWriterPrinter : java.lang.Object, Printer
	{ 
		internal static global::java.lang.Class staticClass; 
		static PrintWriterPrinter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.util.PrintWriterPrinter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.util.PrintWriterPrinter(@__env); 
			} 
		} 
		protected PrintWriterPrinter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _println7595; 
		public virtual void println(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.PrintWriterPrinter)) 
				@__env.CallVoidMethod(this, _println7595, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.PrintWriterPrinter.staticClass, _println7595, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriterPrinter7596; 
		public PrintWriterPrinter(java.io.PrintWriter arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.PrintWriterPrinter.staticClass, _PrintWriterPrinter7596, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.util.PrintWriterPrinter.staticClass = @__class; 
			global::android.util.PrintWriterPrinter._println7595 = @__env.GetMethodID(global::android.util.PrintWriterPrinter.staticClass, "println", "(Ljava/lang/String;)V"); 
			global::android.util.PrintWriterPrinter._PrintWriterPrinter7596 = @__env.GetMethodID(global::android.util.PrintWriterPrinter.staticClass, "<init>", "(Ljava/io/PrintWriter;)V"); 
		} 
	} 
} 
