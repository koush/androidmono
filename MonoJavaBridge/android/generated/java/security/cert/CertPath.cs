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
			internal static global::MonoJavaBridge.MethodId _readResolve23479;
			protected virtual global::java.lang.Object readResolve()
			{
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertPath.CertPathRep.staticClass, global::java.security.cert.CertPath.CertPathRep._readResolve23479)) as java.lang.Object;
			}
			internal static global::MonoJavaBridge.MethodId _CertPathRep23480;
			protected CertPathRep(java.lang.String arg0, byte[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPath.CertPathRep.staticClass, global::java.security.cert.CertPath.CertPathRep._CertPathRep23480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			static CertPathRep()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.cert.CertPath.CertPathRep.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPath$CertPathRep"));
				global::java.security.cert.CertPath.CertPathRep._readResolve23479 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.CertPathRep.staticClass, "readResolve", "()Ljava/lang/Object;");
				global::java.security.cert.CertPath.CertPathRep._CertPathRep23480 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.CertPathRep.staticClass, "<init>", "(Ljava/lang/String;[B)V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _equals23481;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._equals23481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString23482;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._toString23482)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode23483;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._hashCode23483);
		}
		internal static global::MonoJavaBridge.MethodId _getCertificates23484;
		public abstract global::java.util.List getCertificates();
		internal static global::MonoJavaBridge.MethodId _getType23485;
		public virtual global::java.lang.String getType()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._getType23485)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23486;
		public abstract byte[] getEncoded();
		internal static global::MonoJavaBridge.MethodId _getEncoded23487;
		public abstract byte[] getEncoded(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _writeReplace23488;
		protected virtual global::java.lang.Object writeReplace()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._writeReplace23488)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getEncodings23489;
		public abstract global::java.util.Iterator getEncodings();
		internal static global::MonoJavaBridge.MethodId _CertPath23490;
		protected CertPath(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._CertPath23490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CertPath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPath.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPath"));
			global::java.security.cert.CertPath._equals23481 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.cert.CertPath._toString23482 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.CertPath._hashCode23483 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "hashCode", "()I");
			global::java.security.cert.CertPath._getCertificates23484 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "getCertificates", "()Ljava/util/List;");
			global::java.security.cert.CertPath._getType23485 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "getType", "()Ljava/lang/String;");
			global::java.security.cert.CertPath._getEncoded23486 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "getEncoded", "()[B");
			global::java.security.cert.CertPath._getEncoded23487 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "getEncoded", "(Ljava/lang/String;)[B");
			global::java.security.cert.CertPath._writeReplace23488 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "writeReplace", "()Ljava/lang/Object;");
			global::java.security.cert.CertPath._getEncodings23489 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "getEncodings", "()Ljava/util/Iterator;");
			global::java.security.cert.CertPath._CertPath23490 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CertPath))]
	internal sealed partial class CertPath_ : java.security.cert.CertPath
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CertPath_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getCertificates23491;
		public override global::java.util.List getCertificates()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPath_._getCertificates23491)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23492;
		public override byte[] getEncoded()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPath_._getEncoded23492)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23493;
		public override byte[] getEncoded(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPath_._getEncoded23493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getEncodings23494;
		public override global::java.util.Iterator getEncodings()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPath_._getEncodings23494)) as java.util.Iterator;
		}
		static CertPath_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPath_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPath"));
			global::java.security.cert.CertPath_._getCertificates23491 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath_.staticClass, "getCertificates", "()Ljava/util/List;");
			global::java.security.cert.CertPath_._getEncoded23492 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath_.staticClass, "getEncoded", "()[B");
			global::java.security.cert.CertPath_._getEncoded23493 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath_.staticClass, "getEncoded", "(Ljava/lang/String;)[B");
			global::java.security.cert.CertPath_._getEncodings23494 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath_.staticClass, "getEncodings", "()Ljava/util/Iterator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
