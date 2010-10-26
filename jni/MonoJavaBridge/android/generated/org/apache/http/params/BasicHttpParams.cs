namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class BasicHttpParams : org.apache.http.@params.AbstractHttpParams, java.io.Serializable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicHttpParams()
		{
			InitJNI();
		}
		internal BasicHttpParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone33732;
		public global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.BasicHttpParams._clone33732)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.BasicHttpParams.staticClass, global::org.apache.http.@params.BasicHttpParams._clone33732)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear33733;
		public void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.BasicHttpParams._clear33733);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.BasicHttpParams.staticClass, global::org.apache.http.@params.BasicHttpParams._clear33733);
		}
		internal static global::MonoJavaBridge.MethodId _copy33734;
		public sealed override global::org.apache.http.@params.HttpParams copy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.BasicHttpParams._copy33734)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.BasicHttpParams.staticClass, global::org.apache.http.@params.BasicHttpParams._copy33734)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParameter33735;
		public sealed override global::org.apache.http.@params.HttpParams setParameter(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.BasicHttpParams._setParameter33735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.BasicHttpParams.staticClass, global::org.apache.http.@params.BasicHttpParams._setParameter33735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getParameter33736;
		public sealed override global::java.lang.Object getParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.BasicHttpParams._getParameter33736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.BasicHttpParams.staticClass, global::org.apache.http.@params.BasicHttpParams._getParameter33736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setParameters33737;
		public void setParameters(java.lang.String[] arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.BasicHttpParams._setParameters33737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.BasicHttpParams.staticClass, global::org.apache.http.@params.BasicHttpParams._setParameters33737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeParameter33738;
		public sealed override bool removeParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.@params.BasicHttpParams._removeParameter33738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.@params.BasicHttpParams.staticClass, global::org.apache.http.@params.BasicHttpParams._removeParameter33738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isParameterSet33739;
		public bool isParameterSet(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.@params.BasicHttpParams._isParameterSet33739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.@params.BasicHttpParams.staticClass, global::org.apache.http.@params.BasicHttpParams._isParameterSet33739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isParameterSetLocally33740;
		public bool isParameterSetLocally(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.@params.BasicHttpParams._isParameterSetLocally33740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.@params.BasicHttpParams.staticClass, global::org.apache.http.@params.BasicHttpParams._isParameterSetLocally33740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpParams33741;
		public BasicHttpParams()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.@params.BasicHttpParams.staticClass, global::org.apache.http.@params.BasicHttpParams._BasicHttpParams33741);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.BasicHttpParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/BasicHttpParams"));
			global::org.apache.http.@params.BasicHttpParams._clone33732 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.BasicHttpParams.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.@params.BasicHttpParams._clear33733 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.BasicHttpParams.staticClass, "clear", "()V");
			global::org.apache.http.@params.BasicHttpParams._copy33734 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.BasicHttpParams.staticClass, "copy", "()Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.BasicHttpParams._setParameter33735 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.BasicHttpParams.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.BasicHttpParams._getParameter33736 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.BasicHttpParams.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.@params.BasicHttpParams._setParameters33737 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.BasicHttpParams.staticClass, "setParameters", "([Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.apache.http.@params.BasicHttpParams._removeParameter33738 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.BasicHttpParams.staticClass, "removeParameter", "(Ljava/lang/String;)Z");
			global::org.apache.http.@params.BasicHttpParams._isParameterSet33739 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.BasicHttpParams.staticClass, "isParameterSet", "(Ljava/lang/String;)Z");
			global::org.apache.http.@params.BasicHttpParams._isParameterSetLocally33740 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.BasicHttpParams.staticClass, "isParameterSetLocally", "(Ljava/lang/String;)Z");
			global::org.apache.http.@params.BasicHttpParams._BasicHttpParams33741 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.BasicHttpParams.staticClass, "<init>", "()V");
		}
	}
}
