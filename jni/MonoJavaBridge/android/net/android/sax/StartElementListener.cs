namespace android.sax 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface StartElementListener 
	{ 
		void start(org.xml.sax.Attributes arg0); 
	} 

	public partial class StartElementListener_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __StartElementListener.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __StartElementListener : java.lang.Object, StartElementListener
	{ 
		internal static global::java.lang.Class staticClass; 
		static __StartElementListener() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.sax.__StartElementListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.sax.__StartElementListener(@__env); 
			} 
		} 
		internal __StartElementListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _start6391; 
		 void android.sax.StartElementListener.start(org.xml.sax.Attributes arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.sax.__StartElementListener)) 
				@__env.CallVoidMethod(this, global::android.sax.__StartElementListener._start6391, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.sax.__StartElementListener.staticClass, global::android.sax.__StartElementListener._start6391, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.sax.__StartElementListener.staticClass = @__class; 
			global::android.sax.__StartElementListener._start6391 = @__env.GetMethodID(global::android.sax.__StartElementListener.staticClass, "android.sax.StartElementListener.start", "(Lorg/xml/sax/Attributes;)V"); 
		} 
	} 
} 
