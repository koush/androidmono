namespace org.apache.http.client.methods
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase_))]
	public abstract partial class HttpEntityEnclosingRequestBase : org.apache.http.client.methods.HttpRequestBase, HttpEntityEnclosingRequest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpEntityEnclosingRequestBase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone31914;
		public override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase.staticClass, global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase._clone31914)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getEntity31915;
		public virtual global::org.apache.http.HttpEntity getEntity()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpEntity>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase.staticClass, global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase._getEntity31915)) as org.apache.http.HttpEntity;
		}
		internal static global::MonoJavaBridge.MethodId _setEntity31916;
		public virtual void setEntity(org.apache.http.HttpEntity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase.staticClass, global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase._setEntity31916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _expectContinue31917;
		public virtual bool expectContinue()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase.staticClass, global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase._expectContinue31917);
		}
		internal static global::MonoJavaBridge.MethodId _HttpEntityEnclosingRequestBase31918;
		public HttpEntityEnclosingRequestBase() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpEntityEnclosingRequestBase.staticClass, global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase._HttpEntityEnclosingRequestBase31918);
			Init(@__env, handle);
		}
		static HttpEntityEnclosingRequestBase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/methods/HttpEntityEnclosingRequestBase"));
			global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase._clone31914 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase._getEntity31915 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase.staticClass, "getEntity", "()Lorg/apache/http/HttpEntity;");
			global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase._setEntity31916 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase.staticClass, "setEntity", "(Lorg/apache/http/HttpEntity;)V");
			global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase._expectContinue31917 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase.staticClass, "expectContinue", "()Z");
			global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase._HttpEntityEnclosingRequestBase31918 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase))]
	internal sealed partial class HttpEntityEnclosingRequestBase_ : org.apache.http.client.methods.HttpEntityEnclosingRequestBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpEntityEnclosingRequestBase_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getMethod31919;
		public override global::java.lang.String getMethod()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase_._getMethod31919)) as java.lang.String;
		}
		static HttpEntityEnclosingRequestBase_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/methods/HttpEntityEnclosingRequestBase"));
			global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase_._getMethod31919 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpEntityEnclosingRequestBase_.staticClass, "getMethod", "()Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}
