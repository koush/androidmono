namespace org.apache.http
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface HttpEntity 
	{
		global::java.io.InputStream getContent();
		void writeTo(java.io.OutputStream arg0);
		global::org.apache.http.Header getContentType();
		long getContentLength();
		global::org.apache.http.Header getContentEncoding();
		bool isRepeatable();
		bool isChunked();
		bool isStreaming();
		void consumeContent();
	}

	public partial class HttpEntity_
	{
		public static global::java.lang.Class _class
		{
			get { return __HttpEntity.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __HttpEntity : java.lang.Object, HttpEntity
	{
		internal static global::java.lang.Class staticClass;
		static __HttpEntity()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.__HttpEntity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.__HttpEntity(@__env);
			}
		}
		internal __HttpEntity(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContent14231;
		 global::java.io.InputStream org.apache.http.HttpEntity.getContent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpEntity._getContent14231));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpEntity.staticClass, global::org.apache.http.__HttpEntity._getContent14231));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeTo14232;
		 void org.apache.http.HttpEntity.writeTo(java.io.OutputStream arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpEntity._writeTo14232, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpEntity.staticClass, global::org.apache.http.__HttpEntity._writeTo14232, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContentType14233;
		 global::org.apache.http.Header org.apache.http.HttpEntity.getContentType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpEntity._getContentType14233));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpEntity.staticClass, global::org.apache.http.__HttpEntity._getContentType14233));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContentLength14234;
		 long org.apache.http.HttpEntity.getContentLength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::org.apache.http.__HttpEntity._getContentLength14234);
			else
				return @__env.CallNonVirtualLongMethod(this, global::org.apache.http.__HttpEntity.staticClass, global::org.apache.http.__HttpEntity._getContentLength14234);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContentEncoding14235;
		 global::org.apache.http.Header org.apache.http.HttpEntity.getContentEncoding() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpEntity._getContentEncoding14235));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpEntity.staticClass, global::org.apache.http.__HttpEntity._getContentEncoding14235));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isRepeatable14236;
		 bool org.apache.http.HttpEntity.isRepeatable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.__HttpEntity._isRepeatable14236);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.__HttpEntity.staticClass, global::org.apache.http.__HttpEntity._isRepeatable14236);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isChunked14237;
		 bool org.apache.http.HttpEntity.isChunked() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.__HttpEntity._isChunked14237);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.__HttpEntity.staticClass, global::org.apache.http.__HttpEntity._isChunked14237);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isStreaming14238;
		 bool org.apache.http.HttpEntity.isStreaming() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.__HttpEntity._isStreaming14238);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.__HttpEntity.staticClass, global::org.apache.http.__HttpEntity._isStreaming14238);
		}
		internal static global::net.sf.jni4net.jni.MethodId _consumeContent14239;
		 void org.apache.http.HttpEntity.consumeContent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpEntity._consumeContent14239);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpEntity.staticClass, global::org.apache.http.__HttpEntity._consumeContent14239);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.__HttpEntity.staticClass = @__class;
			global::org.apache.http.__HttpEntity._getContent14231 = @__env.GetMethodID(global::org.apache.http.__HttpEntity.staticClass, "org.apache.http.HttpEntity.getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.__HttpEntity._writeTo14232 = @__env.GetMethodID(global::org.apache.http.__HttpEntity.staticClass, "org.apache.http.HttpEntity.writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.__HttpEntity._getContentType14233 = @__env.GetMethodID(global::org.apache.http.__HttpEntity.staticClass, "org.apache.http.HttpEntity.getContentType", "()Lorg/apache/http/Header;");
			global::org.apache.http.__HttpEntity._getContentLength14234 = @__env.GetMethodID(global::org.apache.http.__HttpEntity.staticClass, "org.apache.http.HttpEntity.getContentLength", "()J");
			global::org.apache.http.__HttpEntity._getContentEncoding14235 = @__env.GetMethodID(global::org.apache.http.__HttpEntity.staticClass, "org.apache.http.HttpEntity.getContentEncoding", "()Lorg/apache/http/Header;");
			global::org.apache.http.__HttpEntity._isRepeatable14236 = @__env.GetMethodID(global::org.apache.http.__HttpEntity.staticClass, "org.apache.http.HttpEntity.isRepeatable", "()Z");
			global::org.apache.http.__HttpEntity._isChunked14237 = @__env.GetMethodID(global::org.apache.http.__HttpEntity.staticClass, "org.apache.http.HttpEntity.isChunked", "()Z");
			global::org.apache.http.__HttpEntity._isStreaming14238 = @__env.GetMethodID(global::org.apache.http.__HttpEntity.staticClass, "org.apache.http.HttpEntity.isStreaming", "()Z");
			global::org.apache.http.__HttpEntity._consumeContent14239 = @__env.GetMethodID(global::org.apache.http.__HttpEntity.staticClass, "org.apache.http.HttpEntity.consumeContent", "()V");
		}
	}
}
