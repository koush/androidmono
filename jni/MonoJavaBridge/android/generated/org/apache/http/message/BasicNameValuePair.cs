namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicNameValuePair : java.lang.Object, NameValuePair, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicNameValuePair()
		{
			InitJNI();
		}
		protected BasicNameValuePair(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals26884;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair._equals26884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair.staticClass, global::org.apache.http.message.BasicNameValuePair._equals26884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString26885;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair._toString26885)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair.staticClass, global::org.apache.http.message.BasicNameValuePair._toString26885)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26886;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair._hashCode26886);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair.staticClass, global::org.apache.http.message.BasicNameValuePair._hashCode26886);
		}
		internal static global::MonoJavaBridge.MethodId _clone26887;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair._clone26887)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair.staticClass, global::org.apache.http.message.BasicNameValuePair._clone26887)) as java.lang.Object;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName26888;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair._getName26888)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair.staticClass, global::org.apache.http.message.BasicNameValuePair._getName26888)) as java.lang.String;
		}
		public new global::java.lang.String Value
		{
			get
			{
				return getValue();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValue26889;
		public virtual global::java.lang.String getValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair._getValue26889)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair.staticClass, global::org.apache.http.message.BasicNameValuePair._getValue26889)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _BasicNameValuePair26890;
		public BasicNameValuePair(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicNameValuePair.staticClass, global::org.apache.http.message.BasicNameValuePair._BasicNameValuePair26890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicNameValuePair.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicNameValuePair"));
			global::org.apache.http.message.BasicNameValuePair._equals26884 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicNameValuePair.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.message.BasicNameValuePair._toString26885 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicNameValuePair.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicNameValuePair._hashCode26886 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicNameValuePair.staticClass, "hashCode", "()I");
			global::org.apache.http.message.BasicNameValuePair._clone26887 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicNameValuePair.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.message.BasicNameValuePair._getName26888 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicNameValuePair.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicNameValuePair._getValue26889 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicNameValuePair.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicNameValuePair._BasicNameValuePair26890 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicNameValuePair.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
