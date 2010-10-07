namespace java.security
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class CodeSource : java.lang.Object, java.io.Serializable
	{
		internal static global::java.lang.Class staticClass;
		static CodeSource()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.security.CodeSource), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.security.CodeSource(@__env);
			}
		}
		protected CodeSource(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals13156;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.security.CodeSource._equals13156, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._equals13156, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13157;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.CodeSource._toString13157));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._toString13157));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode13158;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.security.CodeSource._hashCode13158);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._hashCode13158);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLocation13159;
		public virtual global::java.net.URL getLocation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URL>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.CodeSource._getLocation13159));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URL>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._getLocation13159));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCertificates13160;
		public virtual global::java.security.cert.Certificate[] getCertificates() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.security.CodeSource._getCertificates13160));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._getCertificates13160));
		}
		internal static global::net.sf.jni4net.jni.MethodId _implies13161;
		public virtual bool implies(java.security.CodeSource arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.security.CodeSource._implies13161, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._implies13161, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCodeSigners13162;
		public virtual global::java.security.CodeSigner[] getCodeSigners() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.security.CodeSource._getCodeSigners13162));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._getCodeSigners13162));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CodeSource13163;
		public CodeSource(java.net.URL arg0, java.security.CodeSigner[] arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.security.CodeSource.staticClass, global::java.security.CodeSource._CodeSource13163, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CodeSource13164;
		public CodeSource(java.net.URL arg0, java.security.cert.Certificate[] arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.security.CodeSource.staticClass, global::java.security.CodeSource._CodeSource13164, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.security.CodeSource.staticClass = @__class;
			global::java.security.CodeSource._equals13156 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.CodeSource._toString13157 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.CodeSource._hashCode13158 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "hashCode", "()I");
			global::java.security.CodeSource._getLocation13159 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "getLocation", "()Ljava/net/URL;");
			global::java.security.CodeSource._getCertificates13160 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "getCertificates", "()[Ljava/security/cert/Certificate;");
			global::java.security.CodeSource._implies13161 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "implies", "(Ljava/security/CodeSource;)Z");
			global::java.security.CodeSource._getCodeSigners13162 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "getCodeSigners", "()[Ljava/security/CodeSigner;");
			global::java.security.CodeSource._CodeSource13163 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "<init>", "(Ljava/net/URL;[Ljava/security/CodeSigner;)V");
			global::java.security.CodeSource._CodeSource13164 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "<init>", "(Ljava/net/URL;[Ljava/security/cert/Certificate;)V");
		}
	}
}
