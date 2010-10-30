namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HeaderGroup : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HeaderGroup(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone33674;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.HeaderGroup.staticClass, "clone", "()Ljava/lang/Object;", ref global::org.apache.http.message.HeaderGroup._clone33674) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear33675;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.HeaderGroup.staticClass, "clear", "()V", ref global::org.apache.http.message.HeaderGroup._clear33675);
		}
		internal static global::MonoJavaBridge.MethodId _iterator33676;
		public virtual global::org.apache.http.HeaderIterator iterator(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HeaderIterator>(this, global::org.apache.http.message.HeaderGroup.staticClass, "iterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;", ref global::org.apache.http.message.HeaderGroup._iterator33676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HeaderIterator;
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator33677;
		public virtual global::org.apache.http.HeaderIterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HeaderIterator>(this, global::org.apache.http.message.HeaderGroup.staticClass, "iterator", "()Lorg/apache/http/HeaderIterator;", ref global::org.apache.http.message.HeaderGroup._iterator33677) as org.apache.http.HeaderIterator;
		}
		internal static global::MonoJavaBridge.MethodId _copy33678;
		public virtual global::org.apache.http.message.HeaderGroup copy()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.HeaderGroup.staticClass, "copy", "()Lorg/apache/http/message/HeaderGroup;", ref global::org.apache.http.message.HeaderGroup._copy33678) as org.apache.http.message.HeaderGroup;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders33679;
		public virtual global::org.apache.http.Header[] getHeaders(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.Header>(this, global::org.apache.http.message.HeaderGroup.staticClass, "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;", ref global::org.apache.http.message.HeaderGroup._getHeaders33679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _containsHeader33680;
		public virtual bool containsHeader(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.HeaderGroup.staticClass, "containsHeader", "(Ljava/lang/String;)Z", ref global::org.apache.http.message.HeaderGroup._containsHeader33680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFirstHeader33681;
		public virtual global::org.apache.http.Header getFirstHeader(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.message.HeaderGroup.staticClass, "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", ref global::org.apache.http.message.HeaderGroup._getFirstHeader33681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getLastHeader33682;
		public virtual global::org.apache.http.Header getLastHeader(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.message.HeaderGroup.staticClass, "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", ref global::org.apache.http.message.HeaderGroup._getLastHeader33682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.Header;
		}
		public new global::org.apache.http.Header[] AllHeaders
		{
			get
			{
				return getAllHeaders();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllHeaders33683;
		public virtual global::org.apache.http.Header[] getAllHeaders()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.Header>(this, global::org.apache.http.message.HeaderGroup.staticClass, "getAllHeaders", "()[Lorg/apache/http/Header;", ref global::org.apache.http.message.HeaderGroup._getAllHeaders33683) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _addHeader33684;
		public virtual void addHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.HeaderGroup.staticClass, "addHeader", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.message.HeaderGroup._addHeader33684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.Header[] Headers
		{
			set
			{
				setHeaders(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setHeaders33685;
		public virtual void setHeaders(org.apache.http.Header[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.HeaderGroup.staticClass, "setHeaders", "([Lorg/apache/http/Header;)V", ref global::org.apache.http.message.HeaderGroup._setHeaders33685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeader33686;
		public virtual void removeHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.HeaderGroup.staticClass, "removeHeader", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.message.HeaderGroup._removeHeader33686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateHeader33687;
		public virtual void updateHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.HeaderGroup.staticClass, "updateHeader", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.message.HeaderGroup._updateHeader33687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCondensedHeader33688;
		public virtual global::org.apache.http.Header getCondensedHeader(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.message.HeaderGroup.staticClass, "getCondensedHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", ref global::org.apache.http.message.HeaderGroup._getCondensedHeader33688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _HeaderGroup33689;
		public HeaderGroup() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.HeaderGroup._HeaderGroup33689.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.HeaderGroup._HeaderGroup33689 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._HeaderGroup33689);
			Init(@__env, handle);
		}
		static HeaderGroup()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.HeaderGroup.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/HeaderGroup"));
		}
		internal static void InitJNI()
		{
		}
	}
}
