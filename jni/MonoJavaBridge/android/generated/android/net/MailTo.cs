namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MailTo : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MailTo()
		{
			InitJNI();
		}
		protected MailTo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString7701;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.MailTo._toString7701)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.MailTo.staticClass, global::android.net.MailTo._toString7701)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _parse7702;
		public static global::android.net.MailTo parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.MailTo.staticClass, global::android.net.MailTo._parse7702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.MailTo;
		}
		public new global::java.util.Map Headers
		{
			get
			{
				return getHeaders();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders7703;
		public virtual global::java.util.Map getHeaders() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.MailTo._getHeaders7703)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.MailTo.staticClass, global::android.net.MailTo._getHeaders7703)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _isMailTo7704;
		public static bool isMailTo(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.net.MailTo.staticClass, global::android.net.MailTo._isMailTo7704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String To
		{
			get
			{
				return getTo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTo7705;
		public virtual global::java.lang.String getTo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.MailTo._getTo7705)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.MailTo.staticClass, global::android.net.MailTo._getTo7705)) as java.lang.String;
		}
		public new global::java.lang.String Cc
		{
			get
			{
				return getCc();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCc7706;
		public virtual global::java.lang.String getCc() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.MailTo._getCc7706)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.MailTo.staticClass, global::android.net.MailTo._getCc7706)) as java.lang.String;
		}
		public new global::java.lang.String Subject
		{
			get
			{
				return getSubject();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubject7707;
		public virtual global::java.lang.String getSubject() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.MailTo._getSubject7707)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.MailTo.staticClass, global::android.net.MailTo._getSubject7707)) as java.lang.String;
		}
		public new global::java.lang.String Body
		{
			get
			{
				return getBody();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBody7708;
		public virtual global::java.lang.String getBody() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.MailTo._getBody7708)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.MailTo.staticClass, global::android.net.MailTo._getBody7708)) as java.lang.String;
		}
		public static global::java.lang.String MAILTO_SCHEME
		{
			get
			{
				return "mailto:";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.MailTo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/MailTo"));
			global::android.net.MailTo._toString7701 = @__env.GetMethodIDNoThrow(global::android.net.MailTo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.MailTo._parse7702 = @__env.GetStaticMethodIDNoThrow(global::android.net.MailTo.staticClass, "parse", "(Ljava/lang/String;)Landroid/net/MailTo;");
			global::android.net.MailTo._getHeaders7703 = @__env.GetMethodIDNoThrow(global::android.net.MailTo.staticClass, "getHeaders", "()Ljava/util/Map;");
			global::android.net.MailTo._isMailTo7704 = @__env.GetStaticMethodIDNoThrow(global::android.net.MailTo.staticClass, "isMailTo", "(Ljava/lang/String;)Z");
			global::android.net.MailTo._getTo7705 = @__env.GetMethodIDNoThrow(global::android.net.MailTo.staticClass, "getTo", "()Ljava/lang/String;");
			global::android.net.MailTo._getCc7706 = @__env.GetMethodIDNoThrow(global::android.net.MailTo.staticClass, "getCc", "()Ljava/lang/String;");
			global::android.net.MailTo._getSubject7707 = @__env.GetMethodIDNoThrow(global::android.net.MailTo.staticClass, "getSubject", "()Ljava/lang/String;");
			global::android.net.MailTo._getBody7708 = @__env.GetMethodIDNoThrow(global::android.net.MailTo.staticClass, "getBody", "()Ljava/lang/String;");
		}
	}
}
