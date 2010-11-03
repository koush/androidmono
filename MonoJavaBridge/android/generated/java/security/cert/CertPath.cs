namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.CertPath_))]
	public abstract partial class CertPath : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CertPath(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		protected partial class CertPathRep : java.lang.Object, java.io.Serializable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected CertPathRep(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			protected virtual global::java.lang.Object readResolve()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertPath.CertPathRep.staticClass, "readResolve", "()Ljava/lang/Object;", ref global::java.security.cert.CertPath.CertPathRep._m0) as java.lang.Object;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			protected CertPathRep(java.lang.String arg0, byte[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.cert.CertPath.CertPathRep._m1.native == global::System.IntPtr.Zero)
					global::java.security.cert.CertPath.CertPathRep._m1 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.CertPathRep.staticClass, "<init>", "(Ljava/lang/String;[B)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPath.CertPathRep.staticClass, global::java.security.cert.CertPath.CertPathRep._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			static CertPathRep()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.cert.CertPath.CertPathRep.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPath$CertPathRep"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.CertPath.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.cert.CertPath._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.CertPath.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.cert.CertPath._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.cert.CertPath.staticClass, "hashCode", "()I", ref global::java.security.cert.CertPath._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract global::java.util.List getCertificates();
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.CertPath.staticClass, "getType", "()Ljava/lang/String;", ref global::java.security.cert.CertPath._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract byte[] getEncoded();
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract byte[] getEncoded(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m7;
		protected virtual global::java.lang.Object writeReplace()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertPath.staticClass, "writeReplace", "()Ljava/lang/Object;", ref global::java.security.cert.CertPath._m7) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract global::java.util.Iterator getEncodings();
		private static global::MonoJavaBridge.MethodId _m9;
		protected CertPath(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertPath._m9.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertPath._m9 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CertPath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPath.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPath"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CertPath))]
	internal sealed partial class CertPath_ : java.security.cert.CertPath
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CertPath_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.util.List getCertificates()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.security.cert.CertPath_.staticClass, "getCertificates", "()Ljava/util/List;", ref global::java.security.cert.CertPath_._m0) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override byte[] getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.CertPath_.staticClass, "getEncoded", "()[B", ref global::java.security.cert.CertPath_._m1) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override byte[] getEncoded(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.CertPath_.staticClass, "getEncoded", "(Ljava/lang/String;)[B", ref global::java.security.cert.CertPath_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.util.Iterator getEncodings()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.security.cert.CertPath_.staticClass, "getEncodings", "()Ljava/util/Iterator;", ref global::java.security.cert.CertPath_._m3) as java.util.Iterator;
		}
		static CertPath_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPath_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPath"));
		}
	}
}
