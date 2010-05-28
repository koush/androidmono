namespace android.text.format 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Formatter : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Formatter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.format.Formatter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.format.Formatter(@__env); 
			} 
		} 
		internal Formatter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _formatFileSize7066; 
		public static global::java.lang.String formatFileSize(android.content.Context arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.Formatter.staticClass, global::android.text.format.Formatter._formatFileSize7066, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _formatShortFileSize7067; 
		public static global::java.lang.String formatShortFileSize(android.content.Context arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.Formatter.staticClass, global::android.text.format.Formatter._formatShortFileSize7067, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _formatIpAddress7068; 
		public static global::java.lang.String formatIpAddress(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.Formatter.staticClass, global::android.text.format.Formatter._formatIpAddress7068, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Formatter7069; 
		public Formatter()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.format.Formatter.staticClass, global::android.text.format.Formatter._Formatter7069, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.format.Formatter.staticClass = @__class; 
			global::android.text.format.Formatter._formatFileSize7066 = @__env.GetStaticMethodID(global::android.text.format.Formatter.staticClass, "formatFileSize", "(Landroid/content/Context;J)Ljava/lang/String;"); 
			global::android.text.format.Formatter._formatShortFileSize7067 = @__env.GetStaticMethodID(global::android.text.format.Formatter.staticClass, "formatShortFileSize", "(Landroid/content/Context;J)Ljava/lang/String;"); 
			global::android.text.format.Formatter._formatIpAddress7068 = @__env.GetStaticMethodID(global::android.text.format.Formatter.staticClass, "formatIpAddress", "(I)Ljava/lang/String;"); 
			global::android.text.format.Formatter._Formatter7069 = @__env.GetMethodID(global::android.text.format.Formatter.staticClass, "<init>", "()V"); 
		} 
	} 
} 
