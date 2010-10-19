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
		internal static global::MonoJavaBridge.MethodId _toString5190;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.MailTo._toString5190)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.MailTo.staticClass, global::android.net.MailTo._toString5190)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _parse5191;
		public static global::android.net.MailTo parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.MailTo.staticClass, global::android.net.MailTo._parse5191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.MailTo;
		}
		public new global::java.util.Map Headers
		{
			get
			{
				return getHeaders();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders5192;
		public virtual global::java.util.Map getHeaders() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.MailTo._getHeaders5192)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.MailTo.staticClass, global::android.net.MailTo._getHeaders5192)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _isMailTo5193;
		public static bool isMailTo(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.net.MailTo.staticClass, global::android.net.MailTo._isMailTo5193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String To
		{
			get
			{
				return getTo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTo5194;
		public virtual global::java.lang.String getTo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.MailTo._getTo5194)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.MailTo.staticClass, global::android.net.MailTo._getTo5194)) as java.lang.String;
		}
		public new global::java.lang.String Cc
		{
			get
			{
				return getCc();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCc5195;
		public virtual global::java.lang.String getCc() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.MailTo._getCc5195)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.MailTo.staticClass, global::android.net.MailTo._getCc5195)) as java.lang.String;
		}
		public new global::java.lang.String Subject
		{
			get
			{
				return getSubject();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubject5196;
		public virtual global::java.lang.String getSubject() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.MailTo._getSubject5196)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.MailTo.staticClass, global::android.net.MailTo._getSubject5196)) as java.lang.String;
		}
		public new global::java.lang.String Body
		{
			get
			{
				return getBody();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBody5197;
		public virtual global::java.lang.String getBody() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.MailTo._getBody5197)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.MailTo.staticClass, global::android.net.MailTo._getBody5197)) as java.lang.String;
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
			global::android.net.MailTo._toString5190 = @__env.GetMethodIDNoThrow(global::android.net.MailTo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.MailTo._parse5191 = @__env.GetStaticMethodIDNoThrow(global::android.net.MailTo.staticClass, "parse", "(Ljava/lang/String;)Landroid/net/MailTo;");
			global::android.net.MailTo._getHeaders5192 = @__env.GetMethodIDNoThrow(global::android.net.MailTo.staticClass, "getHeaders", "()Ljava/util/Map;");
			global::android.net.MailTo._isMailTo5193 = @__env.GetStaticMethodIDNoThrow(global::android.net.MailTo.staticClass, "isMailTo", "(Ljava/lang/String;)Z");
			global::android.net.MailTo._getTo5194 = @__env.GetMethodIDNoThrow(global::android.net.MailTo.staticClass, "getTo", "()Ljava/lang/String;");
			global::android.net.MailTo._getCc5195 = @__env.GetMethodIDNoThrow(global::android.net.MailTo.staticClass, "getCc", "()Ljava/lang/String;");
			global::android.net.MailTo._getSubject5196 = @__env.GetMethodIDNoThrow(global::android.net.MailTo.staticClass, "getSubject", "()Ljava/lang/String;");
			global::android.net.MailTo._getBody5197 = @__env.GetMethodIDNoThrow(global::android.net.MailTo.staticClass, "getBody", "()Ljava/lang/String;");
		}
	}
}
