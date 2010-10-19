namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CodeSource : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CodeSource()
		{
			InitJNI();
		}
		protected CodeSource(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals17208;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.CodeSource._equals17208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._equals17208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString17209;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.CodeSource._toString17209)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._toString17209)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode17210;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.CodeSource._hashCode17210);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._hashCode17210);
		}
		public new global::java.net.URL Location
		{
			get
			{
				return getLocation();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocation17211;
		public virtual global::java.net.URL getLocation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.CodeSource._getLocation17211)) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._getLocation17211)) as java.net.URL;
		}
		public new global::java.security.cert.Certificate[] Certificates
		{
			get
			{
				return getCertificates();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCertificates17212;
		public virtual global::java.security.cert.Certificate[] getCertificates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.CodeSource._getCertificates17212)) as java.security.cert.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._getCertificates17212)) as java.security.cert.Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _implies17213;
		public virtual bool implies(java.security.CodeSource arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.CodeSource._implies17213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._implies17213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.security.CodeSigner[] CodeSigners
		{
			get
			{
				return getCodeSigners();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCodeSigners17214;
		public virtual global::java.security.CodeSigner[] getCodeSigners() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.CodeSigner>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.CodeSource._getCodeSigners17214)) as java.security.CodeSigner[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.CodeSigner>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._getCodeSigners17214)) as java.security.CodeSigner[];
		}
		internal static global::MonoJavaBridge.MethodId _CodeSource17215;
		public CodeSource(java.net.URL arg0, java.security.CodeSigner[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.CodeSource.staticClass, global::java.security.CodeSource._CodeSource17215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CodeSource17216;
		public CodeSource(java.net.URL arg0, java.security.cert.Certificate[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.CodeSource.staticClass, global::java.security.CodeSource._CodeSource17216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.CodeSource.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/CodeSource"));
			global::java.security.CodeSource._equals17208 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.CodeSource._toString17209 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.CodeSource._hashCode17210 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "hashCode", "()I");
			global::java.security.CodeSource._getLocation17211 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "getLocation", "()Ljava/net/URL;");
			global::java.security.CodeSource._getCertificates17212 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "getCertificates", "()[Ljava/security/cert/Certificate;");
			global::java.security.CodeSource._implies17213 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "implies", "(Ljava/security/CodeSource;)Z");
			global::java.security.CodeSource._getCodeSigners17214 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "getCodeSigners", "()[Ljava/security/CodeSigner;");
			global::java.security.CodeSource._CodeSource17215 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "<init>", "(Ljava/net/URL;[Ljava/security/CodeSigner;)V");
			global::java.security.CodeSource._CodeSource17216 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "<init>", "(Ljava/net/URL;[Ljava/security/cert/Certificate;)V");
		}
	}
}
