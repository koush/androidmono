namespace android.sax 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface ElementListener : StartElementListener, EndElementListener
	{ 
	} 

	public partial class ElementListener_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __ElementListener.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __ElementListener : java.lang.Object, ElementListener
	{ 
		internal static global::java.lang.Class staticClass; 
		static __ElementListener() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.sax.__ElementListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.sax.__ElementListener(@__env); 
			} 
		} 
		internal __ElementListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _start6384; 
		 void android.sax.StartElementListener.start(org.xml.sax.Attributes arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.sax.__ElementListener)) 
				@__env.CallVoidMethod(this, _start6384, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.sax.__ElementListener.staticClass, _start6384, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _end6385; 
		 void android.sax.EndElementListener.end() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.sax.__ElementListener)) 
				@__env.CallVoidMethod(this, _end6385); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.sax.__ElementListener.staticClass, _end6385); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.sax.__ElementListener.staticClass = @__class; 
			global::android.sax.__ElementListener._start6384 = @__env.GetMethodID(global::android.sax.__ElementListener.staticClass, "android.sax.StartElementListener.start", "(Lorg/xml/sax/Attributes;)V"); 
			global::android.sax.__ElementListener._end6385 = @__env.GetMethodID(global::android.sax.__ElementListener.staticClass, "android.sax.EndElementListener.end", "()V"); 
		} 
	} 
} 
