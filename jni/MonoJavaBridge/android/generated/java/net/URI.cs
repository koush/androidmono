namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class URI : java.lang.Object, java.lang.Comparable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static URI()
		{
			InitJNI();
		}
		internal URI(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals21839;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URI._equals21839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._equals21839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21840;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._toString21840)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._toString21840)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21841;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URI._hashCode21841);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._hashCode21841);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo21842;
		public int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URI._compareTo21842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._compareTo21842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo21843;
		public int compareTo(java.net.URI arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URI._compareTo21843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._compareTo21843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAbsolute21844;
		public bool isAbsolute()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URI._isAbsolute21844);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._isAbsolute21844);
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPath21845;
		public global::java.lang.String getPath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getPath21845)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getPath21845)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toURL21846;
		public global::java.net.URL toURL()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._toURL21846)) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._toURL21846)) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _resolve21847;
		public global::java.net.URI resolve(java.net.URI arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._resolve21847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._resolve21847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _resolve21848;
		public global::java.net.URI resolve(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._resolve21848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._resolve21848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _normalize21849;
		public global::java.net.URI normalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._normalize21849)) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._normalize21849)) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _isOpaque21850;
		public bool isOpaque()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URI._isOpaque21850);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._isOpaque21850);
		}
		public new global::java.lang.String Scheme
		{
			get
			{
				return getScheme();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScheme21851;
		public global::java.lang.String getScheme()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getScheme21851)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getScheme21851)) as java.lang.String;
		}
		public new global::java.lang.String Authority
		{
			get
			{
				return getAuthority();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAuthority21852;
		public global::java.lang.String getAuthority()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getAuthority21852)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getAuthority21852)) as java.lang.String;
		}
		public new global::java.lang.String Fragment
		{
			get
			{
				return getFragment();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFragment21853;
		public global::java.lang.String getFragment()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getFragment21853)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getFragment21853)) as java.lang.String;
		}
		public new global::java.lang.String Query
		{
			get
			{
				return getQuery();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQuery21854;
		public global::java.lang.String getQuery()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getQuery21854)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getQuery21854)) as java.lang.String;
		}
		public new global::java.lang.String UserInfo
		{
			get
			{
				return getUserInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUserInfo21855;
		public global::java.lang.String getUserInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getUserInfo21855)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getUserInfo21855)) as java.lang.String;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort21856;
		public int getPort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URI._getPort21856);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getPort21856);
		}
		public new global::java.lang.String Host
		{
			get
			{
				return getHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHost21857;
		public global::java.lang.String getHost()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getHost21857)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getHost21857)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _create21858;
		public static global::java.net.URI create(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallStaticObjectMethod(java.net.URI.staticClass, global::java.net.URI._create21858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
		}
		public new global::java.lang.String SchemeSpecificPart
		{
			get
			{
				return getSchemeSpecificPart();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeSpecificPart21859;
		public global::java.lang.String getSchemeSpecificPart()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getSchemeSpecificPart21859)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getSchemeSpecificPart21859)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _parseServerAuthority21860;
		public global::java.net.URI parseServerAuthority()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._parseServerAuthority21860)) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._parseServerAuthority21860)) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _relativize21861;
		public global::java.net.URI relativize(java.net.URI arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._relativize21861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._relativize21861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
		}
		public new global::java.lang.String RawSchemeSpecificPart
		{
			get
			{
				return getRawSchemeSpecificPart();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawSchemeSpecificPart21862;
		public global::java.lang.String getRawSchemeSpecificPart()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawSchemeSpecificPart21862)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawSchemeSpecificPart21862)) as java.lang.String;
		}
		public new global::java.lang.String RawAuthority
		{
			get
			{
				return getRawAuthority();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawAuthority21863;
		public global::java.lang.String getRawAuthority()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawAuthority21863)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawAuthority21863)) as java.lang.String;
		}
		public new global::java.lang.String RawUserInfo
		{
			get
			{
				return getRawUserInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawUserInfo21864;
		public global::java.lang.String getRawUserInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawUserInfo21864)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawUserInfo21864)) as java.lang.String;
		}
		public new global::java.lang.String RawPath
		{
			get
			{
				return getRawPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawPath21865;
		public global::java.lang.String getRawPath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawPath21865)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawPath21865)) as java.lang.String;
		}
		public new global::java.lang.String RawQuery
		{
			get
			{
				return getRawQuery();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawQuery21866;
		public global::java.lang.String getRawQuery()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawQuery21866)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawQuery21866)) as java.lang.String;
		}
		public new global::java.lang.String RawFragment
		{
			get
			{
				return getRawFragment();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawFragment21867;
		public global::java.lang.String getRawFragment()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawFragment21867)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawFragment21867)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toASCIIString21868;
		public global::java.lang.String toASCIIString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._toASCIIString21868)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._toASCIIString21868)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _URI21869;
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI21869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URI21870;
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI21870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URI21871;
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI21871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URI21872;
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI21872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URI21873;
		public URI(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI21873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URI.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URI"));
			global::java.net.URI._equals21839 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.URI._toString21840 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.URI._hashCode21841 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "hashCode", "()I");
			global::java.net.URI._compareTo21842 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.net.URI._compareTo21843 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "compareTo", "(Ljava/net/URI;)I");
			global::java.net.URI._isAbsolute21844 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "isAbsolute", "()Z");
			global::java.net.URI._getPath21845 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getPath", "()Ljava/lang/String;");
			global::java.net.URI._toURL21846 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "toURL", "()Ljava/net/URL;");
			global::java.net.URI._resolve21847 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "resolve", "(Ljava/net/URI;)Ljava/net/URI;");
			global::java.net.URI._resolve21848 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "resolve", "(Ljava/lang/String;)Ljava/net/URI;");
			global::java.net.URI._normalize21849 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "normalize", "()Ljava/net/URI;");
			global::java.net.URI._isOpaque21850 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "isOpaque", "()Z");
			global::java.net.URI._getScheme21851 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getScheme", "()Ljava/lang/String;");
			global::java.net.URI._getAuthority21852 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getAuthority", "()Ljava/lang/String;");
			global::java.net.URI._getFragment21853 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getFragment", "()Ljava/lang/String;");
			global::java.net.URI._getQuery21854 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getQuery", "()Ljava/lang/String;");
			global::java.net.URI._getUserInfo21855 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getUserInfo", "()Ljava/lang/String;");
			global::java.net.URI._getPort21856 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getPort", "()I");
			global::java.net.URI._getHost21857 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getHost", "()Ljava/lang/String;");
			global::java.net.URI._create21858 = @__env.GetStaticMethodIDNoThrow(global::java.net.URI.staticClass, "create", "(Ljava/lang/String;)Ljava/net/URI;");
			global::java.net.URI._getSchemeSpecificPart21859 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getSchemeSpecificPart", "()Ljava/lang/String;");
			global::java.net.URI._parseServerAuthority21860 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "parseServerAuthority", "()Ljava/net/URI;");
			global::java.net.URI._relativize21861 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "relativize", "(Ljava/net/URI;)Ljava/net/URI;");
			global::java.net.URI._getRawSchemeSpecificPart21862 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawSchemeSpecificPart", "()Ljava/lang/String;");
			global::java.net.URI._getRawAuthority21863 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawAuthority", "()Ljava/lang/String;");
			global::java.net.URI._getRawUserInfo21864 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawUserInfo", "()Ljava/lang/String;");
			global::java.net.URI._getRawPath21865 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawPath", "()Ljava/lang/String;");
			global::java.net.URI._getRawQuery21866 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawQuery", "()Ljava/lang/String;");
			global::java.net.URI._getRawFragment21867 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawFragment", "()Ljava/lang/String;");
			global::java.net.URI._toASCIIString21868 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "toASCIIString", "()Ljava/lang/String;");
			global::java.net.URI._URI21869 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URI._URI21870 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URI._URI21871 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URI._URI21872 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URI._URI21873 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
