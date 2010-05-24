namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface WrapTogetherSpan : ParagraphStyle
	{ 
	} 

	public partial class WrapTogetherSpan_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __WrapTogetherSpan.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __WrapTogetherSpan : java.lang.Object, WrapTogetherSpan
	{ 
		internal static global::java.lang.Class staticClass; 
		static __WrapTogetherSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.style.__WrapTogetherSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.__WrapTogetherSpan(@__env); 
			} 
		} 
		internal __WrapTogetherSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.__WrapTogetherSpan.staticClass = @__class; 
		} 
	} 
} 
