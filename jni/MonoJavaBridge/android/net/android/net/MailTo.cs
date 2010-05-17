namespace android.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class MailTo : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static MailTo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.MailTo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.net.MailTo(@__env); 
			} 
		} 
		protected MailTo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString4431; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.MailTo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString4431)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.MailTo.staticClass, _toString4431)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parse4432; 
		public static android.net.MailTo parse(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.MailTo>(@__env, @__env.CallStaticObjectMethodPtr(android.net.MailTo.staticClass, _parse4432, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeaders4433; 
		public virtual java.util.Map getHeaders() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.MailTo)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, _getHeaders4433)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.MailTo.staticClass, _getHeaders4433)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMailTo4434; 
		public static bool isMailTo(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.net.MailTo.staticClass, _isMailTo4434, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTo4435; 
		public virtual java.lang.String getTo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.MailTo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getTo4435)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.MailTo.staticClass, _getTo4435)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCc4436; 
		public virtual java.lang.String getCc() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.MailTo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getCc4436)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.MailTo.staticClass, _getCc4436)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubject4437; 
		public virtual java.lang.String getSubject() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.MailTo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSubject4437)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.MailTo.staticClass, _getSubject4437)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBody4438; 
		public virtual java.lang.String getBody() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.MailTo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getBody4438)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.MailTo.staticClass, _getBody4438)); 
		} 
		public static java.lang.String MAILTO_SCHEME
		{ 
			get 
			{ 
				return "mailto:"; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.MailTo.staticClass = @__class; 
			global::android.net.MailTo._toString4431 = @__env.GetMethodID(global::android.net.MailTo.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.net.MailTo._parse4432 = @__env.GetStaticMethodID(global::android.net.MailTo.staticClass, "parse", "(Ljava/lang/String;)Landroid/net/MailTo;"); 
			global::android.net.MailTo._getHeaders4433 = @__env.GetMethodID(global::android.net.MailTo.staticClass, "getHeaders", "()Ljava/util/Map;"); 
			global::android.net.MailTo._isMailTo4434 = @__env.GetStaticMethodID(global::android.net.MailTo.staticClass, "isMailTo", "(Ljava/lang/String;)Z"); 
			global::android.net.MailTo._getTo4435 = @__env.GetMethodID(global::android.net.MailTo.staticClass, "getTo", "()Ljava/lang/String;"); 
			global::android.net.MailTo._getCc4436 = @__env.GetMethodID(global::android.net.MailTo.staticClass, "getCc", "()Ljava/lang/String;"); 
			global::android.net.MailTo._getSubject4437 = @__env.GetMethodID(global::android.net.MailTo.staticClass, "getSubject", "()Ljava/lang/String;"); 
			global::android.net.MailTo._getBody4438 = @__env.GetMethodID(global::android.net.MailTo.staticClass, "getBody", "()Ljava/lang/String;"); 
		} 
	} 
} 
