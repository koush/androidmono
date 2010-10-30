namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.@params.AbstractHttpParams_))]
	public abstract partial class AbstractHttpParams : java.lang.Object, HttpParams
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractHttpParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::org.apache.http.@params.HttpParams copy();
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::org.apache.http.@params.HttpParams setParameter(java.lang.String arg0, java.lang.Object arg1);
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::java.lang.Object getParameter(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract bool removeParameter(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual long getLongParameter(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.@params.AbstractHttpParams.staticClass, "getLongParameter", "(Ljava/lang/String;J)J", ref global::org.apache.http.@params.AbstractHttpParams._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::org.apache.http.@params.HttpParams setLongParameter(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.AbstractHttpParams.staticClass, "setLongParameter", "(Ljava/lang/String;J)Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.AbstractHttpParams._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getIntParameter(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.@params.AbstractHttpParams.staticClass, "getIntParameter", "(Ljava/lang/String;I)I", ref global::org.apache.http.@params.AbstractHttpParams._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::org.apache.http.@params.HttpParams setIntParameter(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.AbstractHttpParams.staticClass, "setIntParameter", "(Ljava/lang/String;I)Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.AbstractHttpParams._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual double getDoubleParameter(java.lang.String arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::org.apache.http.@params.AbstractHttpParams.staticClass, "getDoubleParameter", "(Ljava/lang/String;D)D", ref global::org.apache.http.@params.AbstractHttpParams._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::org.apache.http.@params.HttpParams setDoubleParameter(java.lang.String arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.AbstractHttpParams.staticClass, "setDoubleParameter", "(Ljava/lang/String;D)Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.AbstractHttpParams._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool getBooleanParameter(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.@params.AbstractHttpParams.staticClass, "getBooleanParameter", "(Ljava/lang/String;Z)Z", ref global::org.apache.http.@params.AbstractHttpParams._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::org.apache.http.@params.HttpParams setBooleanParameter(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.AbstractHttpParams.staticClass, "setBooleanParameter", "(Ljava/lang/String;Z)Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.AbstractHttpParams._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool isParameterTrue(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.@params.AbstractHttpParams.staticClass, "isParameterTrue", "(Ljava/lang/String;)Z", ref global::org.apache.http.@params.AbstractHttpParams._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool isParameterFalse(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.@params.AbstractHttpParams.staticClass, "isParameterFalse", "(Ljava/lang/String;)Z", ref global::org.apache.http.@params.AbstractHttpParams._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected AbstractHttpParams() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.AbstractHttpParams._m14.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.AbstractHttpParams._m14 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._m14);
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::org.apache.http.@params.HttpParams copy()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.AbstractHttpParams_.staticClass, "copy", "()Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.AbstractHttpParams_._m0) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::org.apache.http.@params.HttpParams setParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.AbstractHttpParams_.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.AbstractHttpParams_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.Object getParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.@params.AbstractHttpParams_.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.apache.http.@params.AbstractHttpParams_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool removeParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.@params.AbstractHttpParams_.staticClass, "removeParameter", "(Ljava/lang/String;)Z", ref global::org.apache.http.@params.AbstractHttpParams_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
