namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class BasicHttpParams : org.apache.http.@params.AbstractHttpParams, java.io.Serializable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BasicHttpParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone33733;
		public global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.@params.BasicHttpParams.staticClass, "clone", "()Ljava/lang/Object;", ref global::org.apache.http.@params.BasicHttpParams._clone33733) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear33734;
		public void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.@params.BasicHttpParams.staticClass, "clear", "()V", ref global::org.apache.http.@params.BasicHttpParams._clear33734);
		}
		internal static global::MonoJavaBridge.MethodId _copy33735;
		public sealed override global::org.apache.http.@params.HttpParams copy()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.BasicHttpParams.staticClass, "copy", "()Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.BasicHttpParams._copy33735) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParameter33736;
		public sealed override global::org.apache.http.@params.HttpParams setParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.BasicHttpParams.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.BasicHttpParams._setParameter33736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getParameter33737;
		public sealed override global::java.lang.Object getParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.@params.BasicHttpParams.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.apache.http.@params.BasicHttpParams._getParameter33737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setParameters33738;
		public void setParameters(java.lang.String[] arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.@params.BasicHttpParams.staticClass, "setParameters", "([Ljava/lang/String;Ljava/lang/Object;)V", ref global::org.apache.http.@params.BasicHttpParams._setParameters33738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeParameter33739;
		public sealed override bool removeParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.@params.BasicHttpParams.staticClass, "removeParameter", "(Ljava/lang/String;)Z", ref global::org.apache.http.@params.BasicHttpParams._removeParameter33739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isParameterSet33740;
		public bool isParameterSet(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.@params.BasicHttpParams.staticClass, "isParameterSet", "(Ljava/lang/String;)Z", ref global::org.apache.http.@params.BasicHttpParams._isParameterSet33740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isParameterSetLocally33741;
		public bool isParameterSetLocally(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.@params.BasicHttpParams.staticClass, "isParameterSetLocally", "(Ljava/lang/String;)Z", ref global::org.apache.http.@params.BasicHttpParams._isParameterSetLocally33741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpParams33742;
		public BasicHttpParams() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.BasicHttpParams._BasicHttpParams33742.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.BasicHttpParams._BasicHttpParams33742 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.BasicHttpParams.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.@params.BasicHttpParams.staticClass, global::org.apache.http.@params.BasicHttpParams._BasicHttpParams33742);
			Init(@__env, handle);
		}
		static BasicHttpParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.BasicHttpParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/BasicHttpParams"));
		}
		internal static void InitJNI()
		{
		}
	}
}
