namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.CertPath_))]
	public abstract partial class CertPath : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertPath()
		{
			InitJNI();
		}
		protected CertPath(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		protected partial class CertPathRep : java.lang.Object, java.io.Serializable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static CertPathRep()
			{
				InitJNI();
			}
			protected CertPathRep(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _readResolve23360;
			protected virtual global::java.lang.Object readResolve() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPath.CertPathRep._readResolve23360)) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPath.CertPathRep.staticClass, global::java.security.cert.CertPath.CertPathRep._readResolve23360)) as java.lang.Object;
			}
			internal static global::MonoJavaBridge.MethodId _CertPathRep23361;
			protected CertPathRep(java.lang.String arg0, byte[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPath.CertPathRep.staticClass, global::java.security.cert.CertPath.CertPathRep._CertPathRep23361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.cert.CertPath.CertPathRep.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPath$CertPathRep"));
				global::java.security.cert.CertPath.CertPathRep._readResolve23360 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.CertPathRep.staticClass, "readResolve", "()Ljava/lang/Object;");
				global::java.security.cert.CertPath.CertPathRep._CertPathRep23361 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.CertPathRep.staticClass, "<init>", "(Ljava/lang/String;[B)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _equals23362;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.CertPath._equals23362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._equals23362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString23363;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPath._toString23363)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._toString23363)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode23364;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.CertPath._hashCode23364);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._hashCode23364);
		}
		internal static global::MonoJavaBridge.MethodId _getCertificates23365;
		public abstract global::java.util.List getCertificates();
		internal static global::MonoJavaBridge.MethodId _getType23366;
		public virtual global::java.lang.String getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPath._getType23366)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._getType23366)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23367;
		public abstract byte[] getEncoded();
		internal static global::MonoJavaBridge.MethodId _getEncoded23368;
		public abstract byte[] getEncoded(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _writeReplace23369;
		protected virtual global::java.lang.Object writeReplace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPath._writeReplace23369)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._writeReplace23369)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getEncodings23370;
		public abstract global::java.util.Iterator getEncodings();
		internal static global::MonoJavaBridge.MethodId _CertPath23371;
		protected CertPath(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._CertPath23371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPath.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPath"));
			global::java.security.cert.CertPath._equals23362 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.cert.CertPath._toString23363 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.CertPath._hashCode23364 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "hashCode", "()I");
			global::java.security.cert.CertPath._getCertificates23365 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "getCertificates", "()Ljava/util/List;");
			global::java.security.cert.CertPath._getType23366 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "getType", "()Ljava/lang/String;");
			global::java.security.cert.CertPath._getEncoded23367 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "getEncoded", "()[B");
			global::java.security.cert.CertPath._getEncoded23368 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "getEncoded", "(Ljava/lang/String;)[B");
			global::java.security.cert.CertPath._writeReplace23369 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "writeReplace", "()Ljava/lang/Object;");
			global::java.security.cert.CertPath._getEncodings23370 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "getEncodings", "()Ljava/util/Iterator;");
			global::java.security.cert.CertPath._CertPath23371 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CertPath))]
	public sealed partial class CertPath_ : java.security.cert.CertPath
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertPath_()
		{
			InitJNI();
		}
		internal CertPath_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getCertificates23372;
		public override global::java.util.List getCertificates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPath_._getCertificates23372)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPath_.staticClass, global::java.security.cert.CertPath_._getCertificates23372)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23373;
		public override byte[] getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPath_._getEncoded23373)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPath_.staticClass, global::java.security.cert.CertPath_._getEncoded23373)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23374;
		public override byte[] getEncoded(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPath_._getEncoded23374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPath_.staticClass, global::java.security.cert.CertPath_._getEncoded23374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getEncodings23375;
		public override global::java.util.Iterator getEncodings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPath_._getEncodings23375)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPath_.staticClass, global::java.security.cert.CertPath_._getEncodings23375)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPath_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPath"));
			global::java.security.cert.CertPath_._getCertificates23372 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath_.staticClass, "getCertificates", "()Ljava/util/List;");
			global::java.security.cert.CertPath_._getEncoded23373 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath_.staticClass, "getEncoded", "()[B");
			global::java.security.cert.CertPath_._getEncoded23374 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath_.staticClass, "getEncoded", "(Ljava/lang/String;)[B");
			global::java.security.cert.CertPath_._getEncodings23375 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath_.staticClass, "getEncodings", "()Ljava/util/Iterator;");
		}
	}
}
