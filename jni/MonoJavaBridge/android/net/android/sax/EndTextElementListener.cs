namespace android.sax 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface EndTextElementListener 
	{ 
		void end(java.lang.String arg0); 
	} 

	public partial class EndTextElementListener_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __EndTextElementListener.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __EndTextElementListener : java.lang.Object, EndTextElementListener
	{ 
		internal static global::java.lang.Class staticClass; 
		static __EndTextElementListener() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.sax.__EndTextElementListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.sax.__EndTextElementListener(@__env); 
			} 
		} 
		internal __EndTextElementListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _end6387; 
		 void android.sax.EndTextElementListener.end(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.sax.__EndTextElementListener)) 
				@__env.CallVoidMethod(this, global::android.sax.__EndTextElementListener._end6387, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.sax.__EndTextElementListener.staticClass, global::android.sax.__EndTextElementListener._end6387, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.sax.__EndTextElementListener.staticClass = @__class; 
			global::android.sax.__EndTextElementListener._end6387 = @__env.GetMethodID(global::android.sax.__EndTextElementListener.staticClass, "android.sax.EndTextElementListener.end", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
