namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.ParameterMetaData_))]
	public partial interface ParameterMetaData  : global::MonoJavaBridge.IJavaObject 
	{
		int getScale(int arg0);
		int getPrecision(int arg0);
		int isNullable(int arg0);
		bool isSigned(int arg0);
		int getParameterCount();
		int getParameterType(int arg0);
		global::java.lang.String getParameterTypeName(int arg0);
		global::java.lang.String getParameterClassName(int arg0);
		int getParameterMode(int arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.ParameterMetaData))]
	internal sealed partial class ParameterMetaData_ : java.lang.Object, ParameterMetaData
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ParameterMetaData_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getScale24646;
		int java.sql.ParameterMetaData.getScale(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ParameterMetaData_.staticClass, "getScale", "(I)I", ref global::java.sql.ParameterMetaData_._getScale24646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPrecision24647;
		int java.sql.ParameterMetaData.getPrecision(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ParameterMetaData_.staticClass, "getPrecision", "(I)I", ref global::java.sql.ParameterMetaData_._getPrecision24647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNullable24648;
		int java.sql.ParameterMetaData.isNullable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ParameterMetaData_.staticClass, "isNullable", "(I)I", ref global::java.sql.ParameterMetaData_._isNullable24648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSigned24649;
		bool java.sql.ParameterMetaData.isSigned(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ParameterMetaData_.staticClass, "isSigned", "(I)Z", ref global::java.sql.ParameterMetaData_._isSigned24649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParameterCount24650;
		int java.sql.ParameterMetaData.getParameterCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ParameterMetaData_.staticClass, "getParameterCount", "()I", ref global::java.sql.ParameterMetaData_._getParameterCount24650);
		}
		internal static global::MonoJavaBridge.MethodId _getParameterType24651;
		int java.sql.ParameterMetaData.getParameterType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ParameterMetaData_.staticClass, "getParameterType", "(I)I", ref global::java.sql.ParameterMetaData_._getParameterType24651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParameterTypeName24652;
		global::java.lang.String java.sql.ParameterMetaData.getParameterTypeName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.ParameterMetaData_.staticClass, "getParameterTypeName", "(I)Ljava/lang/String;", ref global::java.sql.ParameterMetaData_._getParameterTypeName24652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getParameterClassName24653;
		global::java.lang.String java.sql.ParameterMetaData.getParameterClassName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.ParameterMetaData_.staticClass, "getParameterClassName", "(I)Ljava/lang/String;", ref global::java.sql.ParameterMetaData_._getParameterClassName24653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getParameterMode24654;
		int java.sql.ParameterMetaData.getParameterMode(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ParameterMetaData_.staticClass, "getParameterMode", "(I)I", ref global::java.sql.ParameterMetaData_._getParameterMode24654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ParameterMetaData_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.ParameterMetaData_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/ParameterMetaData"));
		}
		internal static void InitJNI()
		{
		}
	}
}
