namespace android.sax 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class RootElement : android.sax.Element
	{ 
		internal new static global::java.lang.Class staticClass; 
		static RootElement() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.sax.RootElement), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.sax.RootElement(@__env); 
			} 
		} 
		protected RootElement(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContentHandler6388; 
		public virtual global::org.xml.sax.ContentHandler getContentHandler() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.sax.RootElement)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xml.sax.ContentHandler>(@__env, @__env.CallObjectMethodPtr(this, global::android.sax.RootElement._getContentHandler6388)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xml.sax.ContentHandler>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.sax.RootElement.staticClass, global::android.sax.RootElement._getContentHandler6388)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RootElement6389; 
		public RootElement(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.sax.RootElement.staticClass, global::android.sax.RootElement._RootElement6389, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RootElement6390; 
		public RootElement(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.sax.RootElement.staticClass, global::android.sax.RootElement._RootElement6390, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.sax.RootElement.staticClass = @__class; 
			global::android.sax.RootElement._getContentHandler6388 = @__env.GetMethodID(global::android.sax.RootElement.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;"); 
			global::android.sax.RootElement._RootElement6389 = @__env.GetMethodID(global::android.sax.RootElement.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.sax.RootElement._RootElement6390 = @__env.GetMethodID(global::android.sax.RootElement.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
