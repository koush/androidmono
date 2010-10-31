namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class URI : java.lang.Object, java.lang.Comparable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal URI(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.URI.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.net.URI._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URI.staticClass, "toString", "()Ljava/lang/String;", ref global::java.net.URI._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.URI.staticClass, "hashCode", "()I", ref global::java.net.URI._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.URI.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.net.URI._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public int compareTo(java.net.URI arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.URI.staticClass, "compareTo", "(Ljava/net/URI;)I", ref global::java.net.URI._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public bool isAbsolute()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.URI.staticClass, "isAbsolute", "()Z", ref global::java.net.URI._m5);
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public global::java.lang.String getPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URI.staticClass, "getPath", "()Ljava/lang/String;", ref global::java.net.URI._m6) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public global::java.net.URL toURL()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::java.net.URI.staticClass, "toURL", "()Ljava/net/URL;", ref global::java.net.URI._m7) as java.net.URL;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public global::java.net.URI resolve(java.net.URI arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URI>(this, global::java.net.URI.staticClass, "resolve", "(Ljava/net/URI;)Ljava/net/URI;", ref global::java.net.URI._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.URI;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public global::java.net.URI resolve(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URI>(this, global::java.net.URI.staticClass, "resolve", "(Ljava/lang/String;)Ljava/net/URI;", ref global::java.net.URI._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.URI;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public global::java.net.URI normalize()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URI>(this, global::java.net.URI.staticClass, "normalize", "()Ljava/net/URI;", ref global::java.net.URI._m10) as java.net.URI;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public bool isOpaque()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.URI.staticClass, "isOpaque", "()Z", ref global::java.net.URI._m11);
		}
		public new global::java.lang.String Scheme
		{
			get
			{
				return getScheme();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public global::java.lang.String getScheme()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URI.staticClass, "getScheme", "()Ljava/lang/String;", ref global::java.net.URI._m12) as java.lang.String;
		}
		public new global::java.lang.String Authority
		{
			get
			{
				return getAuthority();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public global::java.lang.String getAuthority()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URI.staticClass, "getAuthority", "()Ljava/lang/String;", ref global::java.net.URI._m13) as java.lang.String;
		}
		public new global::java.lang.String Fragment
		{
			get
			{
				return getFragment();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public global::java.lang.String getFragment()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URI.staticClass, "getFragment", "()Ljava/lang/String;", ref global::java.net.URI._m14) as java.lang.String;
		}
		public new global::java.lang.String Query
		{
			get
			{
				return getQuery();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public global::java.lang.String getQuery()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URI.staticClass, "getQuery", "()Ljava/lang/String;", ref global::java.net.URI._m15) as java.lang.String;
		}
		public new global::java.lang.String UserInfo
		{
			get
			{
				return getUserInfo();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public global::java.lang.String getUserInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URI.staticClass, "getUserInfo", "()Ljava/lang/String;", ref global::java.net.URI._m16) as java.lang.String;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public int getPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.URI.staticClass, "getPort", "()I", ref global::java.net.URI._m17);
		}
		public new global::java.lang.String Host
		{
			get
			{
				return getHost();
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public global::java.lang.String getHost()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URI.staticClass, "getHost", "()Ljava/lang/String;", ref global::java.net.URI._m18) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static global::java.net.URI create(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URI._m19.native == global::System.IntPtr.Zero)
				global::java.net.URI._m19 = @__env.GetStaticMethodIDNoThrow(global::java.net.URI.staticClass, "create", "(Ljava/lang/String;)Ljava/net/URI;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallStaticObjectMethod(java.net.URI.staticClass, global::java.net.URI._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
		}
		public new global::java.lang.String SchemeSpecificPart
		{
			get
			{
				return getSchemeSpecificPart();
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public global::java.lang.String getSchemeSpecificPart()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URI.staticClass, "getSchemeSpecificPart", "()Ljava/lang/String;", ref global::java.net.URI._m20) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public global::java.net.URI parseServerAuthority()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URI>(this, global::java.net.URI.staticClass, "parseServerAuthority", "()Ljava/net/URI;", ref global::java.net.URI._m21) as java.net.URI;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public global::java.net.URI relativize(java.net.URI arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URI>(this, global::java.net.URI.staticClass, "relativize", "(Ljava/net/URI;)Ljava/net/URI;", ref global::java.net.URI._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.URI;
		}
		public new global::java.lang.String RawSchemeSpecificPart
		{
			get
			{
				return getRawSchemeSpecificPart();
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public global::java.lang.String getRawSchemeSpecificPart()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URI.staticClass, "getRawSchemeSpecificPart", "()Ljava/lang/String;", ref global::java.net.URI._m23) as java.lang.String;
		}
		public new global::java.lang.String RawAuthority
		{
			get
			{
				return getRawAuthority();
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public global::java.lang.String getRawAuthority()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URI.staticClass, "getRawAuthority", "()Ljava/lang/String;", ref global::java.net.URI._m24) as java.lang.String;
		}
		public new global::java.lang.String RawUserInfo
		{
			get
			{
				return getRawUserInfo();
			}
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public global::java.lang.String getRawUserInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URI.staticClass, "getRawUserInfo", "()Ljava/lang/String;", ref global::java.net.URI._m25) as java.lang.String;
		}
		public new global::java.lang.String RawPath
		{
			get
			{
				return getRawPath();
			}
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public global::java.lang.String getRawPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URI.staticClass, "getRawPath", "()Ljava/lang/String;", ref global::java.net.URI._m26) as java.lang.String;
		}
		public new global::java.lang.String RawQuery
		{
			get
			{
				return getRawQuery();
			}
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public global::java.lang.String getRawQuery()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URI.staticClass, "getRawQuery", "()Ljava/lang/String;", ref global::java.net.URI._m27) as java.lang.String;
		}
		public new global::java.lang.String RawFragment
		{
			get
			{
				return getRawFragment();
			}
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public global::java.lang.String getRawFragment()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URI.staticClass, "getRawFragment", "()Ljava/lang/String;", ref global::java.net.URI._m28) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public global::java.lang.String toASCIIString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URI.staticClass, "toASCIIString", "()Ljava/lang/String;", ref global::java.net.URI._m29) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URI._m30.native == global::System.IntPtr.Zero)
				global::java.net.URI._m30 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URI._m31.native == global::System.IntPtr.Zero)
				global::java.net.URI._m31 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URI._m32.native == global::System.IntPtr.Zero)
				global::java.net.URI._m32 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URI._m33.native == global::System.IntPtr.Zero)
				global::java.net.URI._m33 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public URI(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URI._m34.native == global::System.IntPtr.Zero)
				global::java.net.URI._m34 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static URI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URI.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URI"));
		}
	}
}
