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
		internal static global::MonoJavaBridge.MethodId _equals13851;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URI._equals13851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._equals13851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString13852;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._toString13852)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._toString13852)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode13853;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URI._hashCode13853);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._hashCode13853);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo13854;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URI._compareTo13854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._compareTo13854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo13855;
		public int compareTo(java.net.URI arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URI._compareTo13855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._compareTo13855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAbsolute13856;
		public bool isAbsolute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URI._isAbsolute13856);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._isAbsolute13856);
		}
		internal static global::MonoJavaBridge.MethodId _getPath13857;
		public global::java.lang.String getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getPath13857)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getPath13857)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toURL13858;
		public global::java.net.URL toURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._toURL13858)) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._toURL13858)) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _resolve13859;
		public global::java.net.URI resolve(java.net.URI arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._resolve13859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._resolve13859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _resolve13860;
		public global::java.net.URI resolve(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._resolve13860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._resolve13860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _normalize13861;
		public global::java.net.URI normalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._normalize13861)) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._normalize13861)) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _isOpaque13862;
		public bool isOpaque() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URI._isOpaque13862);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._isOpaque13862);
		}
		internal static global::MonoJavaBridge.MethodId _getScheme13863;
		public global::java.lang.String getScheme() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getScheme13863)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getScheme13863)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAuthority13864;
		public global::java.lang.String getAuthority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getAuthority13864)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getAuthority13864)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFragment13865;
		public global::java.lang.String getFragment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getFragment13865)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getFragment13865)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getQuery13866;
		public global::java.lang.String getQuery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getQuery13866)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getQuery13866)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getUserInfo13867;
		public global::java.lang.String getUserInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getUserInfo13867)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getUserInfo13867)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPort13868;
		public int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URI._getPort13868);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getPort13868);
		}
		internal static global::MonoJavaBridge.MethodId _getHost13869;
		public global::java.lang.String getHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getHost13869)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getHost13869)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _create13870;
		public static global::java.net.URI create(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.URI.staticClass, global::java.net.URI._create13870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeSpecificPart13871;
		public global::java.lang.String getSchemeSpecificPart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getSchemeSpecificPart13871)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getSchemeSpecificPart13871)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _parseServerAuthority13872;
		public global::java.net.URI parseServerAuthority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._parseServerAuthority13872)) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._parseServerAuthority13872)) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _relativize13873;
		public global::java.net.URI relativize(java.net.URI arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._relativize13873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._relativize13873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _getRawSchemeSpecificPart13874;
		public global::java.lang.String getRawSchemeSpecificPart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawSchemeSpecificPart13874)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawSchemeSpecificPart13874)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRawAuthority13875;
		public global::java.lang.String getRawAuthority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawAuthority13875)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawAuthority13875)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRawUserInfo13876;
		public global::java.lang.String getRawUserInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawUserInfo13876)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawUserInfo13876)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRawPath13877;
		public global::java.lang.String getRawPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawPath13877)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawPath13877)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRawQuery13878;
		public global::java.lang.String getRawQuery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawQuery13878)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawQuery13878)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRawFragment13879;
		public global::java.lang.String getRawFragment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._getRawFragment13879)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._getRawFragment13879)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toASCIIString13880;
		public global::java.lang.String toASCIIString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URI._toASCIIString13880)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URI.staticClass, global::java.net.URI._toASCIIString13880)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _URI13881;
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI13881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URI13882;
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI13882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URI13883;
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI13883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URI13884;
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI13884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URI13885;
		public URI(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI13885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URI.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URI"));
			global::java.net.URI._equals13851 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.URI._toString13852 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.URI._hashCode13853 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "hashCode", "()I");
			global::java.net.URI._compareTo13854 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.net.URI._compareTo13855 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "compareTo", "(Ljava/net/URI;)I");
			global::java.net.URI._isAbsolute13856 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "isAbsolute", "()Z");
			global::java.net.URI._getPath13857 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getPath", "()Ljava/lang/String;");
			global::java.net.URI._toURL13858 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "toURL", "()Ljava/net/URL;");
			global::java.net.URI._resolve13859 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "resolve", "(Ljava/net/URI;)Ljava/net/URI;");
			global::java.net.URI._resolve13860 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "resolve", "(Ljava/lang/String;)Ljava/net/URI;");
			global::java.net.URI._normalize13861 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "normalize", "()Ljava/net/URI;");
			global::java.net.URI._isOpaque13862 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "isOpaque", "()Z");
			global::java.net.URI._getScheme13863 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getScheme", "()Ljava/lang/String;");
			global::java.net.URI._getAuthority13864 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getAuthority", "()Ljava/lang/String;");
			global::java.net.URI._getFragment13865 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getFragment", "()Ljava/lang/String;");
			global::java.net.URI._getQuery13866 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getQuery", "()Ljava/lang/String;");
			global::java.net.URI._getUserInfo13867 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getUserInfo", "()Ljava/lang/String;");
			global::java.net.URI._getPort13868 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getPort", "()I");
			global::java.net.URI._getHost13869 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getHost", "()Ljava/lang/String;");
			global::java.net.URI._create13870 = @__env.GetStaticMethodIDNoThrow(global::java.net.URI.staticClass, "create", "(Ljava/lang/String;)Ljava/net/URI;");
			global::java.net.URI._getSchemeSpecificPart13871 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getSchemeSpecificPart", "()Ljava/lang/String;");
			global::java.net.URI._parseServerAuthority13872 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "parseServerAuthority", "()Ljava/net/URI;");
			global::java.net.URI._relativize13873 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "relativize", "(Ljava/net/URI;)Ljava/net/URI;");
			global::java.net.URI._getRawSchemeSpecificPart13874 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawSchemeSpecificPart", "()Ljava/lang/String;");
			global::java.net.URI._getRawAuthority13875 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawAuthority", "()Ljava/lang/String;");
			global::java.net.URI._getRawUserInfo13876 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawUserInfo", "()Ljava/lang/String;");
			global::java.net.URI._getRawPath13877 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawPath", "()Ljava/lang/String;");
			global::java.net.URI._getRawQuery13878 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawQuery", "()Ljava/lang/String;");
			global::java.net.URI._getRawFragment13879 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "getRawFragment", "()Ljava/lang/String;");
			global::java.net.URI._toASCIIString13880 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "toASCIIString", "()Ljava/lang/String;");
			global::java.net.URI._URI13881 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URI._URI13882 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URI._URI13883 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URI._URI13884 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URI._URI13885 = @__env.GetMethodIDNoThrow(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
