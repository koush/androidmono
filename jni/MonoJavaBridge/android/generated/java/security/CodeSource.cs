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
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12427;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.security.CodeSource._hashCode12427);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._hashCode12427);
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals12428;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.security.CodeSource._equals12428, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._equals12428, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString12429;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.CodeSource._toString12429));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._toString12429));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLocation12430;
		public virtual global::java.net.URL getLocation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URL>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.CodeSource._getLocation12430));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URL>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._getLocation12430));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCertificates12431;
		public virtual global::java.security.cert.Certificate[] getCertificates() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.security.CodeSource._getCertificates12431));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._getCertificates12431));
		}
		internal static global::net.sf.jni4net.jni.MethodId _implies12432;
		public virtual bool implies(java.security.CodeSource arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.security.CodeSource._implies12432, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._implies12432, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCodeSigners12433;
		public virtual global::java.security.CodeSigner[] getCodeSigners() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.security.CodeSource._getCodeSigners12433));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._getCodeSigners12433));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CodeSource12434;
		public CodeSource(java.net.URL arg0, java.security.cert.Certificate[] arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.security.CodeSource.staticClass, global::java.security.CodeSource._CodeSource12434, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CodeSource12435;
		public CodeSource(java.net.URL arg0, java.security.CodeSigner[] arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.security.CodeSource.staticClass, global::java.security.CodeSource._CodeSource12435, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.security.CodeSource.staticClass = @__class;
			global::java.security.CodeSource._hashCode12427 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "hashCode", "()I");
			global::java.security.CodeSource._equals12428 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.CodeSource._toString12429 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.CodeSource._getLocation12430 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "getLocation", "()Ljava/net/URL;");
			global::java.security.CodeSource._getCertificates12431 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "getCertificates", "()[Ljava/security/cert/Certificate;");
			global::java.security.CodeSource._implies12432 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "implies", "(Ljava/security/CodeSource;)Z");
			global::java.security.CodeSource._getCodeSigners12433 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "getCodeSigners", "()[Ljava/security/CodeSigner;");
			global::java.security.CodeSource._CodeSource12434 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "<init>", "(Ljava/net/URL;[Ljava/security/cert/Certificate;)V");
			global::java.security.CodeSource._CodeSource12435 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "<init>", "(Ljava/net/URL;[Ljava/security/CodeSigner;)V");
		}
	}
}
