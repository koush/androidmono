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
		internal static global::MonoJavaBridge.MethodId _clone33673;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._clone33673)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._clone33673)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear33674;
		public virtual void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._clear33674);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._clear33674);
		}
		internal static global::MonoJavaBridge.MethodId _iterator33675;
		public virtual global::org.apache.http.HeaderIterator iterator(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._iterator33675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HeaderIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._iterator33675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HeaderIterator;
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator33676;
		public virtual global::org.apache.http.HeaderIterator iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._iterator33676)) as org.apache.http.HeaderIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._iterator33676)) as org.apache.http.HeaderIterator;
		}
		internal static global::MonoJavaBridge.MethodId _copy33677;
		public virtual global::org.apache.http.message.HeaderGroup copy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._copy33677)) as org.apache.http.message.HeaderGroup;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._copy33677)) as org.apache.http.message.HeaderGroup;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders33678;
		public virtual global::org.apache.http.Header[] getHeaders(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._getHeaders33678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._getHeaders33678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _containsHeader33679;
		public virtual bool containsHeader(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._containsHeader33679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._containsHeader33679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFirstHeader33680;
		public virtual global::org.apache.http.Header getFirstHeader(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._getFirstHeader33680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._getFirstHeader33680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getLastHeader33681;
		public virtual global::org.apache.http.Header getLastHeader(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._getLastHeader33681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._getLastHeader33681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		public new global::org.apache.http.Header[] AllHeaders
		{
			get
			{
				return getAllHeaders();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllHeaders33682;
		public virtual global::org.apache.http.Header[] getAllHeaders()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._getAllHeaders33682)) as org.apache.http.Header[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._getAllHeaders33682)) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _addHeader33683;
		public virtual void addHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._addHeader33683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._addHeader33683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.Header[] Headers
		{
			set
			{
				setHeaders(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setHeaders33684;
		public virtual void setHeaders(org.apache.http.Header[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._setHeaders33684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._setHeaders33684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeader33685;
		public virtual void removeHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._removeHeader33685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._removeHeader33685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateHeader33686;
		public virtual void updateHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._updateHeader33686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._updateHeader33686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCondensedHeader33687;
		public virtual global::org.apache.http.Header getCondensedHeader(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup._getCondensedHeader33687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._getCondensedHeader33687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _HeaderGroup33688;
		public HeaderGroup() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.HeaderGroup.staticClass, global::org.apache.http.message.HeaderGroup._HeaderGroup33688);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.HeaderGroup.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/HeaderGroup"));
			global::org.apache.http.message.HeaderGroup._clone33673 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.message.HeaderGroup._clear33674 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "clear", "()V");
			global::org.apache.http.message.HeaderGroup._iterator33675 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "iterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;");
			global::org.apache.http.message.HeaderGroup._iterator33676 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "iterator", "()Lorg/apache/http/HeaderIterator;");
			global::org.apache.http.message.HeaderGroup._copy33677 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "copy", "()Lorg/apache/http/message/HeaderGroup;");
			global::org.apache.http.message.HeaderGroup._getHeaders33678 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;");
			global::org.apache.http.message.HeaderGroup._containsHeader33679 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "containsHeader", "(Ljava/lang/String;)Z");
			global::org.apache.http.message.HeaderGroup._getFirstHeader33680 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.message.HeaderGroup._getLastHeader33681 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.message.HeaderGroup._getAllHeaders33682 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "getAllHeaders", "()[Lorg/apache/http/Header;");
			global::org.apache.http.message.HeaderGroup._addHeader33683 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "addHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.message.HeaderGroup._setHeaders33684 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "setHeaders", "([Lorg/apache/http/Header;)V");
			global::org.apache.http.message.HeaderGroup._removeHeader33685 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "removeHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.message.HeaderGroup._updateHeader33686 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "updateHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.message.HeaderGroup._getCondensedHeader33687 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "getCondensedHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.message.HeaderGroup._HeaderGroup33688 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderGroup.staticClass, "<init>", "()V");
		}
	}
}
