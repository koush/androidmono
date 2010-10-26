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
			internal static global::MonoJavaBridge.MethodId _readResolve23478;
			protected virtual global::java.lang.Object readResolve() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPath.CertPathRep._readResolve23478)) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPath.CertPathRep.staticClass, global::java.security.cert.CertPath.CertPathRep._readResolve23478)) as java.lang.Object;
			}
			internal static global::MonoJavaBridge.MethodId _CertPathRep23479;
			protected CertPathRep(java.lang.String arg0, byte[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPath.CertPathRep.staticClass, global::java.security.cert.CertPath.CertPathRep._CertPathRep23479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.cert.CertPath.CertPathRep.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPath$CertPathRep"));
				global::java.security.cert.CertPath.CertPathRep._readResolve23478 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.CertPathRep.staticClass, "readResolve", "()Ljava/lang/Object;");
				global::java.security.cert.CertPath.CertPathRep._CertPathRep23479 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.CertPathRep.staticClass, "<init>", "(Ljava/lang/String;[B)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _equals23480;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.CertPath._equals23480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._equals23480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString23481;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPath._toString23481)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._toString23481)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode23482;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.CertPath._hashCode23482);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._hashCode23482);
		}
		internal static global::MonoJavaBridge.MethodId _getCertificates23483;
		public abstract global::java.util.List getCertificates();
		internal static global::MonoJavaBridge.MethodId _getType23484;
		public virtual global::java.lang.String getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPath._getType23484)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._getType23484)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23485;
		public abstract byte[] getEncoded();
		internal static global::MonoJavaBridge.MethodId _getEncoded23486;
		public abstract byte[] getEncoded(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _writeReplace23487;
		protected virtual global::java.lang.Object writeReplace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPath._writeReplace23487)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._writeReplace23487)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getEncodings23488;
		public abstract global::java.util.Iterator getEncodings();
		internal static global::MonoJavaBridge.MethodId _CertPath23489;
		protected CertPath(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._CertPath23489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPath.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPath"));
			global::java.security.cert.CertPath._equals23480 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.cert.CertPath._toString23481 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.CertPath._hashCode23482 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "hashCode", "()I");
			global::java.security.cert.CertPath._getCertificates23483 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "getCertificates", "()Ljava/util/List;");
			global::java.security.cert.CertPath._getType23484 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "getType", "()Ljava/lang/String;");
			global::java.security.cert.CertPath._getEncoded23485 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "getEncoded", "()[B");
			global::java.security.cert.CertPath._getEncoded23486 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "getEncoded", "(Ljava/lang/String;)[B");
			global::java.security.cert.CertPath._writeReplace23487 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "writeReplace", "()Ljava/lang/Object;");
			global::java.security.cert.CertPath._getEncodings23488 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "getEncodings", "()Ljava/util/Iterator;");
			global::java.security.cert.CertPath._CertPath23489 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CertPath))]
	internal sealed partial class CertPath_ : java.security.cert.CertPath
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertPath_()
		{
			InitJNI();
		}
		internal CertPath_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getCertificates23490;
		public override global::java.util.List getCertificates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPath_._getCertificates23490)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPath_.staticClass, global::java.security.cert.CertPath_._getCertificates23490)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23491;
		public override byte[] getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPath_._getEncoded23491)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPath_.staticClass, global::java.security.cert.CertPath_._getEncoded23491)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23492;
		public override byte[] getEncoded(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPath_._getEncoded23492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPath_.staticClass, global::java.security.cert.CertPath_._getEncoded23492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getEncodings23493;
		public override global::java.util.Iterator getEncodings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPath_._getEncodings23493)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPath_.staticClass, global::java.security.cert.CertPath_._getEncodings23493)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPath_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPath"));
			global::java.security.cert.CertPath_._getCertificates23490 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath_.staticClass, "getCertificates", "()Ljava/util/List;");
			global::java.security.cert.CertPath_._getEncoded23491 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath_.staticClass, "getEncoded", "()[B");
			global::java.security.cert.CertPath_._getEncoded23492 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath_.staticClass, "getEncoded", "(Ljava/lang/String;)[B");
			global::java.security.cert.CertPath_._getEncodings23493 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPath_.staticClass, "getEncodings", "()Ljava/util/Iterator;");
		}
	}
}
