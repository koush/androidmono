namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class NoCopySpan_Concrete : java.lang.Object, NoCopySpan
	{ 
		internal static global::java.lang.Class staticClass; 
		static NoCopySpan_Concrete() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.NoCopySpan_Concrete), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.NoCopySpan_Concrete(@__env); 
			} 
		} 
		protected NoCopySpan_Concrete(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _NoCopySpan_Concrete6857; 
		public NoCopySpan_Concrete()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.NoCopySpan_Concrete.staticClass, global::android.text.NoCopySpan_Concrete._NoCopySpan_Concrete6857, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.NoCopySpan_Concrete.staticClass = @__class; 
			global::android.text.NoCopySpan_Concrete._NoCopySpan_Concrete6857 = @__env.GetMethodID(global::android.text.NoCopySpan_Concrete.staticClass, "<init>", "()V"); 
		} 
	} 
} 
