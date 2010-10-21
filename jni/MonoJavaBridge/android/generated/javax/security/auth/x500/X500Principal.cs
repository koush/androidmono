namespace javax.security.auth.x500
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class X500Principal : java.lang.Object, java.security.Principal, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static X500Principal()
		{
			InitJNI();
		}
		internal X500Principal(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals30091;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.security.auth.x500.X500Principal._equals30091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._equals30091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString30092;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.x500.X500Principal._toString30092)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._toString30092)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode30093;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.security.auth.x500.X500Principal._hashCode30093);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._hashCode30093);
		}
		internal static global::MonoJavaBridge.MethodId _getName30094;
		public global::java.lang.String getName(java.lang.String arg0, java.util.Map arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.x500.X500Principal._getName30094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._getName30094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName30095;
		public global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.x500.X500Principal._getName30095)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._getName30095)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getName30096;
		public global::java.lang.String getName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.x500.X500Principal._getName30096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._getName30096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new byte[] Encoded
		{
			get
			{
				return getEncoded();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded30097;
		public byte[] getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.x500.X500Principal._getEncoded30097)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._getEncoded30097)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _X500Principal30098;
		public X500Principal(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._X500Principal30098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _X500Principal30099;
		public X500Principal(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._X500Principal30099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _X500Principal30100;
		public X500Principal(java.lang.String arg0, java.util.Map arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._X500Principal30100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _X500Principal30101;
		public X500Principal(byte[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._X500Principal30101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String RFC1779
		{
			get
			{
				return "RFC1779";
			}
		}
		public static global::java.lang.String RFC2253
		{
			get
			{
				return "RFC2253";
			}
		}
		public static global::java.lang.String CANONICAL
		{
			get
			{
				return "CANONICAL";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.x500.X500Principal.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/x500/X500Principal"));
			global::javax.security.auth.x500.X500Principal._equals30091 = @__env.GetMethodIDNoThrow(global::javax.security.auth.x500.X500Principal.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::javax.security.auth.x500.X500Principal._toString30092 = @__env.GetMethodIDNoThrow(global::javax.security.auth.x500.X500Principal.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.security.auth.x500.X500Principal._hashCode30093 = @__env.GetMethodIDNoThrow(global::javax.security.auth.x500.X500Principal.staticClass, "hashCode", "()I");
			global::javax.security.auth.x500.X500Principal._getName30094 = @__env.GetMethodIDNoThrow(global::javax.security.auth.x500.X500Principal.staticClass, "getName", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;");
			global::javax.security.auth.x500.X500Principal._getName30095 = @__env.GetMethodIDNoThrow(global::javax.security.auth.x500.X500Principal.staticClass, "getName", "()Ljava/lang/String;");
			global::javax.security.auth.x500.X500Principal._getName30096 = @__env.GetMethodIDNoThrow(global::javax.security.auth.x500.X500Principal.staticClass, "getName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::javax.security.auth.x500.X500Principal._getEncoded30097 = @__env.GetMethodIDNoThrow(global::javax.security.auth.x500.X500Principal.staticClass, "getEncoded", "()[B");
			global::javax.security.auth.x500.X500Principal._X500Principal30098 = @__env.GetMethodIDNoThrow(global::javax.security.auth.x500.X500Principal.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::javax.security.auth.x500.X500Principal._X500Principal30099 = @__env.GetMethodIDNoThrow(global::javax.security.auth.x500.X500Principal.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::javax.security.auth.x500.X500Principal._X500Principal30100 = @__env.GetMethodIDNoThrow(global::javax.security.auth.x500.X500Principal.staticClass, "<init>", "(Ljava/lang/String;Ljava/util/Map;)V");
			global::javax.security.auth.x500.X500Principal._X500Principal30101 = @__env.GetMethodIDNoThrow(global::javax.security.auth.x500.X500Principal.staticClass, "<init>", "([B)V");
		}
	}
}
