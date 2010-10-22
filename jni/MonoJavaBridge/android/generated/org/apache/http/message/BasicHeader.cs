namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHeader : java.lang.Object, Header, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicHeader()
		{
			InitJNI();
		}
		protected BasicHeader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString33386;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeader._toString33386)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeader.staticClass, global::org.apache.http.message.BasicHeader._toString33386)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone33387;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeader._clone33387)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeader.staticClass, global::org.apache.http.message.BasicHeader._clone33387)) as java.lang.Object;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName33388;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeader._getName33388)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeader.staticClass, global::org.apache.http.message.BasicHeader._getName33388)) as java.lang.String;
		}
		public new global::java.lang.String Value
		{
			get
			{
				return getValue();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValue33389;
		public virtual global::java.lang.String getValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeader._getValue33389)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeader.staticClass, global::org.apache.http.message.BasicHeader._getValue33389)) as java.lang.String;
		}
		public new global::org.apache.http.HeaderElement[] Elements
		{
			get
			{
				return getElements();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getElements33390;
		public virtual global::org.apache.http.HeaderElement[] getElements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.HeaderElement>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeader._getElements33390)) as org.apache.http.HeaderElement[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.HeaderElement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeader.staticClass, global::org.apache.http.message.BasicHeader._getElements33390)) as org.apache.http.HeaderElement[];
		}
		internal static global::MonoJavaBridge.MethodId _BasicHeader33391;
		public BasicHeader(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeader.staticClass, global::org.apache.http.message.BasicHeader._BasicHeader33391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicHeader.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicHeader"));
			global::org.apache.http.message.BasicHeader._toString33386 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeader.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicHeader._clone33387 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeader.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.message.BasicHeader._getName33388 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeader.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicHeader._getValue33389 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeader.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicHeader._getElements33390 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeader.staticClass, "getElements", "()[Lorg/apache/http/HeaderElement;");
			global::org.apache.http.message.BasicHeader._BasicHeader33391 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeader.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
