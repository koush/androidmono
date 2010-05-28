namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface NoCopySpan 
	{ 
	} 

	public partial class NoCopySpan_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __NoCopySpan.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __NoCopySpan : java.lang.Object, NoCopySpan
	{ 
		internal static global::java.lang.Class staticClass; 
		static __NoCopySpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.__NoCopySpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.__NoCopySpan(@__env); 
			} 
		} 
		internal __NoCopySpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.__NoCopySpan.staticClass = @__class; 
		} 
	} 
} 
