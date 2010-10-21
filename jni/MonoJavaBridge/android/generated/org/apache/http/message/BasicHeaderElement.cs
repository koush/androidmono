namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHeaderElement : java.lang.Object, HeaderElement, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicHeaderElement()
		{
			InitJNI();
		}
		protected BasicHeaderElement(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals33392;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElement._equals33392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._equals33392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString33393;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElement._toString33393)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._toString33393)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode33394;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElement._hashCode33394);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._hashCode33394);
		}
		internal static global::MonoJavaBridge.MethodId _clone33395;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElement._clone33395)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._clone33395)) as java.lang.Object;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName33396;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElement._getName33396)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._getName33396)) as java.lang.String;
		}
		public new global::java.lang.String Value
		{
			get
			{
				return getValue();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValue33397;
		public virtual global::java.lang.String getValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElement._getValue33397)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._getValue33397)) as java.lang.String;
		}
		public new global::org.apache.http.NameValuePair[] Parameters
		{
			get
			{
				return getParameters();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameters33398;
		public virtual global::org.apache.http.NameValuePair[] getParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.NameValuePair>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElement._getParameters33398)) as org.apache.http.NameValuePair[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.NameValuePair>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._getParameters33398)) as org.apache.http.NameValuePair[];
		}
		internal static global::MonoJavaBridge.MethodId _getParameter33399;
		public virtual global::org.apache.http.NameValuePair getParameter(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElement._getParameter33399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.NameValuePair;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._getParameter33399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.NameValuePair;
		}
		public new int ParameterCount
		{
			get
			{
				return getParameterCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameterCount33400;
		public virtual int getParameterCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElement._getParameterCount33400);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._getParameterCount33400);
		}
		internal static global::MonoJavaBridge.MethodId _getParameterByName33401;
		public virtual global::org.apache.http.NameValuePair getParameterByName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElement._getParameterByName33401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.NameValuePair;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._getParameterByName33401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.NameValuePair;
		}
		internal static global::MonoJavaBridge.MethodId _BasicHeaderElement33402;
		public BasicHeaderElement(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._BasicHeaderElement33402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BasicHeaderElement33403;
		public BasicHeaderElement(java.lang.String arg0, java.lang.String arg1, org.apache.http.NameValuePair[] arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeaderElement.staticClass, global::org.apache.http.message.BasicHeaderElement._BasicHeaderElement33403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicHeaderElement.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicHeaderElement"));
			global::org.apache.http.message.BasicHeaderElement._equals33392 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.message.BasicHeaderElement._toString33393 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicHeaderElement._hashCode33394 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "hashCode", "()I");
			global::org.apache.http.message.BasicHeaderElement._clone33395 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.message.BasicHeaderElement._getName33396 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicHeaderElement._getValue33397 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicHeaderElement._getParameters33398 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "getParameters", "()[Lorg/apache/http/NameValuePair;");
			global::org.apache.http.message.BasicHeaderElement._getParameter33399 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "getParameter", "(I)Lorg/apache/http/NameValuePair;");
			global::org.apache.http.message.BasicHeaderElement._getParameterCount33400 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "getParameterCount", "()I");
			global::org.apache.http.message.BasicHeaderElement._getParameterByName33401 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "getParameterByName", "(Ljava/lang/String;)Lorg/apache/http/NameValuePair;");
			global::org.apache.http.message.BasicHeaderElement._BasicHeaderElement33402 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.message.BasicHeaderElement._BasicHeaderElement33403 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElement.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;[Lorg/apache/http/NameValuePair;)V");
		}
	}
}
