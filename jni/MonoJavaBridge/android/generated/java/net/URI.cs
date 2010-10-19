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
		internal static global::MonoJavaBridge.MethodId _equals16126;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URI._equals16126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._equals16126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString16127;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._toString16127)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._toString16127)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode16128;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URI._hashCode16128);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._hashCode16128);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo16129;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URI._compareTo16129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._compareTo16129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo16130;
		public int compareTo(java.net.URI arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URI._compareTo16130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._compareTo16130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAbsolute16131;
		public bool isAbsolute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URI._isAbsolute16131);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._isAbsolute16131);
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPath16132;
		public global::java.lang.String getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getPath16132)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getPath16132)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toURL16133;
		public global::java.net.URL toURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._toURL16133)) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._toURL16133)) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _resolve16134;
		public global::java.net.URI resolve(java.net.URI arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._resolve16134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._resolve16134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _resolve16135;
		public global::java.net.URI resolve(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._resolve16135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._resolve16135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _normalize16136;
		public global::java.net.URI normalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._normalize16136)) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._normalize16136)) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _isOpaque16137;
		public bool isOpaque() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URI._isOpaque16137);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._isOpaque16137);
		}
		public new global::java.lang.String Scheme
		{
			get
			{
				return getScheme();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScheme16138;
		public global::java.lang.String getScheme() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getScheme16138)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getScheme16138)) as java.lang.String;
		}
		public new global::java.lang.String Authority
		{
			get
			{
				return getAuthority();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAuthority16139;
		public global::java.lang.String getAuthority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getAuthority16139)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getAuthority16139)) as java.lang.String;
		}
		public new global::java.lang.String Fragment
		{
			get
			{
				return getFragment();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFragment16140;
		public global::java.lang.String getFragment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getFragment16140)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getFragment16140)) as java.lang.String;
		}
		public new global::java.lang.String Query
		{
			get
			{
				return getQuery();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQuery16141;
		public global::java.lang.String getQuery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getQuery16141)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getQuery16141)) as java.lang.String;
		}
		public new global::java.lang.String UserInfo
		{
			get
			{
				return getUserInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUserInfo16142;
		public global::java.lang.String getUserInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getUserInfo16142)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getUserInfo16142)) as java.lang.String;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort16143;
		public int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URI._getPort16143);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getPort16143);
		}
		public new global::java.lang.String Host
		{
			get
			{
				return getHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHost16144;
		public global::java.lang.String getHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getHost16144)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getHost16144)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _create16145;
		public static global::java.net.URI create(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.URI.staticClass, global::java.net.URI._create16145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
		}
		public new global::java.lang.String SchemeSpecificPart
		{
			get
			{
				return getSchemeSpecificPart();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeSpecificPart16146;
		public global::java.lang.String getSchemeSpecificPart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getSchemeSpecificPart16146)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getSchemeSpecificPart16146)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _parseServerAuthority16147;
		public global::java.net.URI parseServerAuthority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._parseServerAuthority16147)) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._parseServerAuthority16147)) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _relativize16148;
		public global::java.net.URI relativize(java.net.URI arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._relativize16148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._relativize16148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
		}
		public new global::java.lang.String RawSchemeSpecificPart
		{
			get
			{
				return getRawSchemeSpecificPart();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawSchemeSpecificPart16149;
		public global::java.lang.String getRawSchemeSpecificPart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawSchemeSpecificPart16149)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawSchemeSpecificPart16149)) as java.lang.String;
		}
		public new global::java.lang.String RawAuthority
		{
			get
			{
				return getRawAuthority();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawAuthority16150;
		public global::java.lang.String getRawAuthority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawAuthority16150)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawAuthority16150)) as java.lang.String;
		}
		public new global::java.lang.String RawUserInfo
		{
			get
			{
				return getRawUserInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawUserInfo16151;
		public global::java.lang.String getRawUserInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawUserInfo16151)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawUserInfo16151)) as java.lang.String;
		}
		public new global::java.lang.String RawPath
		{
			get
			{
				return getRawPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawPath16152;
		public global::java.lang.String getRawPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawPath16152)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawPath16152)) as java.lang.String;
		}
		public new global::java.lang.String RawQuery
		{
			get
			{
				return getRawQuery();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawQuery16153;
		public global::java.lang.String getRawQuery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawQuery16153)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawQuery16153)) as java.lang.String;
		}
		public new global::java.lang.String RawFragment
		{
			get
			{
				return getRawFragment();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawFragment16154;
		public global::java.lang.String getRawFragment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawFragment16154)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawFragment16154)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toASCIIString16155;
		public global::java.lang.String toASCIIString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._toASCIIString16155)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._toASCIIString16155)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _URI16156;
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI16156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URI16157;
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI16157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URI16158;
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI16158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URI16159;
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI16159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URI16160;
		public URI(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI16160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URI.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URI"));
			global::java.net.URI._equals16126 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.URI._toString16127 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.URI._hashCode16128 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "hashCode", "()I");
			global::java.net.URI._compareTo16129 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.net.URI._compareTo16130 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "compareTo", "(Ljava/net/URI;)I");
			global::java.net.URI._isAbsolute16131 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "isAbsolute", "()Z");
			global::java.net.URI._getPath16132 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getPath", "()Ljava/lang/String;");
			global::java.net.URI._toURL16133 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "toURL", "()Ljava/net/URL;");
			global::java.net.URI._resolve16134 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "resolve", "(Ljava/net/URI;)Ljava/net/URI;");
			global::java.net.URI._resolve16135 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "resolve", "(Ljava/lang/String;)Ljava/net/URI;");
			global::java.net.URI._normalize16136 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "normalize", "()Ljava/net/URI;");
			global::java.net.URI._isOpaque16137 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "isOpaque", "()Z");
			global::java.net.URI._getScheme16138 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getScheme", "()Ljava/lang/String;");
			global::java.net.URI._getAuthority16139 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getAuthority", "()Ljava/lang/String;");
			global::java.net.URI._getFragment16140 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getFragment", "()Ljava/lang/String;");
			global::java.net.URI._getQuery16141 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getQuery", "()Ljava/lang/String;");
			global::java.net.URI._getUserInfo16142 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getUserInfo", "()Ljava/lang/String;");
			global::java.net.URI._getPort16143 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getPort", "()I");
			global::java.net.URI._getHost16144 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getHost", "()Ljava/lang/String;");
			global::java.net.URI._create16145 = @__env.GetStaticMethodIDNoThrow(global::java.net.URI.staticClass, "create", "(Ljava/lang/String;)Ljava/net/URI;");
			global::java.net.URI._getSchemeSpecificPart16146 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getSchemeSpecificPart", "()Ljava/lang/String;");
			global::java.net.URI._parseServerAuthority16147 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "parseServerAuthority", "()Ljava/net/URI;");
			global::java.net.URI._relativize16148 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "relativize", "(Ljava/net/URI;)Ljava/net/URI;");
			global::java.net.URI._getRawSchemeSpecificPart16149 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawSchemeSpecificPart", "()Ljava/lang/String;");
			global::java.net.URI._getRawAuthority16150 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawAuthority", "()Ljava/lang/String;");
			global::java.net.URI._getRawUserInfo16151 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawUserInfo", "()Ljava/lang/String;");
			global::java.net.URI._getRawPath16152 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawPath", "()Ljava/lang/String;");
			global::java.net.URI._getRawQuery16153 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawQuery", "()Ljava/lang/String;");
			global::java.net.URI._getRawFragment16154 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawFragment", "()Ljava/lang/String;");
			global::java.net.URI._toASCIIString16155 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "toASCIIString", "()Ljava/lang/String;");
			global::java.net.URI._URI16156 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URI._URI16157 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URI._URI16158 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URI._URI16159 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URI._URI16160 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
