namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface TabStopSpan : ParagraphStyle
	{ 
		int getTabStop(); 
	} 

	public partial class TabStopSpan_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __TabStopSpan.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __TabStopSpan : java.lang.Object, TabStopSpan
	{ 
		internal static global::java.lang.Class staticClass; 
		static __TabStopSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.__TabStopSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.__TabStopSpan(@__env); 
			} 
		} 
		internal __TabStopSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTabStop7437; 
		 int android.text.style.TabStopSpan.getTabStop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.__TabStopSpan)) 
				return @__env.CallIntMethod(this, global::android.text.style.__TabStopSpan._getTabStop7437); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.__TabStopSpan.staticClass, global::android.text.style.__TabStopSpan._getTabStop7437); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.__TabStopSpan.staticClass = @__class; 
			global::android.text.style.__TabStopSpan._getTabStop7437 = @__env.GetMethodID(global::android.text.style.__TabStopSpan.staticClass, "android.text.style.TabStopSpan.getTabStop", "()I"); 
		} 
	} 
} 
