namespace android.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class StringBuilderPrinter : java.lang.Object, Printer
	{ 
		internal static global::java.lang.Class staticClass; 
		static StringBuilderPrinter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.util.StringBuilderPrinter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _println7244; 
		public virtual void println(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.StringBuilderPrinter)) 
				@__env.CallVoidMethod(this, _println7244, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.StringBuilderPrinter.staticClass, _println7244, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _StringBuilderPrinter7245; 
		public StringBuilderPrinter(java.lang.StringBuilder arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.StringBuilderPrinter.staticClass, _StringBuilderPrinter7245, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.util.StringBuilderPrinter.staticClass = @__class; 
			global::android.util.StringBuilderPrinter._println7244 = @__env.GetMethodID(global::android.util.StringBuilderPrinter.staticClass, "println", "(Ljava/lang/String;)V"); 
			global::android.util.StringBuilderPrinter._StringBuilderPrinter7245 = @__env.GetMethodID(global::android.util.StringBuilderPrinter.staticClass, "<init>", "(Ljava/lang/StringBuilder;)V"); 
		} 
	} 
} 
