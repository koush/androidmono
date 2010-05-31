namespace javax.security.auth.x500
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class X500Principal : java.lang.Object, java.security.Principal, java.io.Serializable
	{
		internal static global::java.lang.Class staticClass;
		static X500Principal()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::javax.security.auth.x500.X500Principal), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::javax.security.auth.x500.X500Principal(@__env);
			}
		}
		internal X500Principal(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode13266;
		public sealed override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::javax.security.auth.x500.X500Principal._hashCode13266);
			else
				return @__env.CallNonVirtualIntMethod(this, global::javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._hashCode13266);
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals13267;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::javax.security.auth.x500.X500Principal._equals13267, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._equals13267, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13268;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::javax.security.auth.x500.X500Principal._toString13268));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._toString13268));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName13269;
		public global::java.lang.String getName(java.lang.String arg0, java.util.Map arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::javax.security.auth.x500.X500Principal._getName13269, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._getName13269, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName13270;
		public global::java.lang.String getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::javax.security.auth.x500.X500Principal._getName13270));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._getName13270));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName13271;
		public global::java.lang.String getName(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::javax.security.auth.x500.X500Principal._getName13271, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._getName13271, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEncoded13272;
		public byte[] getEncoded() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::javax.security.auth.x500.X500Principal._getEncoded13272));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._getEncoded13272));
		}
		internal static global::net.sf.jni4net.jni.MethodId _X500Principal13273;
		public X500Principal(java.io.InputStream arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._X500Principal13273, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _X500Principal13274;
		public X500Principal(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._X500Principal13274, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _X500Principal13275;
		public X500Principal(java.lang.String arg0, java.util.Map arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._X500Principal13275, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _X500Principal13276;
		public X500Principal(byte[] arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(javax.security.auth.x500.X500Principal.staticClass, global::javax.security.auth.x500.X500Principal._X500Principal13276, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::javax.security.auth.x500.X500Principal.staticClass = @__class;
			global::javax.security.auth.x500.X500Principal._hashCode13266 = @__env.GetMethodID(global::javax.security.auth.x500.X500Principal.staticClass, "hashCode", "()I");
			global::javax.security.auth.x500.X500Principal._equals13267 = @__env.GetMethodID(global::javax.security.auth.x500.X500Principal.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::javax.security.auth.x500.X500Principal._toString13268 = @__env.GetMethodID(global::javax.security.auth.x500.X500Principal.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.security.auth.x500.X500Principal._getName13269 = @__env.GetMethodID(global::javax.security.auth.x500.X500Principal.staticClass, "getName", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;");
			global::javax.security.auth.x500.X500Principal._getName13270 = @__env.GetMethodID(global::javax.security.auth.x500.X500Principal.staticClass, "getName", "()Ljava/lang/String;");
			global::javax.security.auth.x500.X500Principal._getName13271 = @__env.GetMethodID(global::javax.security.auth.x500.X500Principal.staticClass, "getName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::javax.security.auth.x500.X500Principal._getEncoded13272 = @__env.GetMethodID(global::javax.security.auth.x500.X500Principal.staticClass, "getEncoded", "()[B");
			global::javax.security.auth.x500.X500Principal._X500Principal13273 = @__env.GetMethodID(global::javax.security.auth.x500.X500Principal.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::javax.security.auth.x500.X500Principal._X500Principal13274 = @__env.GetMethodID(global::javax.security.auth.x500.X500Principal.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::javax.security.auth.x500.X500Principal._X500Principal13275 = @__env.GetMethodID(global::javax.security.auth.x500.X500Principal.staticClass, "<init>", "(Ljava/lang/String;Ljava/util/Map;)V");
			global::javax.security.auth.x500.X500Principal._X500Principal13276 = @__env.GetMethodID(global::javax.security.auth.x500.X500Principal.staticClass, "<init>", "([B)V");
		}
	}
}
