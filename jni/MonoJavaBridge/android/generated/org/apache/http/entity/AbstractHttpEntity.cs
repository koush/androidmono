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
		internal static global::MonoJavaBridge.MethodId _getContent32486;
		public abstract global::java.io.InputStream getContent();
		internal static global::MonoJavaBridge.MethodId _writeTo32487;
		public abstract void writeTo(java.io.OutputStream arg0);
		internal static global::MonoJavaBridge.MethodId _getContentLength32488;
		public abstract long getContentLength();
		internal static global::MonoJavaBridge.MethodId _isRepeatable32489;
		public abstract bool isRepeatable();
		internal static global::MonoJavaBridge.MethodId _isStreaming32490;
		public abstract bool isStreaming();
		internal static global::MonoJavaBridge.MethodId _getContentType32491;
		public virtual global::org.apache.http.Header getContentType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity._getContentType32491)) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._getContentType32491)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _setContentType32492;
		public virtual void setContentType(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity._setContentType32492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._setContentType32492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentType32493;
		public virtual void setContentType(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity._setContentType32493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._setContentType32493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContentEncoding32494;
		public virtual global::org.apache.http.Header getContentEncoding()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity._getContentEncoding32494)) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._getContentEncoding32494)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _isChunked32495;
		public virtual bool isChunked()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity._isChunked32495);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._isChunked32495);
		}
		internal static global::MonoJavaBridge.MethodId _consumeContent32496;
		public virtual void consumeContent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity._consumeContent32496);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._consumeContent32496);
		}
		internal static global::MonoJavaBridge.MethodId _setContentEncoding32497;
		public virtual void setContentEncoding(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity._setContentEncoding32497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._setContentEncoding32497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentEncoding32498;
		public virtual void setContentEncoding(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity._setContentEncoding32498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._setContentEncoding32498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChunked32499;
		public virtual void setChunked(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity._setChunked32499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._setChunked32499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractHttpEntity32500;
		protected AbstractHttpEntity() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._AbstractHttpEntity32500);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.AbstractHttpEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/AbstractHttpEntity"));
			global::org.apache.http.entity.AbstractHttpEntity._getContent32486 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.entity.AbstractHttpEntity._writeTo32487 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.entity.AbstractHttpEntity._getContentLength32488 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "getContentLength", "()J");
			global::org.apache.http.entity.AbstractHttpEntity._isRepeatable32489 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.entity.AbstractHttpEntity._isStreaming32490 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "isStreaming", "()Z");
			global::org.apache.http.entity.AbstractHttpEntity._getContentType32491 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "getContentType", "()Lorg/apache/http/Header;");
			global::org.apache.http.entity.AbstractHttpEntity._setContentType32492 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setContentType", "(Ljava/lang/String;)V");
			global::org.apache.http.entity.AbstractHttpEntity._setContentType32493 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setContentType", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.entity.AbstractHttpEntity._getContentEncoding32494 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "getContentEncoding", "()Lorg/apache/http/Header;");
			global::org.apache.http.entity.AbstractHttpEntity._isChunked32495 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "isChunked", "()Z");
			global::org.apache.http.entity.AbstractHttpEntity._consumeContent32496 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "consumeContent", "()V");
			global::org.apache.http.entity.AbstractHttpEntity._setContentEncoding32497 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setContentEncoding", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.entity.AbstractHttpEntity._setContentEncoding32498 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setContentEncoding", "(Ljava/lang/String;)V");
			global::org.apache.http.entity.AbstractHttpEntity._setChunked32499 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setChunked", "(Z)V");
			global::org.apache.http.entity.AbstractHttpEntity._AbstractHttpEntity32500 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.entity.AbstractHttpEntity))]
	internal sealed partial class AbstractHttpEntity_ : org.apache.http.entity.AbstractHttpEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractHttpEntity_()
		{
			InitJNI();
		}
		internal AbstractHttpEntity_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getContent32501;
		public override global::java.io.InputStream getContent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity_._getContent32501)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity_.staticClass, global::org.apache.http.entity.AbstractHttpEntity_._getContent32501)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo32502;
		public override void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity_._writeTo32502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity_.staticClass, global::org.apache.http.entity.AbstractHttpEntity_._writeTo32502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength32503;
		public override long getContentLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity_._getContentLength32503);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity_.staticClass, global::org.apache.http.entity.AbstractHttpEntity_._getContentLength32503);
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable32504;
		public override bool isRepeatable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity_._isRepeatable32504);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity_.staticClass, global::org.apache.http.entity.AbstractHttpEntity_._isRepeatable32504);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming32505;
		public override bool isStreaming()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity_._isStreaming32505);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.AbstractHttpEntity_.staticClass, global::org.apache.http.entity.AbstractHttpEntity_._isStreaming32505);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.AbstractHttpEntity_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/AbstractHttpEntity"));
			global::org.apache.http.entity.AbstractHttpEntity_._getContent32501 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity_.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.entity.AbstractHttpEntity_._writeTo32502 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity_.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.entity.AbstractHttpEntity_._getContentLength32503 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity_.staticClass, "getContentLength", "()J");
			global::org.apache.http.entity.AbstractHttpEntity_._isRepeatable32504 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity_.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.entity.AbstractHttpEntity_._isStreaming32505 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity_.staticClass, "isStreaming", "()Z");
		}
	}
}
