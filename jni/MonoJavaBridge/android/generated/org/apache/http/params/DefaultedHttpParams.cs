namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class DefaultedHttpParams : org.apache.http.@params.AbstractHttpParams
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DefaultedHttpParams()
		{
			InitJNI();
		}
		internal DefaultedHttpParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _copy33758;
		public sealed override global::org.apache.http.@params.HttpParams copy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.DefaultedHttpParams._copy33758)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.DefaultedHttpParams.staticClass, global::org.apache.http.@params.DefaultedHttpParams._copy33758)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParameter33759;
		public sealed override global::org.apache.http.@params.HttpParams setParameter(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.DefaultedHttpParams._setParameter33759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.DefaultedHttpParams.staticClass, global::org.apache.http.@params.DefaultedHttpParams._setParameter33759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getParameter33760;
		public sealed override global::java.lang.Object getParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.DefaultedHttpParams._getParameter33760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.DefaultedHttpParams.staticClass, global::org.apache.http.@params.DefaultedHttpParams._getParameter33760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeParameter33761;
		public sealed override bool removeParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.@params.DefaultedHttpParams._removeParameter33761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.@params.DefaultedHttpParams.staticClass, global::org.apache.http.@params.DefaultedHttpParams._removeParameter33761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.@params.HttpParams Defaults
		{
			get
			{
				return getDefaults();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaults33762;
		public global::org.apache.http.@params.HttpParams getDefaults() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.DefaultedHttpParams._getDefaults33762)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.DefaultedHttpParams.staticClass, global::org.apache.http.@params.DefaultedHttpParams._getDefaults33762)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultedHttpParams33763;
		public DefaultedHttpParams(org.apache.http.@params.HttpParams arg0, org.apache.http.@params.HttpParams arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.@params.DefaultedHttpParams.staticClass, global::org.apache.http.@params.DefaultedHttpParams._DefaultedHttpParams33763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.DefaultedHttpParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/DefaultedHttpParams"));
			global::org.apache.http.@params.DefaultedHttpParams._copy33758 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.DefaultedHttpParams.staticClass, "copy", "()Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.DefaultedHttpParams._setParameter33759 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.DefaultedHttpParams.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.DefaultedHttpParams._getParameter33760 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.DefaultedHttpParams.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.@params.DefaultedHttpParams._removeParameter33761 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.DefaultedHttpParams.staticClass, "removeParameter", "(Ljava/lang/String;)Z");
			global::org.apache.http.@params.DefaultedHttpParams._getDefaults33762 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.DefaultedHttpParams.staticClass, "getDefaults", "()Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.DefaultedHttpParams._DefaultedHttpParams33763 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.DefaultedHttpParams.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/params/HttpParams;)V");
		}
	}
}
