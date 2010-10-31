namespace javax.security.auth.x500
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class X500Principal : java.lang.Object, java.security.Principal, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal X500Principal(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.security.auth.x500.X500Principal.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::javax.security.auth.x500.X500Principal._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.security.auth.x500.X500Principal.staticClass, "toString", "()Ljava/lang/String;", ref global::javax.security.auth.x500.X500Principal._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.security.auth.x500.X500Principal.staticClass, "hashCode", "()I", ref global::javax.security.auth.x500.X500Principal._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.lang.String getName(java.lang.String arg0, java.util.Map arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.security.auth.x500.X500Principal.staticClass, "getName", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;", ref global::javax.security.auth.x500.X500Principal._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.security.auth.x500.X500Principal.staticClass, "getName", "()Ljava/lang/String;", ref global::javax.security.auth.x500.X500Principal._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public global::java.lang.String getName(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.security.auth.x500.X500Principal.staticClass, "getName", "(Ljava/lang/String;)Ljava/lang/String;", ref global::javax.security.auth.x500.X500Principal._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		public new byte[] Encoded
		{
			get
			{
				return getEncoded();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public byte[] getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.security.auth.x500.X500Principal.staticClass, "getEncoded", "()[B", ref global::javax.security.auth.x500.X500Principal._m6) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public X500Principal(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.x500.X500Principal._m7.native == global::System.IntPtr.Zero)
				global::javax.security.auth.x500.X500Principal._m7 = @__env.GetMethodIDNoThrow(global::javax.security.auth.x500.X500Principal.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public X500Principal(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.x500.X500Principal._m8.native == global::System.IntPtr.Zero)
				global::javax.security.auth.x500.X500Principal._m8 = @__env.GetMethodIDNoThrow(global::javax.security.auth.x500.X500Principal.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public X500Principal(java.lang.String arg0, java.util.Map arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.x500.X500Principal._m9.native == global::System.IntPtr.Zero)
				global::javax.security.auth.x500.X500Principal._m9 = @__env.GetMethodIDNoThrow(global::javax.security.auth.x500.X500Principal.staticClass, "<init>", "(Ljava/lang/String;Ljava/util/Map;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public X500Principal(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.x500.X500Principal._m10.native == global::System.IntPtr.Zero)
				global::javax.security.auth.x500.X500Principal._m10 = @__env.GetMethodIDNoThrow(global::javax.security.auth.x500.X500Principal.staticClass, "<init>", "([B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		static X500Principal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.x500.X500Principal.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/x500/X500Principal"));
		}
	}
}
