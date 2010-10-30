namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.@params.AbstractHttpParams_))]
	public abstract partial class AbstractHttpParams : java.lang.Object, HttpParams
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractHttpParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _copy33714;
		public abstract global::org.apache.http.@params.HttpParams copy();
		internal static global::MonoJavaBridge.MethodId _setParameter33715;
		public abstract global::org.apache.http.@params.HttpParams setParameter(java.lang.String arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _getParameter33716;
		public abstract global::java.lang.Object getParameter(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _removeParameter33717;
		public abstract bool removeParameter(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getLongParameter33718;
		public virtual long getLongParameter(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.@params.AbstractHttpParams.staticClass, "getLongParameter", "(Ljava/lang/String;J)J", ref global::org.apache.http.@params.AbstractHttpParams._getLongParameter33718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLongParameter33719;
		public virtual global::org.apache.http.@params.HttpParams setLongParameter(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.AbstractHttpParams.staticClass, "setLongParameter", "(Ljava/lang/String;J)Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.AbstractHttpParams._setLongParameter33719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getIntParameter33720;
		public virtual int getIntParameter(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.@params.AbstractHttpParams.staticClass, "getIntParameter", "(Ljava/lang/String;I)I", ref global::org.apache.http.@params.AbstractHttpParams._getIntParameter33720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setIntParameter33721;
		public virtual global::org.apache.http.@params.HttpParams setIntParameter(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.AbstractHttpParams.staticClass, "setIntParameter", "(Ljava/lang/String;I)Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.AbstractHttpParams._setIntParameter33721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getDoubleParameter33722;
		public virtual double getDoubleParameter(java.lang.String arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::org.apache.http.@params.AbstractHttpParams.staticClass, "getDoubleParameter", "(Ljava/lang/String;D)D", ref global::org.apache.http.@params.AbstractHttpParams._getDoubleParameter33722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDoubleParameter33723;
		public virtual global::org.apache.http.@params.HttpParams setDoubleParameter(java.lang.String arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.AbstractHttpParams.staticClass, "setDoubleParameter", "(Ljava/lang/String;D)Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.AbstractHttpParams._setDoubleParameter33723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getBooleanParameter33724;
		public virtual bool getBooleanParameter(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.@params.AbstractHttpParams.staticClass, "getBooleanParameter", "(Ljava/lang/String;Z)Z", ref global::org.apache.http.@params.AbstractHttpParams._getBooleanParameter33724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBooleanParameter33725;
		public virtual global::org.apache.http.@params.HttpParams setBooleanParameter(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.AbstractHttpParams.staticClass, "setBooleanParameter", "(Ljava/lang/String;Z)Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.AbstractHttpParams._setBooleanParameter33725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _isParameterTrue33726;
		public virtual bool isParameterTrue(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.@params.AbstractHttpParams.staticClass, "isParameterTrue", "(Ljava/lang/String;)Z", ref global::org.apache.http.@params.AbstractHttpParams._isParameterTrue33726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isParameterFalse33727;
		public virtual bool isParameterFalse(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.@params.AbstractHttpParams.staticClass, "isParameterFalse", "(Ljava/lang/String;)Z", ref global::org.apache.http.@params.AbstractHttpParams._isParameterFalse33727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractHttpParams33728;
		protected AbstractHttpParams() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.AbstractHttpParams._AbstractHttpParams33728.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.AbstractHttpParams._AbstractHttpParams33728 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._AbstractHttpParams33728);
			Init(@__env, handle);
		}
		static AbstractHttpParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.AbstractHttpParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/AbstractHttpParams"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.@params.AbstractHttpParams))]
	internal sealed partial class AbstractHttpParams_ : org.apache.http.@params.AbstractHttpParams
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractHttpParams_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _copy33729;
		public override global::org.apache.http.@params.HttpParams copy()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.AbstractHttpParams_.staticClass, "copy", "()Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.AbstractHttpParams_._copy33729) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParameter33730;
		public override global::org.apache.http.@params.HttpParams setParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.AbstractHttpParams_.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.AbstractHttpParams_._setParameter33730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getParameter33731;
		public override global::java.lang.Object getParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.@params.AbstractHttpParams_.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.apache.http.@params.AbstractHttpParams_._getParameter33731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeParameter33732;
		public override bool removeParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.@params.AbstractHttpParams_.staticClass, "removeParameter", "(Ljava/lang/String;)Z", ref global::org.apache.http.@params.AbstractHttpParams_._removeParameter33732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static AbstractHttpParams_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.AbstractHttpParams_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/AbstractHttpParams"));
		}
		internal static void InitJNI()
		{
		}
	}
}
