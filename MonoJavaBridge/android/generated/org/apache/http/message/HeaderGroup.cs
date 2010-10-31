namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HeaderGroup : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HeaderGroup(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.HeaderGroup.staticClass, "clone", "()Ljava/lang/Object;", ref global::org.apache.http.message.HeaderGroup._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.HeaderGroup.staticClass, "clear", "()V", ref global::org.apache.http.message.HeaderGroup._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::org.apache.http.HeaderIterator iterator(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HeaderIterator>(this, global::org.apache.http.message.HeaderGroup.staticClass, "iterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;", ref global::org.apache.http.message.HeaderGroup._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HeaderIterator;
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::org.apache.http.HeaderIterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HeaderIterator>(this, global::org.apache.http.message.HeaderGroup.staticClass, "iterator", "()Lorg/apache/http/HeaderIterator;", ref global::org.apache.http.message.HeaderGroup._m3) as org.apache.http.HeaderIterator;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::org.apache.http.message.HeaderGroup copy()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.HeaderGroup.staticClass, "copy", "()Lorg/apache/http/message/HeaderGroup;", ref global::org.apache.http.message.HeaderGroup._m4) as org.apache.http.message.HeaderGroup;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::org.apache.http.Header[] getHeaders(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.Header>(this, global::org.apache.http.message.HeaderGroup.staticClass, "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;", ref global::org.apache.http.message.HeaderGroup._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.Header[];
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool containsHeader(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.HeaderGroup.staticClass, "containsHeader", "(Ljava/lang/String;)Z", ref global::org.apache.http.message.HeaderGroup._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::org.apache.http.Header getFirstHeader(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.message.HeaderGroup.staticClass, "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", ref global::org.apache.http.message.HeaderGroup._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.Header;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::org.apache.http.Header getLastHeader(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.message.HeaderGroup.staticClass, "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", ref global::org.apache.http.message.HeaderGroup._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.Header;
		}
		public new global::org.apache.http.Header[] AllHeaders
		{
			get
			{
				return getAllHeaders();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::org.apache.http.Header[] getAllHeaders()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.Header>(this, global::org.apache.http.message.HeaderGroup.staticClass, "getAllHeaders", "()[Lorg/apache/http/Header;", ref global::org.apache.http.message.HeaderGroup._m9) as org.apache.http.Header[];
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void addHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.HeaderGroup.staticClass, "addHeader", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.message.HeaderGroup._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.Header[] Headers
		{
			set
			{
				setHeaders(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setHeaders(org.apache.http.Header[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.HeaderGroup.staticClass, "setHeaders", "([Lorg/apache/http/Header;)V", ref global::org.apache.http.message.HeaderGroup._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void removeHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.HeaderGroup.staticClass, "removeHeader", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.message.HeaderGroup._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void updateHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.HeaderGroup.staticClass, "updateHeader", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.message.HeaderGroup._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::org.apache.http.Header getCondensedHeader(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.message.HeaderGroup.staticClass, "getCondensedHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", ref global::org.apache.http.message.HeaderGroup._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.Header;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public HeaderGroup() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.HeaderGroup._m15.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.HeaderGroup._m15 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._m15);
			Init(@__env, handle);
		}
		static HeaderGroup()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.HeaderGroup.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/HeaderGroup"));
		}
	}
}
