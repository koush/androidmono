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
		internal static global::MonoJavaBridge.MethodId _equals21720;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URI._equals21720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._equals21720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21721;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._toString21721)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._toString21721)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21722;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URI._hashCode21722);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._hashCode21722);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo21723;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URI._compareTo21723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._compareTo21723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo21724;
		public int compareTo(java.net.URI arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URI._compareTo21724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._compareTo21724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAbsolute21725;
		public bool isAbsolute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URI._isAbsolute21725);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._isAbsolute21725);
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPath21726;
		public global::java.lang.String getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getPath21726)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getPath21726)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toURL21727;
		public global::java.net.URL toURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._toURL21727)) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._toURL21727)) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _resolve21728;
		public global::java.net.URI resolve(java.net.URI arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._resolve21728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._resolve21728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _resolve21729;
		public global::java.net.URI resolve(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._resolve21729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._resolve21729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _normalize21730;
		public global::java.net.URI normalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._normalize21730)) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._normalize21730)) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _isOpaque21731;
		public bool isOpaque() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URI._isOpaque21731);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._isOpaque21731);
		}
		public new global::java.lang.String Scheme
		{
			get
			{
				return getScheme();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScheme21732;
		public global::java.lang.String getScheme() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getScheme21732)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getScheme21732)) as java.lang.String;
		}
		public new global::java.lang.String Authority
		{
			get
			{
				return getAuthority();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAuthority21733;
		public global::java.lang.String getAuthority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getAuthority21733)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getAuthority21733)) as java.lang.String;
		}
		public new global::java.lang.String Fragment
		{
			get
			{
				return getFragment();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFragment21734;
		public global::java.lang.String getFragment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getFragment21734)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getFragment21734)) as java.lang.String;
		}
		public new global::java.lang.String Query
		{
			get
			{
				return getQuery();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQuery21735;
		public global::java.lang.String getQuery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getQuery21735)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getQuery21735)) as java.lang.String;
		}
		public new global::java.lang.String UserInfo
		{
			get
			{
				return getUserInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUserInfo21736;
		public global::java.lang.String getUserInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getUserInfo21736)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getUserInfo21736)) as java.lang.String;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort21737;
		public int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URI._getPort21737);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getPort21737);
		}
		public new global::java.lang.String Host
		{
			get
			{
				return getHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHost21738;
		public global::java.lang.String getHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getHost21738)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getHost21738)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _create21739;
		public static global::java.net.URI create(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.URI.staticClass, global::java.net.URI._create21739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
		}
		public new global::java.lang.String SchemeSpecificPart
		{
			get
			{
				return getSchemeSpecificPart();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeSpecificPart21740;
		public global::java.lang.String getSchemeSpecificPart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getSchemeSpecificPart21740)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getSchemeSpecificPart21740)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _parseServerAuthority21741;
		public global::java.net.URI parseServerAuthority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._parseServerAuthority21741)) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._parseServerAuthority21741)) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _relativize21742;
		public global::java.net.URI relativize(java.net.URI arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._relativize21742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._relativize21742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
		}
		public new global::java.lang.String RawSchemeSpecificPart
		{
			get
			{
				return getRawSchemeSpecificPart();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawSchemeSpecificPart21743;
		public global::java.lang.String getRawSchemeSpecificPart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawSchemeSpecificPart21743)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawSchemeSpecificPart21743)) as java.lang.String;
		}
		public new global::java.lang.String RawAuthority
		{
			get
			{
				return getRawAuthority();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawAuthority21744;
		public global::java.lang.String getRawAuthority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawAuthority21744)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawAuthority21744)) as java.lang.String;
		}
		public new global::java.lang.String RawUserInfo
		{
			get
			{
				return getRawUserInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawUserInfo21745;
		public global::java.lang.String getRawUserInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawUserInfo21745)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawUserInfo21745)) as java.lang.String;
		}
		public new global::java.lang.String RawPath
		{
			get
			{
				return getRawPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawPath21746;
		public global::java.lang.String getRawPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawPath21746)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawPath21746)) as java.lang.String;
		}
		public new global::java.lang.String RawQuery
		{
			get
			{
				return getRawQuery();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawQuery21747;
		public global::java.lang.String getRawQuery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawQuery21747)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawQuery21747)) as java.lang.String;
		}
		public new global::java.lang.String RawFragment
		{
			get
			{
				return getRawFragment();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawFragment21748;
		public global::java.lang.String getRawFragment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawFragment21748)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawFragment21748)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toASCIIString21749;
		public global::java.lang.String toASCIIString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._toASCIIString21749)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._toASCIIString21749)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _URI21750;
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI21750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URI21751;
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI21751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URI21752;
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI21752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URI21753;
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI21753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URI21754;
		public URI(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI21754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URI.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URI"));
			global::java.net.URI._equals21720 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.URI._toString21721 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.URI._hashCode21722 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "hashCode", "()I");
			global::java.net.URI._compareTo21723 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.net.URI._compareTo21724 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "compareTo", "(Ljava/net/URI;)I");
			global::java.net.URI._isAbsolute21725 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "isAbsolute", "()Z");
			global::java.net.URI._getPath21726 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getPath", "()Ljava/lang/String;");
			global::java.net.URI._toURL21727 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "toURL", "()Ljava/net/URL;");
			global::java.net.URI._resolve21728 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "resolve", "(Ljava/net/URI;)Ljava/net/URI;");
			global::java.net.URI._resolve21729 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "resolve", "(Ljava/lang/String;)Ljava/net/URI;");
			global::java.net.URI._normalize21730 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "normalize", "()Ljava/net/URI;");
			global::java.net.URI._isOpaque21731 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "isOpaque", "()Z");
			global::java.net.URI._getScheme21732 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getScheme", "()Ljava/lang/String;");
			global::java.net.URI._getAuthority21733 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getAuthority", "()Ljava/lang/String;");
			global::java.net.URI._getFragment21734 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getFragment", "()Ljava/lang/String;");
			global::java.net.URI._getQuery21735 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getQuery", "()Ljava/lang/String;");
			global::java.net.URI._getUserInfo21736 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getUserInfo", "()Ljava/lang/String;");
			global::java.net.URI._getPort21737 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getPort", "()I");
			global::java.net.URI._getHost21738 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getHost", "()Ljava/lang/String;");
			global::java.net.URI._create21739 = @__env.GetStaticMethodIDNoThrow(global::java.net.URI.staticClass, "create", "(Ljava/lang/String;)Ljava/net/URI;");
			global::java.net.URI._getSchemeSpecificPart21740 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getSchemeSpecificPart", "()Ljava/lang/String;");
			global::java.net.URI._parseServerAuthority21741 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "parseServerAuthority", "()Ljava/net/URI;");
			global::java.net.URI._relativize21742 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "relativize", "(Ljava/net/URI;)Ljava/net/URI;");
			global::java.net.URI._getRawSchemeSpecificPart21743 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawSchemeSpecificPart", "()Ljava/lang/String;");
			global::java.net.URI._getRawAuthority21744 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawAuthority", "()Ljava/lang/String;");
			global::java.net.URI._getRawUserInfo21745 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawUserInfo", "()Ljava/lang/String;");
			global::java.net.URI._getRawPath21746 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawPath", "()Ljava/lang/String;");
			global::java.net.URI._getRawQuery21747 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawQuery", "()Ljava/lang/String;");
			global::java.net.URI._getRawFragment21748 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawFragment", "()Ljava/lang/String;");
			global::java.net.URI._toASCIIString21749 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "toASCIIString", "()Ljava/lang/String;");
			global::java.net.URI._URI21750 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URI._URI21751 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URI._URI21752 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URI._URI21753 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URI._URI21754 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
