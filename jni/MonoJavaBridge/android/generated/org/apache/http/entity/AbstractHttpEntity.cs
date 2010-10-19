namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.entity.AbstractHttpEntity_))]
	public abstract partial class AbstractHttpEntity : java.lang.Object, HttpEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractHttpEntity()
		{
			InitJNI();
		}
		protected AbstractHttpEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getContent25750;
		public abstract global::java.io.InputStream getContent();
		internal static global::MonoJavaBridge.MethodId _writeTo25751;
		public abstract void writeTo(java.io.OutputStream arg0);
		internal static global::MonoJavaBridge.MethodId _getContentLength25752;
		public abstract long getContentLength();
		internal static global::MonoJavaBridge.MethodId _isRepeatable25753;
		public abstract bool isRepeatable();
		internal static global::MonoJavaBridge.MethodId _isStreaming25754;
		public abstract bool isStreaming();
		internal static global::MonoJavaBridge.MethodId _getContentType25755;
		public virtual global::org.apache.http.Header getContentType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity._getContentType25755)) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._getContentType25755)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _setContentType25756;
		public virtual void setContentType(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity._setContentType25756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._setContentType25756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentType25757;
		public virtual void setContentType(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity._setContentType25757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._setContentType25757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContentEncoding25758;
		public virtual global::org.apache.http.Header getContentEncoding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity._getContentEncoding25758)) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._getContentEncoding25758)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _isChunked25759;
		public virtual bool isChunked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity._isChunked25759);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._isChunked25759);
		}
		internal static global::MonoJavaBridge.MethodId _consumeContent25760;
		public virtual void consumeContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity._consumeContent25760);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._consumeContent25760);
		}
		internal static global::MonoJavaBridge.MethodId _setContentEncoding25761;
		public virtual void setContentEncoding(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity._setContentEncoding25761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._setContentEncoding25761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentEncoding25762;
		public virtual void setContentEncoding(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity._setContentEncoding25762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._setContentEncoding25762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChunked25763;
		public virtual void setChunked(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity._setChunked25763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._setChunked25763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractHttpEntity25764;
		protected AbstractHttpEntity()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._AbstractHttpEntity25764);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.AbstractHttpEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/AbstractHttpEntity"));
			global::org.apache.http.entity.AbstractHttpEntity._getContent25750 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.entity.AbstractHttpEntity._writeTo25751 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.entity.AbstractHttpEntity._getContentLength25752 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "getContentLength", "()J");
			global::org.apache.http.entity.AbstractHttpEntity._isRepeatable25753 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.entity.AbstractHttpEntity._isStreaming25754 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "isStreaming", "()Z");
			global::org.apache.http.entity.AbstractHttpEntity._getContentType25755 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "getContentType", "()Lorg/apache/http/Header;");
			global::org.apache.http.entity.AbstractHttpEntity._setContentType25756 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setContentType", "(Ljava/lang/String;)V");
			global::org.apache.http.entity.AbstractHttpEntity._setContentType25757 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setContentType", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.entity.AbstractHttpEntity._getContentEncoding25758 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "getContentEncoding", "()Lorg/apache/http/Header;");
			global::org.apache.http.entity.AbstractHttpEntity._isChunked25759 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "isChunked", "()Z");
			global::org.apache.http.entity.AbstractHttpEntity._consumeContent25760 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "consumeContent", "()V");
			global::org.apache.http.entity.AbstractHttpEntity._setContentEncoding25761 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setContentEncoding", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.entity.AbstractHttpEntity._setContentEncoding25762 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setContentEncoding", "(Ljava/lang/String;)V");
			global::org.apache.http.entity.AbstractHttpEntity._setChunked25763 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setChunked", "(Z)V");
			global::org.apache.http.entity.AbstractHttpEntity._AbstractHttpEntity25764 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.entity.AbstractHttpEntity))]
	public sealed partial class AbstractHttpEntity_ : org.apache.http.entity.AbstractHttpEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractHttpEntity_()
		{
			InitJNI();
		}
		internal AbstractHttpEntity_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getContent25765;
		public override global::java.io.InputStream getContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity_._getContent25765)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity_.staticClass, global::org.apache.http.entity.AbstractHttpEntity_._getContent25765)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo25766;
		public override void writeTo(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity_._writeTo25766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity_.staticClass, global::org.apache.http.entity.AbstractHttpEntity_._writeTo25766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength25767;
		public override long getContentLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity_._getContentLength25767);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity_.staticClass, global::org.apache.http.entity.AbstractHttpEntity_._getContentLength25767);
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable25768;
		public override bool isRepeatable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity_._isRepeatable25768);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity_.staticClass, global::org.apache.http.entity.AbstractHttpEntity_._isRepeatable25768);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming25769;
		public override bool isStreaming() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity_._isStreaming25769);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity_.staticClass, global::org.apache.http.entity.AbstractHttpEntity_._isStreaming25769);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.AbstractHttpEntity_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/AbstractHttpEntity"));
			global::org.apache.http.entity.AbstractHttpEntity_._getContent25765 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity_.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.entity.AbstractHttpEntity_._writeTo25766 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity_.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.entity.AbstractHttpEntity_._getContentLength25767 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity_.staticClass, "getContentLength", "()J");
			global::org.apache.http.entity.AbstractHttpEntity_._isRepeatable25768 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity_.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.entity.AbstractHttpEntity_._isStreaming25769 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity_.staticClass, "isStreaming", "()Z");
		}
	}
}
