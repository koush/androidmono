namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.message.AbstractHttpMessage_))]
	public abstract partial class AbstractHttpMessage : java.lang.Object, HttpMessage
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractHttpMessage()
		{
			InitJNI();
		}
		protected AbstractHttpMessage(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion26739;
		public abstract global::org.apache.http.ProtocolVersion getProtocolVersion();
		internal static global::MonoJavaBridge.MethodId _getParams26740;
		public virtual global::org.apache.http.@params.HttpParams getParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage._getParams26740)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._getParams26740)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParams26741;
		public virtual void setParams(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage._setParams26741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._setParams26741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders26742;
		public virtual global::org.apache.http.Header[] getHeaders(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage._getHeaders26742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._getHeaders26742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _containsHeader26743;
		public virtual bool containsHeader(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage._containsHeader26743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._containsHeader26743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFirstHeader26744;
		public virtual global::org.apache.http.Header getFirstHeader(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage._getFirstHeader26744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._getFirstHeader26744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getLastHeader26745;
		public virtual global::org.apache.http.Header getLastHeader(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage._getLastHeader26745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._getLastHeader26745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getAllHeaders26746;
		public virtual global::org.apache.http.Header[] getAllHeaders() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage._getAllHeaders26746)) as org.apache.http.Header[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._getAllHeaders26746)) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _addHeader26747;
		public virtual void addHeader(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage._addHeader26747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._addHeader26747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addHeader26748;
		public virtual void addHeader(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage._addHeader26748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._addHeader26748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader26749;
		public virtual void setHeader(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage._setHeader26749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._setHeader26749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader26750;
		public virtual void setHeader(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage._setHeader26750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._setHeader26750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHeaders26751;
		public virtual void setHeaders(org.apache.http.Header[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage._setHeaders26751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._setHeaders26751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeader26752;
		public virtual void removeHeader(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage._removeHeader26752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._removeHeader26752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeaders26753;
		public virtual void removeHeaders(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage._removeHeaders26753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._removeHeaders26753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator26754;
		public virtual global::org.apache.http.HeaderIterator headerIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage._headerIterator26754)) as org.apache.http.HeaderIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._headerIterator26754)) as org.apache.http.HeaderIterator;
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator26755;
		public virtual global::org.apache.http.HeaderIterator headerIterator(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage._headerIterator26755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HeaderIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._headerIterator26755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HeaderIterator;
		}
		internal static global::MonoJavaBridge.MethodId _AbstractHttpMessage26756;
		protected AbstractHttpMessage()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._AbstractHttpMessage26756);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractHttpMessage26757;
		protected AbstractHttpMessage(org.apache.http.@params.HttpParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._AbstractHttpMessage26757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.AbstractHttpMessage.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/AbstractHttpMessage"));
			global::org.apache.http.message.AbstractHttpMessage._getProtocolVersion26739 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.message.AbstractHttpMessage._getParams26740 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "getParams", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.message.AbstractHttpMessage._setParams26741 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "setParams", "(Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.message.AbstractHttpMessage._getHeaders26742 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;");
			global::org.apache.http.message.AbstractHttpMessage._containsHeader26743 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "containsHeader", "(Ljava/lang/String;)Z");
			global::org.apache.http.message.AbstractHttpMessage._getFirstHeader26744 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.message.AbstractHttpMessage._getLastHeader26745 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.message.AbstractHttpMessage._getAllHeaders26746 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "getAllHeaders", "()[Lorg/apache/http/Header;");
			global::org.apache.http.message.AbstractHttpMessage._addHeader26747 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "addHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.message.AbstractHttpMessage._addHeader26748 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.message.AbstractHttpMessage._setHeader26749 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.message.AbstractHttpMessage._setHeader26750 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "setHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.message.AbstractHttpMessage._setHeaders26751 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "setHeaders", "([Lorg/apache/http/Header;)V");
			global::org.apache.http.message.AbstractHttpMessage._removeHeader26752 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "removeHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.message.AbstractHttpMessage._removeHeaders26753 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "removeHeaders", "(Ljava/lang/String;)V");
			global::org.apache.http.message.AbstractHttpMessage._headerIterator26754 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "headerIterator", "()Lorg/apache/http/HeaderIterator;");
			global::org.apache.http.message.AbstractHttpMessage._headerIterator26755 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;");
			global::org.apache.http.message.AbstractHttpMessage._AbstractHttpMessage26756 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "<init>", "()V");
			global::org.apache.http.message.AbstractHttpMessage._AbstractHttpMessage26757 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "<init>", "(Lorg/apache/http/@params/HttpParams;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.message.AbstractHttpMessage))]
	public sealed partial class AbstractHttpMessage_ : org.apache.http.message.AbstractHttpMessage
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractHttpMessage_()
		{
			InitJNI();
		}
		internal AbstractHttpMessage_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion26758;
		public override global::org.apache.http.ProtocolVersion getProtocolVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage_._getProtocolVersion26758)) as org.apache.http.ProtocolVersion;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage_.staticClass, global::org.apache.http.message.AbstractHttpMessage_._getProtocolVersion26758)) as org.apache.http.ProtocolVersion;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.AbstractHttpMessage_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/AbstractHttpMessage"));
			global::org.apache.http.message.AbstractHttpMessage_._getProtocolVersion26758 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage_.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
		}
	}
}
