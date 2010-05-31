namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface AlignmentSpan : ParagraphStyle
	{ 
		global::android.text.Layout.Alignment getAlignment(); 
	} 

	public partial class AlignmentSpan_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __AlignmentSpan.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __AlignmentSpan : java.lang.Object, AlignmentSpan
	{ 
		internal static global::java.lang.Class staticClass; 
		static __AlignmentSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.__AlignmentSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.__AlignmentSpan(@__env); 
			} 
		} 
		internal __AlignmentSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAlignment7293; 
		 global::android.text.Layout.Alignment android.text.style.AlignmentSpan.getAlignment() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Alignment>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.style.__AlignmentSpan._getAlignment7293)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Alignment>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.style.__AlignmentSpan.staticClass, global::android.text.style.__AlignmentSpan._getAlignment7293)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.__AlignmentSpan.staticClass = @__class; 
			global::android.text.style.__AlignmentSpan._getAlignment7293 = @__env.GetMethodID(global::android.text.style.__AlignmentSpan.staticClass, "android.text.style.AlignmentSpan.getAlignment", "()Landroid/text/Layout$Alignment;"); 
		} 
	} 
} 
