namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.@params.AbstractHttpParams_))]
	public abstract partial class AbstractHttpParams : java.lang.Object, HttpParams
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractHttpParams()
		{
			InitJNI();
		}
		protected AbstractHttpParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _copy26965;
		public abstract global::org.apache.http.@params.HttpParams copy();
		internal static global::MonoJavaBridge.MethodId _setParameter26966;
		public abstract global::org.apache.http.@params.HttpParams setParameter(java.lang.String arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _getParameter26967;
		public abstract global::java.lang.Object getParameter(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _removeParameter26968;
		public abstract bool removeParameter(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getLongParameter26969;
		public virtual long getLongParameter(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams._getLongParameter26969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._getLongParameter26969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLongParameter26970;
		public virtual global::org.apache.http.@params.HttpParams setLongParameter(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams._setLongParameter26970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._setLongParameter26970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getIntParameter26971;
		public virtual int getIntParameter(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams._getIntParameter26971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._getIntParameter26971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setIntParameter26972;
		public virtual global::org.apache.http.@params.HttpParams setIntParameter(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams._setIntParameter26972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._setIntParameter26972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getDoubleParameter26973;
		public virtual double getDoubleParameter(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams._getDoubleParameter26973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._getDoubleParameter26973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDoubleParameter26974;
		public virtual global::org.apache.http.@params.HttpParams setDoubleParameter(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams._setDoubleParameter26974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._setDoubleParameter26974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getBooleanParameter26975;
		public virtual bool getBooleanParameter(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams._getBooleanParameter26975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._getBooleanParameter26975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBooleanParameter26976;
		public virtual global::org.apache.http.@params.HttpParams setBooleanParameter(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams._setBooleanParameter26976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._setBooleanParameter26976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _isParameterTrue26977;
		public virtual bool isParameterTrue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams._isParameterTrue26977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._isParameterTrue26977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isParameterFalse26978;
		public virtual bool isParameterFalse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams._isParameterFalse26978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._isParameterFalse26978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractHttpParams26979;
		protected AbstractHttpParams()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._AbstractHttpParams26979);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.AbstractHttpParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/@params/AbstractHttpParams"));
			global::org.apache.http.@params.AbstractHttpParams._copy26965 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "copy", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.@params.AbstractHttpParams._setParameter26966 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.@params.AbstractHttpParams._getParameter26967 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.@params.AbstractHttpParams._removeParameter26968 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "removeParameter", "(Ljava/lang/String;)Z");
			global::org.apache.http.@params.AbstractHttpParams._getLongParameter26969 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "getLongParameter", "(Ljava/lang/String;J)J");
			global::org.apache.http.@params.AbstractHttpParams._setLongParameter26970 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "setLongParameter", "(Ljava/lang/String;J)Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.@params.AbstractHttpParams._getIntParameter26971 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "getIntParameter", "(Ljava/lang/String;I)I");
			global::org.apache.http.@params.AbstractHttpParams._setIntParameter26972 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "setIntParameter", "(Ljava/lang/String;I)Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.@params.AbstractHttpParams._getDoubleParameter26973 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "getDoubleParameter", "(Ljava/lang/String;D)D");
			global::org.apache.http.@params.AbstractHttpParams._setDoubleParameter26974 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "setDoubleParameter", "(Ljava/lang/String;D)Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.@params.AbstractHttpParams._getBooleanParameter26975 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "getBooleanParameter", "(Ljava/lang/String;Z)Z");
			global::org.apache.http.@params.AbstractHttpParams._setBooleanParameter26976 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "setBooleanParameter", "(Ljava/lang/String;Z)Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.@params.AbstractHttpParams._isParameterTrue26977 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "isParameterTrue", "(Ljava/lang/String;)Z");
			global::org.apache.http.@params.AbstractHttpParams._isParameterFalse26978 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "isParameterFalse", "(Ljava/lang/String;)Z");
			global::org.apache.http.@params.AbstractHttpParams._AbstractHttpParams26979 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.@params.AbstractHttpParams))]
	public sealed partial class AbstractHttpParams_ : org.apache.http.@params.AbstractHttpParams
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractHttpParams_()
		{
			InitJNI();
		}
		internal AbstractHttpParams_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _copy26980;
		public override global::org.apache.http.@params.HttpParams copy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams_._copy26980)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams_.staticClass, global::org.apache.http.@params.AbstractHttpParams_._copy26980)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParameter26981;
		public override global::org.apache.http.@params.HttpParams setParameter(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams_._setParameter26981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams_.staticClass, global::org.apache.http.@params.AbstractHttpParams_._setParameter26981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getParameter26982;
		public override global::java.lang.Object getParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams_._getParameter26982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams_.staticClass, global::org.apache.http.@params.AbstractHttpParams_._getParameter26982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeParameter26983;
		public override bool removeParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams_._removeParameter26983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams_.staticClass, global::org.apache.http.@params.AbstractHttpParams_._removeParameter26983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.AbstractHttpParams_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/@params/AbstractHttpParams"));
			global::org.apache.http.@params.AbstractHttpParams_._copy26980 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams_.staticClass, "copy", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.@params.AbstractHttpParams_._setParameter26981 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams_.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.@params.AbstractHttpParams_._getParameter26982 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams_.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.@params.AbstractHttpParams_._removeParameter26983 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams_.staticClass, "removeParameter", "(Ljava/lang/String;)Z");
		}
	}
}
