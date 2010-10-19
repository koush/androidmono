namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HeaderGroup : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HeaderGroup()
		{
			InitJNI();
		}
		protected HeaderGroup(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone26925;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._clone26925)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._clone26925)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear26926;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._clear26926);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._clear26926);
		}
		internal static global::MonoJavaBridge.MethodId _iterator26927;
		public virtual global::org.apache.http.HeaderIterator iterator(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._iterator26927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HeaderIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._iterator26927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HeaderIterator;
		}
		internal static global::MonoJavaBridge.MethodId _iterator26928;
		public virtual global::org.apache.http.HeaderIterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._iterator26928)) as org.apache.http.HeaderIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._iterator26928)) as org.apache.http.HeaderIterator;
		}
		internal static global::MonoJavaBridge.MethodId _copy26929;
		public virtual global::org.apache.http.message.HeaderGroup copy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._copy26929)) as org.apache.http.message.HeaderGroup;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._copy26929)) as org.apache.http.message.HeaderGroup;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders26930;
		public virtual global::org.apache.http.Header[] getHeaders(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._getHeaders26930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._getHeaders26930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _containsHeader26931;
		public virtual bool containsHeader(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._containsHeader26931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._containsHeader26931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFirstHeader26932;
		public virtual global::org.apache.http.Header getFirstHeader(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._getFirstHeader26932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._getFirstHeader26932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getLastHeader26933;
		public virtual global::org.apache.http.Header getLastHeader(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._getLastHeader26933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._getLastHeader26933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		public new global::org.apache.http.Header[] AllHeaders
		{
			get
			{
				return getAllHeaders();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllHeaders26934;
		public virtual global::org.apache.http.Header[] getAllHeaders() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._getAllHeaders26934)) as org.apache.http.Header[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._getAllHeaders26934)) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _addHeader26935;
		public virtual void addHeader(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._addHeader26935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._addHeader26935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHeaders26936;
		public virtual void setHeaders(org.apache.http.Header[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._setHeaders26936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._setHeaders26936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeader26937;
		public virtual void removeHeader(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._removeHeader26937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._removeHeader26937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateHeader26938;
		public virtual void updateHeader(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._updateHeader26938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._updateHeader26938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCondensedHeader26939;
		public virtual global::org.apache.http.Header getCondensedHeader(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._getCondensedHeader26939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._getCondensedHeader26939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _HeaderGroup26940;
		public HeaderGroup()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._HeaderGroup26940);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.HeaderGroup.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/HeaderGroup"));
			global::org.apache.http.message.HeaderGroup._clone26925 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.message.HeaderGroup._clear26926 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "clear", "()V");
			global::org.apache.http.message.HeaderGroup._iterator26927 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "iterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;");
			global::org.apache.http.message.HeaderGroup._iterator26928 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "iterator", "()Lorg/apache/http/HeaderIterator;");
			global::org.apache.http.message.HeaderGroup._copy26929 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "copy", "()Lorg/apache/http/message/HeaderGroup;");
			global::org.apache.http.message.HeaderGroup._getHeaders26930 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;");
			global::org.apache.http.message.HeaderGroup._containsHeader26931 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "containsHeader", "(Ljava/lang/String;)Z");
			global::org.apache.http.message.HeaderGroup._getFirstHeader26932 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.message.HeaderGroup._getLastHeader26933 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.message.HeaderGroup._getAllHeaders26934 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "getAllHeaders", "()[Lorg/apache/http/Header;");
			global::org.apache.http.message.HeaderGroup._addHeader26935 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "addHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.message.HeaderGroup._setHeaders26936 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "setHeaders", "([Lorg/apache/http/Header;)V");
			global::org.apache.http.message.HeaderGroup._removeHeader26937 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "removeHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.message.HeaderGroup._updateHeader26938 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "updateHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.message.HeaderGroup._getCondensedHeader26939 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "getCondensedHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.message.HeaderGroup._HeaderGroup26940 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "<init>", "()V");
		}
	}
}
