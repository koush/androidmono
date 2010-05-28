namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class ContentHandler : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static ContentHandler() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.net.ContentHandler), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected ContentHandler(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContent11658; 
		public abstract global::java.lang.Object getContent(java.net.URLConnection arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getContent11659; 
		public virtual global::java.lang.Object getContent(java.net.URLConnection arg0, java.lang.Class[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ContentHandler)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.ContentHandler._getContent11659, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.ContentHandler.staticClass, global::java.net.ContentHandler._getContent11659, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ContentHandler11660; 
		public ContentHandler()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.ContentHandler.staticClass, global::java.net.ContentHandler._ContentHandler11660, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.ContentHandler.staticClass = @__class; 
			global::java.net.ContentHandler._getContent11658 = @__env.GetMethodID(global::java.net.ContentHandler.staticClass, "getContent", "(Ljava/net/URLConnection;)Ljava/lang/Object;"); 
			global::java.net.ContentHandler._getContent11659 = @__env.GetMethodID(global::java.net.ContentHandler.staticClass, "getContent", "(Ljava/net/URLConnection;[Ljava/lang/Class;)Ljava/lang/Object;"); 
			global::java.net.ContentHandler._ContentHandler11660 = @__env.GetMethodID(global::java.net.ContentHandler.staticClass, "<init>", "()V"); 
		} 
	} 
} 
