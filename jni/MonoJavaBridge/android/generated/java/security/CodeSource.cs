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
		internal static global::MonoJavaBridge.MethodId _equals22806;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.CodeSource._equals22806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._equals22806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22807;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.CodeSource._toString22807)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._toString22807)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22808;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.CodeSource._hashCode22808);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._hashCode22808);
		}
		public new global::java.net.URL Location
		{
			get
			{
				return getLocation();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocation22809;
		public virtual global::java.net.URL getLocation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.CodeSource._getLocation22809)) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._getLocation22809)) as java.net.URL;
		}
		public new global::java.security.cert.Certificate[] Certificates
		{
			get
			{
				return getCertificates();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCertificates22810;
		public virtual global::java.security.cert.Certificate[] getCertificates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.CodeSource._getCertificates22810)) as java.security.cert.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._getCertificates22810)) as java.security.cert.Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _implies22811;
		public virtual bool implies(java.security.CodeSource arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.CodeSource._implies22811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._implies22811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.security.CodeSigner[] CodeSigners
		{
			get
			{
				return getCodeSigners();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCodeSigners22812;
		public virtual global::java.security.CodeSigner[] getCodeSigners() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.CodeSigner>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.CodeSource._getCodeSigners22812)) as java.security.CodeSigner[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.CodeSigner>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._getCodeSigners22812)) as java.security.CodeSigner[];
		}
		internal static global::MonoJavaBridge.MethodId _CodeSource22813;
		public CodeSource(java.net.URL arg0, java.security.CodeSigner[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.CodeSource.staticClass, global::java.security.CodeSource._CodeSource22813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CodeSource22814;
		public CodeSource(java.net.URL arg0, java.security.cert.Certificate[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.CodeSource.staticClass, global::java.security.CodeSource._CodeSource22814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.CodeSource.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/CodeSource"));
			global::java.security.CodeSource._equals22806 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.CodeSource._toString22807 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.CodeSource._hashCode22808 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "hashCode", "()I");
			global::java.security.CodeSource._getLocation22809 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "getLocation", "()Ljava/net/URL;");
			global::java.security.CodeSource._getCertificates22810 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "getCertificates", "()[Ljava/security/cert/Certificate;");
			global::java.security.CodeSource._implies22811 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "implies", "(Ljava/security/CodeSource;)Z");
			global::java.security.CodeSource._getCodeSigners22812 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "getCodeSigners", "()[Ljava/security/CodeSigner;");
			global::java.security.CodeSource._CodeSource22813 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "<init>", "(Ljava/net/URL;[Ljava/security/CodeSigner;)V");
			global::java.security.CodeSource._CodeSource22814 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "<init>", "(Ljava/net/URL;[Ljava/security/cert/Certificate;)V");
		}
	}
}
