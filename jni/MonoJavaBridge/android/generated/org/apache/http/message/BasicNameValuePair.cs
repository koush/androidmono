namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicNameValuePair : java.lang.Object, NameValuePair, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicNameValuePair(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals33632;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair._equals33632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair.staticClass, global::org.apache.http.message.BasicNameValuePair._equals33632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString33633;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair._toString33633)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair.staticClass, global::org.apache.http.message.BasicNameValuePair._toString33633)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode33634;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair._hashCode33634);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair.staticClass, global::org.apache.http.message.BasicNameValuePair._hashCode33634);
		}
		internal static global::MonoJavaBridge.MethodId _clone33635;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair._clone33635)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair.staticClass, global::org.apache.http.message.BasicNameValuePair._clone33635)) as java.lang.Object;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName33636;
		public virtual global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair._getName33636)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair.staticClass, global::org.apache.http.message.BasicNameValuePair._getName33636)) as java.lang.String;
		}
		public new global::java.lang.String Value
		{
			get
			{
				return getValue();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValue33637;
		public virtual global::java.lang.String getValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair._getValue33637)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicNameValuePair.staticClass, global::org.apache.http.message.BasicNameValuePair._getValue33637)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _BasicNameValuePair33638;
		public BasicNameValuePair(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicNameValuePair.staticClass, global::org.apache.http.message.BasicNameValuePair._BasicNameValuePair33638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static BasicNameValuePair()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicNameValuePair.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicNameValuePair"));
			global::org.apache.http.message.BasicNameValuePair._equals33632 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicNameValuePair.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.message.BasicNameValuePair._toString33633 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicNameValuePair.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicNameValuePair._hashCode33634 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicNameValuePair.staticClass, "hashCode", "()I");
			global::org.apache.http.message.BasicNameValuePair._clone33635 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicNameValuePair.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.message.BasicNameValuePair._getName33636 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicNameValuePair.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicNameValuePair._getValue33637 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicNameValuePair.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicNameValuePair._BasicNameValuePair33638 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicNameValuePair.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
