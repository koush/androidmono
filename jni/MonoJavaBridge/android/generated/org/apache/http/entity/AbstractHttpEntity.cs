namespace org.apache.http.entity
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class AbstractHttpEntity : java.lang.Object, HttpEntity
	{
		internal static global::java.lang.Class staticClass;
		static AbstractHttpEntity()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.entity.AbstractHttpEntity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected AbstractHttpEntity(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContent14524;
		public abstract global::java.io.InputStream getContent();
		internal static global::net.sf.jni4net.jni.MethodId _writeTo14525;
		public abstract void writeTo(java.io.OutputStream arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getContentLength14526;
		public abstract long getContentLength();
		internal static global::net.sf.jni4net.jni.MethodId _isRepeatable14527;
		public abstract bool isRepeatable();
		internal static global::net.sf.jni4net.jni.MethodId _isStreaming14528;
		public abstract bool isStreaming();
		internal static global::net.sf.jni4net.jni.MethodId _getContentType14529;
		public virtual global::org.apache.http.Header getContentType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.entity.AbstractHttpEntity._getContentType14529));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._getContentType14529));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setContentType14530;
		public virtual void setContentType(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity._setContentType14530, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._setContentType14530, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setContentType14531;
		public virtual void setContentType(org.apache.http.Header arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity._setContentType14531, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._setContentType14531, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContentEncoding14532;
		public virtual global::org.apache.http.Header getContentEncoding() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.entity.AbstractHttpEntity._getContentEncoding14532));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._getContentEncoding14532));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isChunked14533;
		public virtual bool isChunked() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.entity.AbstractHttpEntity._isChunked14533);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._isChunked14533);
		}
		internal static global::net.sf.jni4net.jni.MethodId _consumeContent14534;
		public virtual void consumeContent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity._consumeContent14534);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._consumeContent14534);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setContentEncoding14535;
		public virtual void setContentEncoding(org.apache.http.Header arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity._setContentEncoding14535, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._setContentEncoding14535, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setContentEncoding14536;
		public virtual void setContentEncoding(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity._setContentEncoding14536, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._setContentEncoding14536, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChunked14537;
		public virtual void setChunked(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity._setChunked14537, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._setChunked14537, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbstractHttpEntity14538;
		protected AbstractHttpEntity()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._AbstractHttpEntity14538, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.entity.AbstractHttpEntity.staticClass = @__class;
			global::org.apache.http.entity.AbstractHttpEntity._getContent14524 = @__env.GetMethodID(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.entity.AbstractHttpEntity._writeTo14525 = @__env.GetMethodID(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.entity.AbstractHttpEntity._getContentLength14526 = @__env.GetMethodID(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "getContentLength", "()J");
			global::org.apache.http.entity.AbstractHttpEntity._isRepeatable14527 = @__env.GetMethodID(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.entity.AbstractHttpEntity._isStreaming14528 = @__env.GetMethodID(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "isStreaming", "()Z");
			global::org.apache.http.entity.AbstractHttpEntity._getContentType14529 = @__env.GetMethodID(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "getContentType", "()Lorg/apache/http/Header;");
			global::org.apache.http.entity.AbstractHttpEntity._setContentType14530 = @__env.GetMethodID(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setContentType", "(Ljava/lang/String;)V");
			global::org.apache.http.entity.AbstractHttpEntity._setContentType14531 = @__env.GetMethodID(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setContentType", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.entity.AbstractHttpEntity._getContentEncoding14532 = @__env.GetMethodID(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "getContentEncoding", "()Lorg/apache/http/Header;");
			global::org.apache.http.entity.AbstractHttpEntity._isChunked14533 = @__env.GetMethodID(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "isChunked", "()Z");
			global::org.apache.http.entity.AbstractHttpEntity._consumeContent14534 = @__env.GetMethodID(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "consumeContent", "()V");
			global::org.apache.http.entity.AbstractHttpEntity._setContentEncoding14535 = @__env.GetMethodID(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setContentEncoding", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.entity.AbstractHttpEntity._setContentEncoding14536 = @__env.GetMethodID(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setContentEncoding", "(Ljava/lang/String;)V");
			global::org.apache.http.entity.AbstractHttpEntity._setChunked14537 = @__env.GetMethodID(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setChunked", "(Z)V");
			global::org.apache.http.entity.AbstractHttpEntity._AbstractHttpEntity14538 = @__env.GetMethodID(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "<init>", "()V");
		}
	}
}
