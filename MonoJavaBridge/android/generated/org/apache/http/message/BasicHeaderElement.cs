namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHeaderElement : java.lang.Object, HeaderElement, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicHeaderElement(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicHeaderElement.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::org.apache.http.message.BasicHeaderElement._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.message.BasicHeaderElement.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.message.BasicHeaderElement._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.BasicHeaderElement.staticClass, "hashCode", "()I", ref global::org.apache.http.message.BasicHeaderElement._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicHeaderElement.staticClass, "clone", "()Ljava/lang/Object;", ref global::org.apache.http.message.BasicHeaderElement._m3) as java.lang.Object;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.message.BasicHeaderElement.staticClass, "getName", "()Ljava/lang/String;", ref global::org.apache.http.message.BasicHeaderElement._m4) as java.lang.String;
		}
		public new global::java.lang.String Value
		{
			get
			{
				return getValue();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String getValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.message.BasicHeaderElement.staticClass, "getValue", "()Ljava/lang/String;", ref global::org.apache.http.message.BasicHeaderElement._m5) as java.lang.String;
		}
		public new global::org.apache.http.NameValuePair[] Parameters
		{
			get
			{
				return getParameters();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::org.apache.http.NameValuePair[] getParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.NameValuePair>(this, global::org.apache.http.message.BasicHeaderElement.staticClass, "getParameters", "()[Lorg/apache/http/NameValuePair;", ref global::org.apache.http.message.BasicHeaderElement._m6) as org.apache.http.NameValuePair[];
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::org.apache.http.NameValuePair getParameter(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.NameValuePair>(this, global::org.apache.http.message.BasicHeaderElement.staticClass, "getParameter", "(I)Lorg/apache/http/NameValuePair;", ref global::org.apache.http.message.BasicHeaderElement._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.NameValuePair;
		}
		public new int ParameterCount
		{
			get
			{
				return getParameterCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int getParameterCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.BasicHeaderElement.staticClass, "getParameterCount", "()I", ref global::org.apache.http.message.BasicHeaderElement._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::org.apache.http.NameValuePair getParameterByName(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.NameValuePair>(this, global::org.apache.http.message.BasicHeaderElement.staticClass, "getParameterByName", "(Ljava/lang/String;)Lorg/apache/http/NameValuePair;", ref global::org.apache.http.message.BasicHeaderElement._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.NameValuePair;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public BasicHeaderElement(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeaderElement._m10.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeaderElement._m10 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public BasicHeaderElement(java.lang.String arg0, java.lang.String arg1, org.apache.http.NameValuePair[] arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeaderElement._m11.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeaderElement._m11 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;[Lorg/apache/http/NameValuePair;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static BasicHeaderElement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicHeaderElement.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicHeaderElement"));
		}
	}
}
