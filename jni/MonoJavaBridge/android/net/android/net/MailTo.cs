namespace android.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class MailTo : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static MailTo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.MailTo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _toString4679; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.MailTo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.MailTo._toString4679)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.MailTo.staticClass, global::android.net.MailTo._toString4679)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parse4680; 
		public static global::android.net.MailTo parse(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.MailTo>(@__env, @__env.CallStaticObjectMethodPtr(android.net.MailTo.staticClass, global::android.net.MailTo._parse4680, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeaders4681; 
		public virtual global::java.util.Map getHeaders() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.MailTo)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.MailTo._getHeaders4681)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.MailTo.staticClass, global::android.net.MailTo._getHeaders4681)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMailTo4682; 
		public static bool isMailTo(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.net.MailTo.staticClass, global::android.net.MailTo._isMailTo4682, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTo4683; 
		public virtual global::java.lang.String getTo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.MailTo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.MailTo._getTo4683)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.MailTo.staticClass, global::android.net.MailTo._getTo4683)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCc4684; 
		public virtual global::java.lang.String getCc() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.MailTo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.MailTo._getCc4684)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.MailTo.staticClass, global::android.net.MailTo._getCc4684)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubject4685; 
		public virtual global::java.lang.String getSubject() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.MailTo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.MailTo._getSubject4685)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.MailTo.staticClass, global::android.net.MailTo._getSubject4685)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBody4686; 
		public virtual global::java.lang.String getBody() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.MailTo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.MailTo._getBody4686)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.MailTo.staticClass, global::android.net.MailTo._getBody4686)); 
		} 
		public static global::java.lang.String MAILTO_SCHEME
		{ 
			get 
			{ 
				return "mailto:"; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.MailTo.staticClass = @__class; 
			global::android.net.MailTo._toString4679 = @__env.GetMethodID(global::android.net.MailTo.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.net.MailTo._parse4680 = @__env.GetStaticMethodID(global::android.net.MailTo.staticClass, "parse", "(Ljava/lang/String;)Landroid/net/MailTo;"); 
			global::android.net.MailTo._getHeaders4681 = @__env.GetMethodID(global::android.net.MailTo.staticClass, "getHeaders", "()Ljava/util/Map;"); 
			global::android.net.MailTo._isMailTo4682 = @__env.GetStaticMethodID(global::android.net.MailTo.staticClass, "isMailTo", "(Ljava/lang/String;)Z"); 
			global::android.net.MailTo._getTo4683 = @__env.GetMethodID(global::android.net.MailTo.staticClass, "getTo", "()Ljava/lang/String;"); 
			global::android.net.MailTo._getCc4684 = @__env.GetMethodID(global::android.net.MailTo.staticClass, "getCc", "()Ljava/lang/String;"); 
			global::android.net.MailTo._getSubject4685 = @__env.GetMethodID(global::android.net.MailTo.staticClass, "getSubject", "()Ljava/lang/String;"); 
			global::android.net.MailTo._getBody4686 = @__env.GetMethodID(global::android.net.MailTo.staticClass, "getBody", "()Ljava/lang/String;"); 
		} 
	} 
} 
