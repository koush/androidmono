namespace android.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ParseException : java.lang.RuntimeException
	{ 
		internal static global::java.lang.Class staticClass; 
		static ParseException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.ParseException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.net.ParseException(@__env); 
			} 
		} 
		protected ParseException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _response4475; 
		public java.lang.String response
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.ParseException.staticClass = @__class; 
		} 
	} 
} 
