namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHeaderElement : java.lang.Object, HeaderElement, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicHeaderElement(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals33511;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._equals33511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString33512;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._toString33512)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode33513;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._hashCode33513);
		}
		internal static global::MonoJavaBridge.MethodId _clone33514;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._clone33514)) as java.lang.Object;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName33515;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._getName33515)) as java.lang.String;
		}
		public new global::java.lang.String Value
		{
			get
			{
				return getValue();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValue33516;
		public virtual global::java.lang.String getValue()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._getValue33516)) as java.lang.String;
		}
		public new global::org.apache.http.NameValuePair[] Parameters
		{
			get
			{
				return getParameters();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameters33517;
		public virtual global::org.apache.http.NameValuePair[] getParameters()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.NameValuePair>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._getParameters33517)) as org.apache.http.NameValuePair[];
		}
		internal static global::MonoJavaBridge.MethodId _getParameter33518;
		public virtual global::org.apache.http.NameValuePair getParameter(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._getParameter33518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.NameValuePair;
		}
		public new int ParameterCount
		{
			get
			{
				return getParameterCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameterCount33519;
		public virtual int getParameterCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._getParameterCount33519);
		}
		internal static global::MonoJavaBridge.MethodId _getParameterByName33520;
		public virtual global::org.apache.http.NameValuePair getParameterByName(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._getParameterByName33520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.NameValuePair;
		}
		internal static global::MonoJavaBridge.MethodId _BasicHeaderElement33521;
		public BasicHeaderElement(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._BasicHeaderElement33521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BasicHeaderElement33522;
		public BasicHeaderElement(java.lang.String arg0, java.lang.String arg1, org.apache.http.NameValuePair[] arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._BasicHeaderElement33522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static BasicHeaderElement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicHeaderElement.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicHeaderElement"));
			global::org.apache.http.message.BasicHeaderElement._equals33511 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.message.BasicHeaderElement._toString33512 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicHeaderElement._hashCode33513 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "hashCode", "()I");
			global::org.apache.http.message.BasicHeaderElement._clone33514 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.message.BasicHeaderElement._getName33515 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicHeaderElement._getValue33516 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicHeaderElement._getParameters33517 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "getParameters", "()[Lorg/apache/http/NameValuePair;");
			global::org.apache.http.message.BasicHeaderElement._getParameter33518 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "getParameter", "(I)Lorg/apache/http/NameValuePair;");
			global::org.apache.http.message.BasicHeaderElement._getParameterCount33519 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "getParameterCount", "()I");
			global::org.apache.http.message.BasicHeaderElement._getParameterByName33520 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "getParameterByName", "(Ljava/lang/String;)Lorg/apache/http/NameValuePair;");
			global::org.apache.http.message.BasicHeaderElement._BasicHeaderElement33521 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.message.BasicHeaderElement._BasicHeaderElement33522 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;[Lorg/apache/http/NameValuePair;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
