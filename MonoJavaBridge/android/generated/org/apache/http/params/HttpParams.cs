namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.@params.HttpParams_))]
	public partial interface HttpParams  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.@params.HttpParams copy();
		global::org.apache.http.@params.HttpParams setParameter(java.lang.String arg0, java.lang.Object arg1);
		global::java.lang.Object getParameter(java.lang.String arg0);
		bool removeParameter(java.lang.String arg0);
		long getLongParameter(java.lang.String arg0, long arg1);
		global::org.apache.http.@params.HttpParams setLongParameter(java.lang.String arg0, long arg1);
		int getIntParameter(java.lang.String arg0, int arg1);
		global::org.apache.http.@params.HttpParams setIntParameter(java.lang.String arg0, int arg1);
		double getDoubleParameter(java.lang.String arg0, double arg1);
		global::org.apache.http.@params.HttpParams setDoubleParameter(java.lang.String arg0, double arg1);
		bool getBooleanParameter(java.lang.String arg0, bool arg1);
		global::org.apache.http.@params.HttpParams setBooleanParameter(java.lang.String arg0, bool arg1);
		bool isParameterTrue(java.lang.String arg0);
		bool isParameterFalse(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.@params.HttpParams))]
	internal sealed partial class HttpParams_ : java.lang.Object, HttpParams
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpParams_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _copy33785;
		global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.copy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._copy33785)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParameter33786;
		global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.setParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._setParameter33786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getParameter33787;
		global::java.lang.Object org.apache.http.@params.HttpParams.getParameter(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._getParameter33787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeParameter33788;
		bool org.apache.http.@params.HttpParams.removeParameter(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._removeParameter33788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLongParameter33789;
		long org.apache.http.@params.HttpParams.getLongParameter(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._getLongParameter33789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLongParameter33790;
		global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.setLongParameter(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._setLongParameter33790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getIntParameter33791;
		int org.apache.http.@params.HttpParams.getIntParameter(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._getIntParameter33791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setIntParameter33792;
		global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.setIntParameter(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._setIntParameter33792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getDoubleParameter33793;
		double org.apache.http.@params.HttpParams.getDoubleParameter(java.lang.String arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallDoubleMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._getDoubleParameter33793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDoubleParameter33794;
		global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.setDoubleParameter(java.lang.String arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._setDoubleParameter33794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getBooleanParameter33795;
		bool org.apache.http.@params.HttpParams.getBooleanParameter(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._getBooleanParameter33795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBooleanParameter33796;
		global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.setBooleanParameter(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._setBooleanParameter33796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _isParameterTrue33797;
		bool org.apache.http.@params.HttpParams.isParameterTrue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._isParameterTrue33797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isParameterFalse33798;
		bool org.apache.http.@params.HttpParams.isParameterFalse(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._isParameterFalse33798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static HttpParams_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.HttpParams_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/HttpParams"));
			global::org.apache.http.@params.HttpParams_._copy33785 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "copy", "()Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.HttpParams_._setParameter33786 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.HttpParams_._getParameter33787 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.@params.HttpParams_._removeParameter33788 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "removeParameter", "(Ljava/lang/String;)Z");
			global::org.apache.http.@params.HttpParams_._getLongParameter33789 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "getLongParameter", "(Ljava/lang/String;J)J");
			global::org.apache.http.@params.HttpParams_._setLongParameter33790 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "setLongParameter", "(Ljava/lang/String;J)Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.HttpParams_._getIntParameter33791 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "getIntParameter", "(Ljava/lang/String;I)I");
			global::org.apache.http.@params.HttpParams_._setIntParameter33792 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "setIntParameter", "(Ljava/lang/String;I)Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.HttpParams_._getDoubleParameter33793 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "getDoubleParameter", "(Ljava/lang/String;D)D");
			global::org.apache.http.@params.HttpParams_._setDoubleParameter33794 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "setDoubleParameter", "(Ljava/lang/String;D)Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.HttpParams_._getBooleanParameter33795 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "getBooleanParameter", "(Ljava/lang/String;Z)Z");
			global::org.apache.http.@params.HttpParams_._setBooleanParameter33796 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "setBooleanParameter", "(Ljava/lang/String;Z)Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.HttpParams_._isParameterTrue33797 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "isParameterTrue", "(Ljava/lang/String;)Z");
			global::org.apache.http.@params.HttpParams_._isParameterFalse33798 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "isParameterFalse", "(Ljava/lang/String;)Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
