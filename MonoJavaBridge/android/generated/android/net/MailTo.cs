namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MailTo : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MailTo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.MailTo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.net.MailTo._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::android.net.MailTo parse(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.MailTo._m1.native == global::System.IntPtr.Zero)
				global::android.net.MailTo._m1 = @__env.GetStaticMethodIDNoThrow(global::android.net.MailTo.staticClass, "parse", "(Ljava/lang/String;)Landroid/net/MailTo;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.MailTo.staticClass, global::android.net.MailTo._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.MailTo;
		}
		public new global::java.util.Map Headers
		{
			get
			{
				return getHeaders();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.util.Map getHeaders()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::android.net.MailTo.staticClass, "getHeaders", "()Ljava/util/Map;", ref global::android.net.MailTo._m2) as java.util.Map;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static bool isMailTo(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.MailTo._m3.native == global::System.IntPtr.Zero)
				global::android.net.MailTo._m3 = @__env.GetStaticMethodIDNoThrow(global::android.net.MailTo.staticClass, "isMailTo", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(android.net.MailTo.staticClass, global::android.net.MailTo._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String To
		{
			get
			{
				return getTo();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getTo()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.MailTo.staticClass, "getTo", "()Ljava/lang/String;", ref global::android.net.MailTo._m4) as java.lang.String;
		}
		public new global::java.lang.String Cc
		{
			get
			{
				return getCc();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String getCc()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.MailTo.staticClass, "getCc", "()Ljava/lang/String;", ref global::android.net.MailTo._m5) as java.lang.String;
		}
		public new global::java.lang.String Subject
		{
			get
			{
				return getSubject();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.String getSubject()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.MailTo.staticClass, "getSubject", "()Ljava/lang/String;", ref global::android.net.MailTo._m6) as java.lang.String;
		}
		public new global::java.lang.String Body
		{
			get
			{
				return getBody();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String getBody()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.MailTo.staticClass, "getBody", "()Ljava/lang/String;", ref global::android.net.MailTo._m7) as java.lang.String;
		}
		public static global::java.lang.String MAILTO_SCHEME
		{
			get
			{
				return "mailto:";
			}
		}
		static MailTo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.MailTo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/MailTo"));
		}
		internal static void InitJNI()
		{
		}
	}
}
